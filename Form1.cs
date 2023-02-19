using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(conectarBase.conectarBaseDatos());
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
