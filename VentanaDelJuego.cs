using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class VentanaDelJuego : Form
    {
        private Mapa _mapa;
        private Snake _snake;
        private Comida _comida;
        public VentanaDelJuego()
        {
            InitializeComponent();

            // Aqui hacemos el juego
            _mapa = new Mapa(this.Width, this.Height);
            Console.WriteLine("Width: "+_mapa.Width+", Height: "+_mapa.Height);

            Point p = new Point(0, 0);

            _snake = new Snake(_mapa.Width / 2, _mapa.Height / 2);
            _comida = new Comida(200,200);
        
        }

        private void VentanaDelJuego_Paint(object sender, PaintEventArgs e)
        {
            // Ciclo de FPS...
            // Crear lapices para dibujar
            Pen lapizNegro = new Pen(Color.Black, 10);
            Pen lapizRojo = new Pen(Color.Red, 10);

            // Dibujar la serpiente
            // (x, y, w, h)
            // x = coordenada x
            // y = coordenada y
            // w = ancho o width
            // h = altura o height
            Rectangle rectSnake = new Rectangle(_snake.Coordenadas.X, _snake.Coordenadas.Y, 
                                           _snake.SizeGrafico, _snake.SizeGrafico);

            // Dibujar la comida
            // (x, y, w, h)
            // x = coordenada x
            // y = coordenada y
            // w = ancho o width
            // h = altura o height
            Rectangle rectComida = new Rectangle(_comida.Coordenadas.X, _comida.Coordenadas.Y,
                                           _comida.SizeGrafico, _comida.SizeGrafico);

            // Dibujar en pantalla los graficos
            e.Graphics.DrawRectangle(lapizNegro, rectSnake);
            e.Graphics.DrawRectangle(lapizRojo, rectComida);
        }

        private void VentanaDelJuego_KeyDown(object sender, KeyEventArgs e)
        {
            // Letra Mayuscula
            //Console.WriteLine(e.KeyValue);


            /*
             * Enum con letras: A = 65, B = 66, C = 67....
             * Solo contiene mayusculas D:
             */
            int c = (int) e.KeyCode.ToString().ToLower()[0];

            // Letra minuscula despues del proceso ToLower
            //Console.WriteLine(c);

            try
            {
                switch (c)
                {
                    // mover al gusano a la izquierda
                    case 97:  // a
                              // Restar la velocidad a la X actual, es decir, X - velocidad.
                        int nuevaX = _snake.Coordenadas.X - _snake.Velocidad;
                        int nuevaY = _snake.Coordenadas.Y; // la misma Y

                        Console.WriteLine("Coordenada actual: X:" + _snake.Coordenadas.X + ", Y:" + _snake.Coordenadas.Y);

                        _snake.Coordenadas = new Point(nuevaX, nuevaY); // Modificacion de la coordenada

                        Console.WriteLine("Coordenada modificada: X:" + _snake.Coordenadas.X + ", Y:" + _snake.Coordenadas.Y);

                        break;
                    // Mover al gusano a la derecha
                    case 100: // d
                        MessageBox.Show("La serpiente va hacia la derecha");
                        break;
                    // Mover al gusano hacia abajo
                    case 115: // s
                        MessageBox.Show("La serpiente va hacia abajo");
                        break;
                    // Mover al gusano hacia arriba
                    case 119: // w
                        MessageBox.Show("La serpiente va hacia arriba");
                        break;
                }
            }
            finally
            {
                Invalidate();
            }
        }
    }
}
