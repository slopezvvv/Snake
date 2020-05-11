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
        public VentanaDelJuego()
        {
            InitializeComponent();

            // Aqui hacemos el juego
            Snake snake = new Snake();
        }


    }
}
