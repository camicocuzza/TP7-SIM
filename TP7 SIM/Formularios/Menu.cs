using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7_SIM.Clases;

namespace TP7_SIM.Formularios
{
    public partial class Menu : Form
    {
        private static readonly Random random = new Random();


        public Menu()
        {
            InitializeComponent();


            tbxDemoraCuracion.Text = 0.ToString();
            tbxDemoraVacuna.Text = 0.ToString();
            tbxDemoraCalmante.Text = 0.ToString();
            tbxDesdeCM.Text = 0.ToString();
            tbxHastaCM.Text = 0.ToString();
            tbxMediaCons.Text = 0.ToString();
            tbxMediaEnf.Text = 0.ToString();
        }

        public void mayorACero(List<double> valores)
        {
            for (int i = 0; i < valores.Count; i++)
            {
                if (valores[i] == 0.0)
                {
                    valores[i] = 9999.99;
                }
            }
        }

        public List<double> llegadaPacienteCons(List<Paciente> total_pacientes, double mediaCons, object[][] vector, double reloj, Medico medico1, Medico medico2,
            Enfermero enfermero1, double a, double b, double acTiempoPermanencia, double acTiempoOcupacion, double acPacientesAtendidos, double acCalmantes, double proxLlegadaEnf)
        {
            string evento = "Llegada Paciente Consulta";
            double rndLlegadaCons = random.NextDouble();
            double entreLlegadaConsulta = -mediaCons * Math.Log(1 - rndLlegadaCons);
            double proximaLlegadaCons = entreLlegadaConsulta + reloj;
            double rndDemoraCons = 0;
            double demoraConsulta = 0;

            Paciente paciente = new Paciente();
            paciente.hora_llegada = reloj;
            paciente.id = total_pacientes.Count();

            List<double> result = new List<double>();
            if (medico1.estado == "Libre")
            {
                rndDemoraCons = random.NextDouble();
                demoraConsulta = a + (rndDemoraCons * (b - a));

                // por defecto atendidos por médico 1

                /* Se modifica el estado del paciente a RC (realizando consulta) y se le pone el número del médico1
                Al medico1 se le cambia el estado a Ocupado 
                Se modifica el fin de consulta sumandole a la demora de consulta el reloj. 
                Por último agregamos a la colaPacientesConsulta, el paciente.*/

                paciente.numMedico = 1;
                paciente.estado = "RC Médico " + paciente.numMedico.ToString();
                medico1.estado = "Ocupado";
                medico1.finConsulta = demoraConsulta + reloj;
                medico1.pacienteAtendido = paciente;
                //Medico.colaPacientes.Enqueue(paciente); NO

                vector[0][10] = rndDemoraCons;
                vector[0][11] = demoraConsulta;


            }
            else if (medico1.estado == "Ocupado" && medico2.estado == "Libre")
            {
                rndDemoraCons = random.NextDouble();
                demoraConsulta = a + (rndDemoraCons * (b - a));

                paciente.numMedico = 2;
                paciente.estado = "RC Médico " + paciente.numMedico.ToString();
                medico2.estado = "Ocupado";
                medico2.finConsulta = demoraConsulta + reloj;
                medico2.pacienteAtendido = paciente;


                vector[0][10] = rndDemoraCons;
                vector[0][11] = demoraConsulta;
            }

            //los dos médicos ocupados
            else
            {
                paciente.estado = "EC";         //(esperando consulta)
                Medico.colaPacientes.Enqueue(paciente);
            }

            vector[1] = vector[0];
            total_pacientes.Add(paciente);
            vector[0] = new object[] {evento, reloj, rndLlegadaCons, entreLlegadaConsulta, proximaLlegadaCons, 0, 0, proxLlegadaEnf, 0, "", rndDemoraCons, demoraConsulta, medico1.finConsulta,
                medico2.finConsulta, 0, "", enfermero1.finAtencion, medico1.estado, medico2.estado, Medico.colaPacientes.Count(), enfermero1.estado,
                Enfermero.colaEnfermeria.Count(), acTiempoOcupacion, acPacientesAtendidos, acCalmantes, acTiempoPermanencia };

            foreach (Paciente p in total_pacientes)
            {
                Array.Resize(ref vector[0], vector[0].Count() + 1);
                vector[0][vector[0].Count() - 1] = p.estado;
            }

            if (vector[1][20].ToString() == "Ocupado")
            {
                acTiempoOcupacion += reloj;
            }


            result.Add(rndDemoraCons);
            result.Add(demoraConsulta);
            result.Add(acTiempoOcupacion);

            return result;
        }

