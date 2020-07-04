using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_SIM.Clases
{
    class Enfermero
    {
        public double finAtEnfermeria { get; set; }
        public int id { get; set; }
        
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
