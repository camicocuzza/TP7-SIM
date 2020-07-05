using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_SIM.Clases
{
    public class Medico
    {
        public double finConsulta { get; set; }
        public int id { get; set; }
        // el atributo pacientes guarda los pacientes en la cola
        public static Queue<Paciente> colaPacientes { get; set; }
        //guarda el paciente siendo atendido
        public Paciente pacienteAtendido = new Paciente();
        public string estado { get; set; }
        //public double tiempoRemanente { get; set; }
        //public double finPurga { get; set; }

        public int getTamCola()
        {

            int x = colaPacientes.Count();

            
            return x;
        }
        
    }
}
