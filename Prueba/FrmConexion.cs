using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

       

        private void BtnMostra_Click(object sender, EventArgs e)
        {
            ConexionBd con = new ConexionBd();
            con.conectar();
        }
    }
}
