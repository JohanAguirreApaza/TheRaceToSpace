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
            foreach (var b in new[] { pbBarril, pbBarril2, pbBarril3, pbBarril4 })
            {
                b.Size = new Size(50, 50);
                b.SizeMode = PictureBoxSizeMode.StretchImage;
                b.BackColor = Color.Transparent;
            }

            // AGUJEROS
            pbAgujero = agujero;
            pbAgujero2 = agujero2;
            foreach (var a in new[] { pbAgujero, pbAgujero2 })
            {
                a.Size = new Size(100, 30);
                a.SizeMode = PictureBoxSizeMode.StretchImage;
                a.BackColor = Color.Transparent;
            }

            // PLATILLO
            pbPlatillo = platillo;
            pbPlatillo.Size = new Size(80, 40);
            pbPlatillo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlatillo.BackColor = Color.Transparent;
            pbPlatillo.Left = bounds.ClientSize.Width - pbPlatillo.Width - 20;
            pbPlatillo.Top = 290;


        }
        //public bool ColisionaConTodos(PictureBox alien)
        //{
        //    return pbBarril.Bounds.IntersectsWith(alien.Bounds) ||
        //           pbBarril2.Bounds.IntersectsWith(alien.Bounds) ||
        //           pbBarril3.Bounds.IntersectsWith(alien.Bounds) ||
        //           pbBarril4.Bounds.IntersectsWith(alien.Bounds) ||
        //           pbAgujero.Bounds.IntersectsWith(alien.Bounds) ||
        //           pbAgujero2.Bounds.IntersectsWith(alien.Bounds) ||
        //           pbPlatillo.Bounds.IntersectsWith(alien.Bounds);
        //}
        

        public void ActivarPlatillo()
        {
            platilloActivo = true;
        }

        public void MoverPlatillo()
        {
            if (!platilloActivo) return; // 🔹 solo se mueve cuando está activo

            pbPlatillo.Left += velocidadPlatillo * direccionPlatillo;

            if (pbPlatillo.Right >= formulario.ClientSize.Width || pbPlatillo.Left <= 0)
            {
                direccionPlatillo *= -1; // rebota en los bordes
            }
        }

        public bool ColisionaConBarril(PictureBox alien)
        {
            return pbBarril.Bounds.IntersectsWith(alien.Bounds);
        }
        public bool ColisionaConAgujero(PictureBox alien)
        {
            return pbAgujero.Bounds.IntersectsWith(alien.Bounds);

        }
        public bool ColisionaConPlatillo(PictureBox alien)
        {
            return pbPlatillo.Bounds.IntersectsWith(alien.Bounds);
        }


    }
}

    