        public List<double> llegadaPacienteEnf(List<Paciente> total_pacientes, double mediaEnf, object[][] vector, double reloj, Medico medico1, Medico medico2,
            Enfermero enfermero1, double demoraCuracion, double demoraVacunacion, double acTiempoPermanencia, double acTiempoOcupacion, double acPacientesAtendidos, 
            double acCalmantes, double proxLlegadaCons)
        {
            List<double> result = new List<double>();

            string evento = "Llegada Paciente Enfermería";
            double rndLlegadaEnf = random.NextDouble();
            double entreLlegadaEnf = -mediaEnf * Math.Log(1 - rndLlegadaEnf);
            double proximaLlegadaEnf = entreLlegadaEnf + reloj;

            double demoraEnfermeria = 0;

            double rndTipoAtencion = 0;
            string tipoAtencion = "";

            Paciente paciente = new Paciente();
            paciente.hora_llegada = reloj;
            paciente.id = total_pacientes.Count();

            if (rndTipoAtencion < 0.40)
            {
                paciente.tipoAtencion = "Curación";
                tipoAtencion = "Curación";
            }
            else
            {
                paciente.tipoAtencion = "Vacunación";
                tipoAtencion = "Vacunación";
            }

            if (enfermero1.estado == "Libre")
            {
                if (tipoAtencion == "Curación")
                {
                    paciente.estado = "SCU";
                    demoraEnfermeria = demoraCuracion;

                }
                else
                {
                    paciente.estado = "SV";
                    demoraEnfermeria = demoraVacunacion + 1.55; //más spray antidolor

                }

                enfermero1.estado = "Ocupado";
                enfermero1.finAtencion = demoraEnfermeria + reloj;
                Enfermero.colaEnfermeria.Enqueue(paciente);


                //vector[0][] = demoraEnfermeria;
                vector[0][8] = rndTipoAtencion;
                vector[0][9] = tipoAtencion;
            }
            else
            {
                if (paciente.tipoAtencion == "Curación")
                {
                    paciente.estado = "ECU";
                }
                else
                {
                    paciente.estado = "EV";
                }

                Enfermero.colaEnfermeria.Enqueue(paciente);
            }

            vector[1] = vector[0];
            total_pacientes.Add(paciente);
            vector[0] = new object[] {evento, reloj, 0, 0, proxLlegadaCons, rndLlegadaEnf, entreLlegadaEnf, proximaLlegadaEnf,rndTipoAtencion, tipoAtencion, 0, 0, medico1.finConsulta,
                medico2.finConsulta, 0, "", enfermero1.finAtencion, medico1.estado, medico2.estado, Medico.colaPacientes.Count(), enfermero1.estado,
                Enfermero.colaEnfermeria.Count(), acTiempoOcupacion, acPacientesAtendidos, acCalmantes, acTiempoPermanencia};


            foreach (Paciente p in total_pacientes)
            {
                Array.Resize(ref vector[0], vector[0].Count() + 1);
                vector[0][vector[0].Count() - 1] = p.estado;
            }

            if (vector[1][20].ToString() == "Ocupado")
            {
                acTiempoOcupacion += reloj;
            }

            result.Add(acTiempoOcupacion);
            return result;
        }

