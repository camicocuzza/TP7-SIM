using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7_SIM.Formularios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            tbxDemoraCuracion.Text = 0.ToString();
            tbxDemoraVacuna.Text = 0.ToString();
            tbxDesdeCM.Text = 0.ToString();
            tbxHastaCM.Text = 0.ToString();

        }
    }
}
