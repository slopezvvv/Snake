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
            Rectangle rectSnake = new Rectangle(_snake.Coordenadas.X, _snake.Coordenadas.Y, 
                                           _snake.SizeGrafico, _snake.SizeGrafico);

            // Dibujar la comida
            Rectangle rectComida = new Rectangle(_comida.Coordenadas.X, _comida.Coordenadas.Y,
                                           _comida.SizeGrafico, _comida.SizeGrafico);

            // Dibujar en pantalla los graficos
            e.Graphics.DrawRectangle(lapizNegro, rectSnake);
            e.Graphics.DrawRectangle(lapizRojo, rectComida);
        }

        private void VentanaDelJuego_KeyDown(object sender, KeyEventArgs e)
        {
            int c = (int)e.KeyCode.ToString().ToLower()[0];
            //MessageBox.Show("Se presiono la tecla: " + (char)97);

            switch(c)
            {
                case 97:  // a
                    MessageBox.Show("La serpiente va hacia la izquierda");
                    break;
                case 100: // d
                    MessageBox.Show("La serpiente va hacia la derecha");
                    break;
                case 115: // s
                    MessageBox.Show("La serpiente va hacia abajo");
                    break;
                case 119: // w
                    MessageBox.Show("La serpiente va hacia arriba");
                    break;
            }
        }
    }
}