        //evento fin de consulta médica
        public List<double> finConsulta(List<Paciente> total_pacientes, double finConsulta, double a, double b, Medico medico1, Medico medico2, Enfermero enfermero1,
            double demoraCalmante, double reloj, double proximaLlegada, double acTiempoPerm, double acPacientesAtendidos, object[][] vector, double acTiempoOcupacion,
            double acCalmantes, double proxLlegadaEnf, double proxLlegadaCons)
        {
            List<double> result = new List<double>();

            string evento = "Fin consulta médica";
            double rndDemoraCons = 0;
            double rndLlegadaCons = 0;
            double demoraConsulta = 0;
            double rndCalmante = 0;
            string calmante = "";
            double demoraEnfermeria = 0;


            if (medico1.finConsulta == reloj)
            {
                Paciente pacAtendido = medico1.pacienteAtendido;

                rndCalmante = random.NextDouble();

                //si aplica calmante
                if (rndCalmante < 0.65)
                {
                    calmante = "Sí";

                    if (Enfermero.colaEnfermeria.Count() > 0)
                    {
                        Enfermero.colaEnfermeria.Enqueue(pacAtendido);

                        foreach (Paciente p in total_pacientes)
                        {
                            if (pacAtendido.id == p.id)
                            {
                                p.estado = "ECA"; //esperando calmante
                            }
                        }
                    }

                    else
                    {
                        Enfermero.colaEnfermeria.Enqueue(pacAtendido);
                        enfermero1.estado = "Ocupado";
                        demoraEnfermeria = demoraCalmante + 1.55;

                        foreach (Paciente p in total_pacientes)
                        {
                            if (pacAtendido.id == p.id)
                            {
                                p.estado = "ACA"; //aplicando calmante

                            }
                        }

                    }
                }

                //no aplica calmante, eliminado del sistema
                else
                {
                    double tiempoPermanencia = reloj - pacAtendido.hora_llegada;
                    acTiempoPerm += tiempoPermanencia;
                    
                    foreach (Paciente p in total_pacientes)
                    {
                        if (pacAtendido.id == p.id)
                        {
                            p.estado = "Finalizado";
                        }
                    }
                }

                if (Medico.colaPacientes.Count() > 0)
                {
                    rndDemoraCons = random.NextDouble();
                    demoraConsulta = a + (rndDemoraCons * (b - a));

                    Paciente siguiente = Medico.colaPacientes.First();
                    medico1.pacienteAtendido = siguiente;

                    siguiente.numMedico = 1;
                    siguiente.estado = "RC Médico " + siguiente.numMedico.ToString();

                    Medico.colaPacientes.Dequeue();

                    medico1.finConsulta = demoraConsulta + reloj;

                    foreach (Paciente p in total_pacientes)
                    {
                        if (siguiente.id == p.id)
                        {
                            p.estado = siguiente.estado;
                        }
                    }
                }

                else
                {
                    medico1.pacienteAtendido = null;
                    medico1.estado = "Libre";
                    medico1.finConsulta = 0;
                    
                }
            }


            if (medico2.finConsulta == reloj)
            {
                Paciente pacAtendido = medico2.pacienteAtendido;

                rndCalmante = random.NextDouble();

                //si aplica calmante
                if (rndCalmante < 0.65)
                {
                    calmante = "Sí";

                    if (Enfermero.colaEnfermeria.Count() > 0)
                    {
                        Enfermero.colaEnfermeria.Enqueue(pacAtendido);

                        foreach (Paciente p in total_pacientes)
                        {
                            if (pacAtendido.id == p.id)
                            {
                                p.estado = "ECA"; //esperando calmante
                            }
                        }
                    }

                    else
                    {
                        Enfermero.colaEnfermeria.Enqueue(pacAtendido);
                        enfermero1.estado = "Ocupado";
                        demoraEnfermeria = demoraCalmante + 1.55;

                        foreach (Paciente p in total_pacientes)
                        {
                            if (pacAtendido.id == p.id)
                            {
                                p.estado = "ACA"; //aplicando calmante
                            }
                        }
                    }
                }

                //no aplica calmante, eliminado del sistema
                else
                {
                    double tiempoPermanencia = reloj - pacAtendido.hora_llegada;
                    acTiempoPerm += tiempoPermanencia;
                    acPacientesAtendidos++; //va acá?


                    foreach (Paciente p in total_pacientes)
                    {
                        if (pacAtendido.id == p.id)
                        {
                            p.estado = "Finalizado";
                        }
                    }
                }

                if (Medico.colaPacientes.Count() > 0)
                {
                    rndDemoraCons = random.NextDouble();
                    demoraConsulta = a + (rndDemoraCons * (b - a));

                    Paciente siguiente = Medico.colaPacientes.First();
                    medico1.pacienteAtendido = siguiente;

                    siguiente.numMedico = 2;
                    siguiente.estado = "RC Médico " + siguiente.numMedico.ToString();

                    Medico.colaPacientes.Dequeue();

                    medico2.finConsulta = demoraConsulta + reloj;

                    foreach (Paciente p in total_pacientes)
                    {
                        if (siguiente.id == p.id)
                        {
                            p.estado = siguiente.estado;
                        }
                    }
                }

                else
                {
                    medico2.pacienteAtendido = null;
                    medico2.estado = "Libre";
                    medico2.finConsulta = 0;
                    
                }
            }
          
            vector[1] = vector[0];
            vector[0] = new object[] {evento, reloj, 0, 0, proxLlegadaCons, 0, 0, proxLlegadaEnf, 0, "", rndDemoraCons, demoraConsulta, medico1.finConsulta,
                medico2.finConsulta, rndCalmante, calmante, enfermero1.finAtencion, medico1.estado, medico2.estado, Medico.colaPacientes.Count(), enfermero1.estado,
                Enfermero.colaEnfermeria.Count(), acTiempoOcupacion, acPacientesAtendidos, acCalmantes, acTiempoPerm };

            foreach (Paciente p in total_pacientes)
            {
                Array.Resize(ref vector[0], vector[0].Count() + 1);
                vector[0][vector[0].Count() - 1] = p.estado;
            }

            if (vector[1][20].ToString() == "Ocupado")
            {
                acTiempoOcupacion += reloj;
            }
            result.Add(acTiempoPerm);
            result.Add(acTiempoOcupacion);
            result.Add(acPacientesAtendidos);

            return result;

        }

