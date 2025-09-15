using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private int velocidadFondo = 5;

        // Variable para controlar que solo pierda una vida por choque
        bool colision = false;
        //private bool pausaDeDaño = false;

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
            puntaje.Iniciar(); 

            

            //Eventos teclado
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            this.KeyPreview = true;

            //timer = new Timer();
            //timer.Interval = 20;
            //timer.Tick += Timer_Tick;
            timer1.Start(); //Timer del disenador 




        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!juegoActivo) return; // si ya perdiste, no se actualiza nada
            obstaculo.MoverPlatillo();

            // 1) Guardar posición previa
            int prevX = alien.PosX;
            int prevY = alien.PosY;
            alien.Actualizar();

            bool sobrePiso = false;

            // Chequear si el alien cae sobre algún piso
            foreach (var piso in pisos)
            {
                if (alien.PosX + alien.GetAncho() > piso.PbPiso.Left &&
                    alien.PosX < piso.PbPiso.Right)
                {
                    if (alien.PosY + alien.GetAltura() >= piso.PosY &&
                        alien.PosY + alien.GetAltura() <= piso.PosY + piso.Altura + 10) // margen
                    {
                        alien.ApoyarEnPiso(piso.PosY);
                        sobrePiso = true;
                        break;
                    }
                }
            }

            //Si no está sobre ningún piso y no está saltando, cae
            if (!sobrePiso && !alien.saltando)
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
            if (pbAlien.Bounds.IntersectsWith(pbBarril.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbBarril2.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbBarril3.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbBarril4.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbAgujero.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbAgujero2.Bounds) ||
                pbAlien.Bounds.IntersectsWith(pbPlatillo.Bounds))
            {
                if (!colision) // Solo al primer tick de colisión
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
                    if (alien.Vidas <= 0)
                    {
                        juegoActivo = false;
                        timer1.Stop();
                        puntaje.Detener();
                        // Mostrar el formulario RESULTADO
                        RESULTADO resultadoForm = new RESULTADO();
                        resultadoForm.Show();
                    }
                    
                    // Retroceder a la posición previa
                    alien.Reaparecer(prevX, prevY);
                    
                }
            }
            else
            {
                // No hay colisión: restauramos colores y bandera
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

 




        


        //////////Colision del barril 
        ////////if (obstaculo != null && obstaculo.ColisionaConBarril(pbAlien))
        ////////{
        ////////    // Volver a la posición previa para que no “se meta” en el barril
        ////////    alien.Reaparecer(prevX, prevY);

        ////////    // Congelar juego
        ////////    juegoActivo = false;
        ////////    // soltar inputs por si quedaron presionados
        ////////    alien.SoltarDerecha();
        ////////    alien.SoltarAgacharse();

        ////////    timer.Stop(); //  detiene actualizaciones
        ////////    puntaje.Detener();
        ////////    MessageBox.Show("Haz muerto!!!");
        ////////    this.Close();
        ////////}
        ////////if (obstaculo.ColisionaConAgujero(pbAlien))
        ////////{
        ////////    pbAlien.Visible = false;

        ////////    juegoActivo = false;
        ////////    timer.Stop();
        ////////    puntaje.Detener();
        ////////    MessageBox.Show("Haz muerto!!!");
        ////////    this.Close();
        ////////}
        ////////if (obstaculo.ColisionaConPlatillo(pbAlien))
        ////////{
        ////////    pbAlien.Visible = false;

        ////////    juegoActivo = false;
        ////////    timer.Stop();
        ////////    puntaje.Detener();
        ////////    MessageBox.Show("Haz muerto!!!");
        ////////    this.Close();


        ////////}




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                alien.PresionarDerecha();
                obstaculo.ActivarPlatillo(); // aquí empieza a volar el platillo
            }
            if (e.KeyCode == Keys.Up) alien.PresionarSalto();
            if (e.KeyCode == Keys.Down) alien.PresionarAgacharse();

            //INICIO DE PUNTAJE 









        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) alien.SoltarDerecha();
            if (e.KeyCode == Keys.Down) alien.SoltarAgacharse();
        }

        private void timerInterno_Tick(object sender, EventArgs e)
        {
            // Actualizar al alien (mover, saltar, agacharse)
            alien.Actualizar();

            
        }
        private void ActualizarVidasUI()
        {
            pbVida1.Visible = alien.Vidas >= 1;
            pbVida2.Visible = alien.Vidas >= 2;
            pbVida3.Visible = alien.Vidas >= 3;
            pbVida4.Visible = alien.Vidas >= 4;
            pbVida5.Visible = alien.Vidas >= 5;
        }

        private void lbPuntaje_Click(object sender, EventArgs e)
        {

        }
    }

        
    
}
