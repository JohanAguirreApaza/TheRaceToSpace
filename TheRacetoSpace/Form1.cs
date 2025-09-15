using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheRacetoSpace
{
    public partial class Form1 : Form
    {
        private Alien alien; 
        //private Timer timer;
        private Obstaculos obstaculo;
        private bool juegoActivo = true;
        private Puntaje puntaje;
        public int Vidas; 

        private int velocidadFondo = 5;
        bool colision = false;
        
        private List<Piso> pisos = new List<Piso>();


        public Form1()
        {
            InitializeComponent();


            pisos.Add(new Piso(pbPiso1));
            pisos.Add(new Piso(pbPiso2));
            pisos.Add(new Piso(pbPiso3));
            pisos.Add(new Piso(pbPiso4));
            pisos.Add(new Piso(pbPiso5));

            //Inicio de Alien y obstaculos
            alien = new Alien("Nombre alien", 10, 280, pbAlien);
            obstaculo = new Obstaculos(this, pbBarril, pbBarril2, pbBarril3, pbBarril4, pbAgujero,pbAgujero2 ,pbPlatillo);
            
            //Inicializar Puntaje
            puntaje = new Puntaje(lbPuntaje);
            alien.OnFirstMovement += puntaje.Iniciar;

            //Eventos teclado
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += Form1_KeyUp;
            this.KeyPreview = true;

            //timer = new Timer();
            //timer.Interval = 20;
            //timer.Tick += Timer_Tick;
            timer1.Start(); //Timer del disenador 

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (juegoActivo == false) return; // si ya perdiste, no se actualiza nada
            obstaculo.MoverPlatillo();

            // 1) Guardar posición previa
            int prevX = alien.PosX;
            int prevY = alien.PosY;
            alien.Actualizar();

            bool sobrePiso = false;

            // CONTROL DE PISOS Y ALIEN
            foreach (var piso in pisos)
            {
                // Alien horizontal? 
                if (alien.PosX + alien.GetAncho() > piso.PbPiso.Left && alien.PosX < piso.PbPiso.Right)
                {
                    // Revisar si el alien está verticalmente sobre el piso (con un pequeño margen)
                    if ((alien.PosY + alien.GetAltura() > piso.PosY - 1) &&
                        (alien.PosY + alien.GetAltura() < piso.PosY + piso.Altura + 11))
                    {
                        // Apoyar al alien en la parte superior del piso
                        alien.ApoyarEnPiso(piso.PosY);
                        sobrePiso = true;
                        break;
                    }
                }
            }

            //Si no está sobre ningún piso y no está saltando, cae
            if (sobrePiso == false && alien.saltando == false)
            {
                alien.Caer(alien.velocidadSalto);// simula gravedad
            }


            //Limites en pantalla
            if (alien.PosX > this.ClientSize.Width)
                alien.Reaparecer(-50, alien.PosY);

            if (alien.PosX < -50)
                alien.Reaparecer(this.ClientSize.Width, alien.PosY);

            if (alien.PosY > this.ClientSize.Height)
                alien.Reaparecer(alien.PosX, -80);

            if (alien.PosY < -80)
                alien.Reaparecer(alien.PosX, this.ClientSize.Height);

            //Mover Fondo
            pbFondo1.Left -= velocidadFondo;
            if (pbFondo1.Right <= this.ClientSize.Width)
                pbFondo1.Left = 0;

            // --- COLISIONES SIMPLES ---
            Point centroAlien = new Point(pbAlien.Left + pbAlien.Width / 2, pbAlien.Top + pbAlien.Height / 2);
            Rectangle zonaAgujero = pbAgujero.Bounds;
            Rectangle zonaAgujero2 = pbAgujero2.Bounds;

            if (pbAlien.Bounds.IntersectsWith(pbBarril.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbBarril2.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbBarril3.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbBarril4.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbPlatillo.Bounds))
            {
                if (colision == false) // Solo al primer tick de colisión
                {
                    // Cambiar colores al chocar
                    pbAlien.BackColor = Color.DarkBlue;
                    pbBarril.BackColor = Color.DarkBlue;
                    pbBarril2.BackColor = Color.DarkBlue;
                    pbBarril3.BackColor = Color.DarkBlue;
                    pbBarril4.BackColor = Color.DarkBlue;
                    pbAgujero.BackColor = Color.DarkBlue;
                    pbAgujero2.BackColor = Color.DarkBlue;
                    pbPlatillo.BackColor = Color.DarkBlue;

                    // Restar vida y actualizar UI
                    alien.PerderVida();
                    ActualizarVidasUI();

                    colision = true; // Marcar que ya se registró

                    // Si ya no quedan vidas
                    // if (alien.Vidas <= 0)
                    // {
                    //     juegoActivo = false;
                    //     timer1.Stop();
                    //     puntaje.Detener();
                    //     
                    //     // Mostrar el formulario RESULTADO
                    //     RESULTADO resultadoForm = new RESULTADO();
                    //     resultadoForm.Show();
                    //     
                    // }

                    // Retroceder a la posición previa
                    alien.Reaparecer(prevX, prevY);

                }

            }
            else if (zonaAgujero.Contains(centroAlien) || zonaAgujero2.Contains(centroAlien))
            {
                alien.Vidas = 0;
                ActualizarVidasUI();
                timer1.Stop();
                juegoActivo = false;
                pbAlien.Visible = false;
                puntaje.Detener();
                
                this.Close();
                
                RESULTADO resultadoForm = new RESULTADO();
                resultadoForm.Show();
            }
            else
            {
                pbAlien.BackColor = Color.Transparent;
                pbBarril.BackColor = Color.Transparent;
                pbBarril2.BackColor = Color.Transparent;
                pbBarril3.BackColor = Color.Transparent;
                pbBarril4.BackColor = Color.Transparent;
                pbAgujero.BackColor = Color.Transparent;
                pbAgujero2.BackColor = Color.Transparent;
                pbPlatillo.BackColor = Color.Transparent;

                colision = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                alien.PresionarDerecha();
                obstaculo.ActivarPlatillo();
            }
            if (e.KeyCode == Keys.W) alien.PresionarSalto();
            if (e.KeyCode == Keys.S) alien.PresionarAgacharse();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) alien.SoltarDerecha();
            if (e.KeyCode == Keys.S) alien.SoltarAgacharse();
        }

        private void timerInterno_Tick(object sender, EventArgs e)
        {
            alien.Actualizar();
        }
        private void ActualizarVidasUI()
        {
            pbVida1.Visible = alien.Vidas >= 5;
            pbVida2.Visible = alien.Vidas >= 4;
            pbVida3.Visible = alien.Vidas >= 3;
            pbVida4.Visible = alien.Vidas >= 2;
            pbVida5.Visible = alien.Vidas >= 1;
        }

        private void lbPuntaje_Click(object sender, EventArgs e)
        {

        }

        private void btPAUSA_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Si entra!");
            var pauseForm = new PAUSA();
            pauseForm.Show();
            
            this.Hide();
        }

        private void pbAlien_Click(object sender, EventArgs e)
        {

        }
    }

        
    
}
