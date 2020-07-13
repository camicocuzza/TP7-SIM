using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_SIM.Clases
{
    public class Enfermero
    {
        public double finAtencion { get; set; }
        public double finAtencionCalmante { get; set; }
        public double tiempoRemanente { get; set; }
        public int id { get; set; }
        
        //el que esta atendiendo más los en cola
        public static Queue<Paciente> colaEnfermeria { get; set; }
        public Queue<Paciente> colaEnfCalmantes { get; set; }
        public string estado { get; set; }
        //public double tiempoRemanente { get; set; }
        //public double finPurga { get; set; }

        public int getTamColaPrioridad()
        {

            int x = colaEnfermeria.Count();
            if (x == 0)
            {
                return x;
            }
            return x - 1;
        }
        public int getTamColaCalmantes(Enfermero enf)
        {

            int x = colaEnfCalmantes.Count();
            if (x == 0)
            {
                return x;
            }
            if (enf.estado == "ACalmante")
            {
                return x - 1;
            }
            else
            {
                return x;
            }
        }
    }
}
