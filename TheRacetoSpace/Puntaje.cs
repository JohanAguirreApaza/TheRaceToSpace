using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRacetoSpace
{
    internal class Puntaje
    {
        private Label lbPuntaje;
        private Timer timer;
        private int puntos;

        public int Puntos => puntos; // para leer desde afuera

        public Puntaje(Label label)
        {
            lbPuntaje = label;
            lbPuntaje.Text = "Puntaje: 0";
            lbPuntaje.AutoSize = true;
            lbPuntaje.Font = new Font("Arial", 14, FontStyle.Bold);

            // Timer para aumentar puntaje
            timer = new Timer();
            timer.Interval = 100; // cada 1 segundo
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            puntos++;
            lbPuntaje.Text = $"Puntaje: {puntos}";
        }

        public void Iniciar()
        {
            puntos = 0;
            lbPuntaje.Text = "Puntaje: 0";
            timer.Start();
        }

        public void Detener()
        {
            timer.Stop();
            MessageBox.Show($"Partida terminada\nTu puntaje fue: {puntos}", "Fin del juego");
        }

    }
}