        //evento fin de enfermería
        public List<double> finEnfermeriaMet(List<Paciente> total_pacientes, Medico medico1, Medico medico2, Enfermero enfermero1, double reloj,
            double demoraCuracion, double demoraVacunacion, double demoraCalmante, double acTiempoPerm, double acPacientesAtendidos, object[][] vector, 
            double acTiempoOcupacion, double acCalmantes, double proxLlegadaEnf, double proxLlegadaCons)
        {
            List<double> result = new List<double>();

            string evento = "Fin Enfermería";
            double demoraEnfermeria;
            
            Paciente pacienteAtendido = Enfermero.colaEnfermeria.First();
            Enfermero.colaEnfermeria.Dequeue();


            if (enfermero1.finAtencion == reloj)
            {
                if (Enfermero.colaEnfermeria.Count() > 0)
                {
                    Paciente siguienteP = Enfermero.colaEnfermeria.First();

                    if (siguienteP.tipoAtencion == "Curación")
                    {
                        demoraEnfermeria = demoraCuracion;
                        siguienteP.estado = "SCU";
                        
                    }
                    else if (siguienteP.tipoAtencion == "Vacunación")
                    {
                        demoraEnfermeria = demoraVacunacion + 1.55;
                        siguienteP.estado = "SV";
                    }
                    //calmante
                    else
                    {
                        demoraEnfermeria = demoraCalmante + 1.55;
                        siguienteP.estado = "ACA";
                        acCalmantes++;
                    }

                    enfermero1.finAtencion = demoraEnfermeria + reloj;
                }

                //No hay cola
                else
                {
                    enfermero1.estado = "Libre";
                    enfermero1.finAtencion = 0;

                }

                pacienteAtendido.estado = "Finalizado";
                acPacientesAtendidos++;
                double tiempoPermanencia = reloj - pacienteAtendido.hora_llegada;
                acTiempoPerm += tiempoPermanencia;
            }
                                             
                vector[1] = vector[0];
                vector[0] = new object[] {evento, reloj, 0, 0, proxLlegadaCons, 0, 0, proxLlegadaEnf, 0, "", 0, "", medico1.finConsulta,
                medico2.finConsulta, 0, "", enfermero1.finAtencion, medico1.estado, medico2.estado, Medico.colaPacientes.Count(), enfermero1.estado,
                Enfermero.colaEnfermeria.Count(), acTiempoOcupacion, acPacientesAtendidos, acCalmantes, acTiempoPerm};


                foreach (Paciente p in total_pacientes)
                {
                    Array.Resize(ref vector[0], vector[0].Count() + 1);
                    vector[0][vector[0].Count() - 1] = p.estado;
                }

            if (vector[1][20].ToString() == "Ocupado")
            {
                acTiempoOcupacion += reloj;
            }

            result.Add(acCalmantes);
            result.Add(acTiempoPerm);
            result.Add(acPacientesAtendidos);
            result.Add(acTiempoOcupacion);

            return result;
        }

