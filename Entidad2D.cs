using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    abstract class Entidad2D
    {
        private int[] _coordenadas;
        private Random _random;

        public Entidad2D()
        {
            _coordenadas = new int[] { 0, 0};
            _random = new Random();

            
        }
    }
}
