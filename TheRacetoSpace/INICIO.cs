using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRacetoSpace
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el juego (Form1)
            Form1 juego = new Form1();
            juego.Show();

            // Ocultar el formulario INICIO
            this.Hide();
        }
    }
}
