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
        // el atributo pacientes guarda los pacientes en la cola mas el que esta atendiendo
        public Queue<Paciente> pacientes { get; set; }
        public string estado { get; set; }
        //public double tiempoRemanente { get; set; }
        //public double finPurga { get; set; }

        public int getTamCola()
        {

            int x = this.pacientes.Count;
            if (x == 0)
            {
                return x;
            }
            return x - 1;
        }
        
    }
}
