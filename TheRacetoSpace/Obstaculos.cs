using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRacetoSpace
{
    internal class Obstaculos
    {
        public PictureBox pbBarril { get; private set; }
        public PictureBox pbAgujero { get; private set; }
        public PictureBox pbPlatillo { get; private set; }
        public PictureBox pbBarril2 { get; private set; }
        public PictureBox pbBarril3 { get; private set; }
        public PictureBox pbBarril4 { get; private set; }
        public PictureBox pbAgujero2 { get; private set; }

        private int velocidadPlatillo = 5;
        private int direccionPlatillo = 1; // 1 = derecha, -1 = izquierda
        private Control formulario;

        public bool platilloActivo = false; //Para que al inicio no se mueva

        public Obstaculos(Control bounds, PictureBox barril, PictureBox barril2, PictureBox barril3, PictureBox barril4, PictureBox agujero, PictureBox agujero2, PictureBox platillo)
        {
            formulario = bounds;

            // BARRILES
            pbBarril = barril;
            pbBarril2 = barril2;
            pbBarril3 = barril3;
            pbBarril4 = barril4;


            // AGUJEROS
            pbAgujero = agujero;
            pbAgujero2 = agujero2;


            // PLATILLO
            pbPlatillo = platillo;
            pbPlatillo.Size = new Size(80, 40);
            
            pbPlatillo.Left = bounds.ClientSize.Width - pbPlatillo.Width - 20;
            pbPlatillo.Top = 290;
        }
        public void ActivarPlatillo()
        {
            platilloActivo = true;
        }
        public void MoverPlatillo()
        {
            if (platilloActivo == false) return; // solo se mueve cuando está activo

            pbPlatillo.Left += velocidadPlatillo * direccionPlatillo;

            if (pbPlatillo.Right >= formulario.ClientSize.Width || pbPlatillo.Left <= 0)
            {
                direccionPlatillo *= -1; // rebota en los bordes
            }
        }
    }
}

    