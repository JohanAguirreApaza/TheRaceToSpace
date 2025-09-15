using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRacetoSpace
{
    internal class Piso
    {
        public PictureBox PbPiso { get; private set; }
        public int PosY => PbPiso.Top;
        public int Altura => PbPiso.Height;

        public Piso(PictureBox pb)
        {
            PbPiso = pb;
            PbPiso.BackColor = Color.Transparent;
        }

        // Verifica si el alien está cayendo sobre el piso
        public bool ColisionConAlien(Alien alien)
        {
            Rectangle alienRect = new Rectangle(alien.PosX, alien.PosY + alien.GetAltura(), alien.GetAncho(), alien.GetAltura());
            Rectangle pisoRect = PbPiso.Bounds;
            return alienRect.IntersectsWith(pisoRect);
        }
    }
}
