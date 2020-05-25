using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Comida : Entidad2D
    {
        private bool _esComido;

        public Comida(int x, int y) : base(x, y)
        {
            _esComido = false;
        }

        public bool EsComido { get => _esComido; set => _esComido = value; }
    }
}