        public void inicializacion(double mediaCons, double mediaEnf, object[][] vector)
        {
            double reloj = 0.0;
            string evento = "Inicialización";
            double rndLlegadaCons = random.NextDouble();
            double entre_LlegadaCons = -mediaCons * Math.Log(1 - rndLlegadaCons);
            double proxLlegadaCons = entre_LlegadaCons + reloj;
            double rndLlegadaEnf = random.NextDouble();
            double entre_LlegadaEnf = -mediaEnf * Math.Log(1 - rndLlegadaEnf);
            double proxLlegadaEnf = entre_LlegadaEnf + reloj;

            vector[0] = new object[] {evento, reloj, rndLlegadaCons, entre_LlegadaCons, proxLlegadaCons, rndLlegadaEnf, entre_LlegadaEnf, proxLlegadaEnf,
                0, "", 0, 0, 0, 0, 0, "", 0, "Libre", "Libre", 0, "Libre", 0, 0, 0, 0, 0};
            vector[1] = vector[0];
        }

        // Cambia la cola de pacientes en una pila
        public Stack<Paciente> colaAPila(Queue<Paciente> pacientes)
        {

            Stack<Paciente> pilaPacientes = new Stack<Paciente>();

            foreach (Paciente pac in pacientes)
            {
                pilaPacientes.Push(pac);
            }
            return pilaPacientes;
        }

        // Cambia la pila de pacientes en una cola
        public Queue<Paciente> pilaACola(Stack<Paciente> pilaPacientes)
        {

            Queue<Paciente> colaPacientes = new Queue<Paciente>();

            foreach (Paciente pac in pilaPacientes)
            {
                colaPacientes.Enqueue(pac);
            }
            return colaPacientes;
        }

      
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Medico medico1 = new Medico();

            Medico medico2 = new Medico();

            Enfermero enfermero1 = new Enfermero();

            string iter = txtIteraciones.Text;
            string des = tbxDesde.Text;

