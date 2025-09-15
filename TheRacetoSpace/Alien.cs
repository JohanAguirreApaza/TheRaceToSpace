using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRacetoSpace
{
    internal class Alien
    {
        //VIDASSS
        public int Vidas { get; set; } = 5; // inicia con 5 vidas

        public bool EstaSaltando() => saltando;
        public int GetAltura() => pictureBox.Height;
        public int GetAncho() => pictureBox.Width;
        public string Nombre { get; set; }
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        
        public int Velocidad { get; set; } = 10;
        private PictureBox pictureBox;

        private bool derecha = false;
        public bool saltando = false;
        private bool agachado = false;

        private int suelo;
        private int alturaSalto = 150;
        private int saltoActual = 0;
        public int velocidadSalto = 6;
        private bool firstTimeMoving = true;
        public delegate void OnFirstMovementHandler(object sender, PuntajeArgs e);
        public event OnFirstMovementHandler OnFirstMovement;

        public void PerderVida()
        {
            if (Vidas > 0)
                Vidas--;
        }
        public Alien(string nombre, int posX, int posY, PictureBox pb)
        {
            Nombre = nombre;
            PosX = posX;
            PosY = posY;
            pictureBox = pb;

            pictureBox.Left = PosX;
            pictureBox.Top = PosY;
            suelo = posY;
        }

        // Estas funciones solo cambian el estado
        public void PresionarDerecha() => derecha = true;
        public void SoltarDerecha() => derecha = false;

        public void PresionarSalto()
        {
            if (saltando == false)
            {
                saltando = true;
                saltoActual = 0;
            }
        }

        public void PresionarAgacharse() => agachado = true;
        public void SoltarAgacharse() => agachado = false;

        // Llamar en cada tick del Timer
        public void Actualizar()
        {
            // Avanzar
            if (derecha)
            {
                PosX += Velocidad;
                Console.WriteLine("PosX: " + PosX);

                if (firstTimeMoving)
                {
                    this.firstTimeMoving = false;
                    OnFirstMovement?.Invoke(this, new PuntajeArgs()
                    {
                        puntajeInicial = 100
                    });
                }
            }

            // Saltar (mas rapido)
            if (saltando)
            {
                if (saltoActual < alturaSalto)
                {
                    // Aumenta la velocidad de salto
                    int saltoRapido = velocidadSalto * 2;
                    PosY -= saltoRapido; // sube más rápido
                    saltoActual += saltoRapido;
                }
                else if (PosY < suelo)
                {
                    int caidaRapida = velocidadSalto * 2;
                    PosY += caidaRapida; // baja más rápido
                    if (PosY > suelo) PosY = suelo;
                }
                else
                {
                    saltando = false;
                }
            }


            // Agacharse
            if (agachado)
            {
                pictureBox.Top = PosY + (150 - 75 );
                pictureBox.Height = 75;
            }
            else
            {
                pictureBox.Top = PosY;
                pictureBox.Height = 150; // altura normal
            }

            // Actualizar posición visual
            
            pictureBox.Left = PosX;
            pictureBox.Top = PosY;


        }


        public void Reaparecer(int posXInicial, int posYInicial)
        {
            PosX = posXInicial;
            PosY = posYInicial;
            pictureBox.Left = PosX;
            pictureBox.Top = PosY;

            // Resetear estados
            saltando = false;
            agachado = false;
            saltoActual = 0;
            pictureBox.Height = 150; // altura normal
        }

        public void ApoyarEnPiso(int posYPiso)
        {
            PosY = posYPiso - pictureBox.Height;
            saltando = false;
            saltoActual = 0;

        }
        public void Caer(int velocidad)
        {
            PosY += velocidad;
            pictureBox.Top = PosY;
        }

    }
}