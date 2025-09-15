using System;
using System.Windows.Forms;

namespace TheRacetoSpace
{
    public partial class PAUSA : Form
    {
        public PAUSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var playerGround = new Form1();
            playerGround.Show();
            
            this.Close();
        }
    }
}