            if (iter == "" || des == "")
            {
                MessageBox.Show("Ingrese todos los valores");
                txtIteraciones.Focus();
            }
            else
            {
                double iteracion = double.Parse(iter);
                double desde = double.Parse(des);
                double hasta = desde + 100.00;
                double mediaCons = double.Parse(tbxMediaCons.Text);
                double mediaEnf = double.Parse(tbxMediaEnf.Text);
                double a = double.Parse(tbxDesdeCM.Text);
                double b = double.Parse(tbxHastaCM.Text);
                double demoraVacunacion = double.Parse(tbxDemoraVacuna.Text);
                double demoraCuracion = double.Parse(tbxDemoraCuracion.Text);
                double demoraCalmante = double.Parse(tbxDemoraCalmante.Text);

                object[][] vectorEstado = new object[2][];
                vectorEstado[0] = new object[26];
                vectorEstado[1] = new object[26];

                List<double> resultados = new List<double>();


                if (desde < iteracion)
                {
                    double minuto = 0.0;
                    double proximaLlegadaCons;
                    double proximaLlegadaEnfe;
                    double finConsulta1;
                    double finConsulta2;
                    double finEnfermeria;
                    
                    //estadisticas
                    double acPacientesAtendidos = 0;
                    double acTiempoOcupacion = 0;
                    double acCalmantes = 0;
                    double acTiempoPermanencia = 0;


                    //promedios
                    double promedioTiempoPermanencia;
                    double promedioTiempoOcupacion;

                    //objetos temporales
                    List<Paciente> estados_pacientes = new List<Paciente>();

                    while (minuto <= iteracion)
                    {
                        /* if (minuto == iteracion)
                         {
                             promedioTiempoPermanencia = acTiempoPermanencia / acPacientesAtendidos;
                             lblPromedioPermanencia.Text = promedioTiempoPermanencia.ToString();
                             promedioTiempoOcupacion = acTiempoOcupacion / minuto;
                             lblPromedioOcupacion.Text = promedioTiempoOcupacion.ToString();
                          }*/

                        //inicialización
                        if (minuto == 0.0)
                        {
                            medico1.estado = "Libre";
                            medico2.estado = "Libre";
                            Medico.colaPacientes = new Queue<Paciente>();
                            enfermero1.estado = "Libre";
                            Enfermero.colaEnfermeria = new Queue<Paciente>();

                            inicializacion(mediaCons, mediaEnf, vectorEstado);
                            dgv_datos.Rows.Add(vectorEstado[0]);

                            if (Convert.ToDouble(vectorEstado[0][4]) < Convert.ToDouble(vectorEstado[0][7]))
                            {
                                minuto = Convert.ToDouble(vectorEstado[0][4]);
                            }
                            else
                            {
                                minuto = Convert.ToDouble(vectorEstado[0][7]);
                            }

                        }
                        else
                        {
                            proximaLlegadaCons = Convert.ToDouble(vectorEstado[0][4]);
                            finConsulta1 = Convert.ToDouble(vectorEstado[0][12]);
                            finConsulta2 = Convert.ToDouble(vectorEstado[0][13]);
                            proximaLlegadaEnfe = Convert.ToDouble(vectorEstado[0][7]);
                            finEnfermeria = Convert.ToDouble(vectorEstado[0][16]);


                            List<double> tiemposComparar = new List<double> { proximaLlegadaCons, finConsulta1, finConsulta2, proximaLlegadaEnfe, finEnfermeria };

                            mayorACero(tiemposComparar);


                            double menorTiempo = tiemposComparar.Min();

                            if (menorTiempo == finConsulta1)
                            {
                                minuto = finConsulta1;


                                //public List<double> finConsulta(List<Paciente> total_pacientes, double finConsulta, double a, double b, Medico medico1, Medico medico2, double reloj, double proximaLlegada, double acTiempoPerm, int cantPacientesAtendidos, object[][] vector, double acTiempoOcupacion, double acCalmantes)
                                resultados = finConsulta(estados_pacientes, 0, a, b, medico1, medico2, enfermero1, demoraCalmante, minuto, proximaLlegadaCons, acTiempoPermanencia,
                                    acPacientesAtendidos, vectorEstado, acTiempoOcupacion, acCalmantes, proximaLlegadaEnfe, proximaLlegadaCons);

                                acTiempoOcupacion = resultados[1];
                                vectorEstado[0][22] = acTiempoOcupacion;

                                acPacientesAtendidos++;
                                vectorEstado[0][23] = acPacientesAtendidos;

                                //vectorEstado[0][22] = acCalmantes;

                                acTiempoPermanencia = resultados.Last();
                                vectorEstado[0][25] = acTiempoPermanencia;


                                if (minuto >= desde && minuto <= hasta)
                                {
                                    dgv_datos.Rows.Add(vectorEstado[0]);
                                }

                            }

                            else if (menorTiempo == finConsulta2)
                            {
                                minuto = finConsulta2;

                                //public List<double> finConsulta(List<Paciente> total_pacientes, double finConsulta, double a, double b, Medico medico1, Medico medico2, double reloj, double proximaLlegada, double acTiempoPerm, int cantPacientesAtendidos, object[][] vector, double acTiempoOcupacion, double acCalmantes)
                                resultados = finConsulta(estados_pacientes, 0, a, b, medico1, medico2, enfermero1, demoraCalmante, minuto, proximaLlegadaCons, acTiempoPermanencia,
                                    acPacientesAtendidos, vectorEstado, acTiempoOcupacion, acCalmantes, proximaLlegadaEnfe, proximaLlegadaCons);

                                acTiempoOcupacion = resultados[1];
                                vectorEstado[0][22] = acTiempoOcupacion;

                                acPacientesAtendidos++;
                                vectorEstado[0][23] = acPacientesAtendidos;

                                //vectorEstado[0][22] = acCalmantes;

                                acTiempoPermanencia = resultados.First();
                                vectorEstado[0][25] = acTiempoPermanencia;


                                if (minuto >= desde && minuto <= hasta)
                                {
                                    dgv_datos.Rows.Add(vectorEstado[0]);
                                }
                            }
                            
                            else if (menorTiempo == finEnfermeria)
                            {
                                minuto = finEnfermeria;

                                //public List<double> finConsulta(List<Paciente> total_pacientes, double finConsulta, double a, double b, Medico medico1, Medico medico2, double reloj, double proximaLlegada, double acTiempoPerm, int cantPacientesAtendidos, object[][] vector, double acTiempoOcupacion, double acCalmantes)
                                resultados = finEnfermeriaMet(estados_pacientes, medico1, medico2, enfermero1, minuto, demoraCuracion, demoraVacunacion, demoraCalmante, acTiempoPermanencia,
                                    acPacientesAtendidos, vectorEstado, acTiempoOcupacion, acCalmantes, proximaLlegadaEnfe, proximaLlegadaCons);

                                acPacientesAtendidos++;
                                vectorEstado[0][23] = acPacientesAtendidos;

                                acCalmantes = resultados.First();
                                vectorEstado[0][24] = acCalmantes;

                                acTiempoPermanencia = resultados[1];
                                vectorEstado[0][25] = acTiempoPermanencia;

                                acTiempoOcupacion = resultados.Last();
                                vectorEstado[0][22] = acTiempoOcupacion;

                                if (minuto >= desde && minuto <= hasta)
                                {
                                    dgv_datos.Rows.Add(vectorEstado[0]);
                                }
                            }

                            else if (menorTiempo == proximaLlegadaCons)
                            {
                                minuto = proximaLlegadaCons;

                                //public List<double> finConsulta(List<Paciente> total_pacientes, double finConsulta, double a, double b, Medico medico1, Medico medico2, double reloj, double proximaLlegada, double acTiempoPerm, int cantPacientesAtendidos, object[][] vector, double acTiempoOcupacion, double acCalmantes)
                                resultados = llegadaPacienteCons(estados_pacientes, mediaCons, vectorEstado, minuto, medico1, medico2, enfermero1, a, b, acTiempoPermanencia,
                                    acTiempoOcupacion, acPacientesAtendidos, acCalmantes, proximaLlegadaEnfe);

                                acTiempoOcupacion = resultados.Last();

                                vectorEstado[0][22] = acTiempoOcupacionEnf;


                                if (minuto >= desde && minuto <= hasta)
                                {
                                    DataGridViewColumn pac_estado = new DataGridViewColumn();
                                    pac_estado.HeaderText = "Estado Paciente" + estados_pacientes.Count().ToString();
                                    pac_estado.CellTemplate = new DataGridViewTextBoxCell();
                                    dgv_datos.Columns.Add(pac_estado);
                                    dgv_datos.Rows.Add(vectorEstado[0]);
                                }
                            }

                            else if (menorTiempo == proximaLlegadaEnfe)
                            {
                                minuto = proximaLlegadaCons;

                                //public List<double> finConsulta(List<Paciente> total_pacientes, double finConsulta, double a, double b, Medico medico1, Medico medico2, double reloj, double proximaLlegada, double acTiempoPerm, int cantPacientesAtendidos, object[][] vector, double acTiempoOcupacion, double acCalmantes)
                                resultados = llegadaPacienteEnf(estados_pacientes, mediaEnf, vectorEstado, minuto, medico1, medico2, enfermero1, demoraCuracion, demoraVacunacion,
                                    acTiempoPermanencia, acTiempoOcupacion, acPacientesAtendidos, acCalmantes, proximaLlegadaCons);

                                acTiempoOcupacion = resultados[0];

                                vectorEstado[0][22] = acTiempoOcupacion;


                                if (minuto >= desde && minuto <= hasta)
                                {
                                    DataGridViewColumn pac_estado = new DataGridViewColumn();
                                    pac_estado.HeaderText = "Estado Paciente" + estados_pacientes.Count().ToString();
                                    pac_estado.CellTemplate = new DataGridViewTextBoxCell();
                                    dgv_datos.Columns.Add(pac_estado);
                                    dgv_datos.Rows.Add(vectorEstado[0]);
                                }
                            }

                        }
                    }

                    promedioTiempoPermanencia = acTiempoPermanencia / acPacientesAtendidos;
                    lblPromedioPermanencia.Text = promedioTiempoPermanencia.ToString();
                    promedioTiempoOcupacion = acTiempoOcupacion / minuto;
                    lblPromedioOcupacion.Text = promedioTiempoOcupacion.ToString();
                    lblCantidadCalmantes.Text = acCalmantes.ToString();
                    lblPacientesAtendidos.Text = acPacientesAtendidos.ToString();
                }

                else
                {
                    MessageBox.Show("Valores fuera de rango");
                    tbxDesde.Focus();
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            tbxDesde.Clear();
            
            tbxDemoraCalmante.Clear();
            
            tbxDemoraCuracion.Clear();
            tbxDemoraVacuna.Clear();
            tbxDesdeCM.Clear();
            tbxHastaCM.Clear();
            tbxMediaCons.Clear();
            tbxMediaEnf.Clear();
            txtIteraciones.Clear();

            lblPA.Text = "";
            lblPP.Text = "";
            lblOE.Text = "";

            dgv_datos.Rows.Clear();

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {


            tbxDesde.Clear();

            tbxDemoraCalmante.Clear();

            tbxDemoraCuracion.Clear();
            tbxDemoraVacuna.Clear();
            tbxDesdeCM.Clear();
            tbxHastaCM.Clear();
            tbxMediaCons.Clear();
            tbxMediaEnf.Clear();
            txtIteraciones.Clear();

            lblPA.Text = "";
            lblPP.Text = "";
            lblOE.Text = "";

            dgv_datos.Rows.Clear();

        }

    }
    }

 
