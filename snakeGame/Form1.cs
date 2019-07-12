using System;
using System.Drawing;
using System.Windows.Forms;

namespace snakeGame
{
    public partial class Form1 : Form
    {
        Cola cabeza;
        Comida comida;
        Graphics g;
        int puntaje = 0;
        int cuadro = 10;
        int xdir = 0;
        int ydir = 0;
        Boolean ejex = true;
        Boolean ejey = true;
        public Form1()
        {
            InitializeComponent();
            cabeza = new Cola(10, 10);
            comida = new Comida();
            g = canva.CreateGraphics();
        }
        public void movimiento()
        {
            cabeza.setxy(cabeza.verX() + xdir, cabeza.verY() + ydir);
        }
        private void Bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            cabeza.dibujar(g);
            comida.dibujar(g);
            movimiento();
            choqueCuerpo();
            choquePared();
            if (cabeza.interseccion(comida))
            {
                comida.colocar();
                cabeza.meter();
                puntaje++;
                puntos.Text = puntaje.ToString();
            }
        }
        public void finDeJuego()
        {
            puntaje = 0;
            puntos.Text = "0";
            ejex = true;
            ejey = true;
            xdir = 0;
            ydir = 0;
            cabeza = new Cola(10, 10);
            comida = new Comida();
            MessageBox.Show("Perdiste");
        }
        public void choquePared()
        {
            if (cabeza.verX() < 0 || cabeza.verX() > 770 || cabeza.verY() < 0 || cabeza.verY() > 380)
            {
                finDeJuego();
            }
        }
        public void choqueCuerpo()
        {
            Cola temp;
            try
            {
                temp = cabeza.verSiguiente().verSiguiente();  
            }catch(Exception err)
            {
                temp = null;
            }
            while(temp != null)
            {
                if (cabeza.interseccion(temp))
                {
                    finDeJuego();
                }
                else
                {
                    temp = temp.verSiguiente();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(ejex)
            {
                if(e.KeyCode == Keys.Up)
                {
                    ydir = -cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    ydir = cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                }

            }
            if (ejey)
            {
                if(e.KeyCode == Keys.Right)
                {
                    ydir = 0;
                    xdir = cuadro;
                    ejex = true;
                    ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    ydir = 0;
                    xdir = -cuadro;
                    ejex = true;
                    ejey = false;
                }
            }
        }
    }
}
