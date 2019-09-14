using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Poligono
    {
        private int NumeroLados;
        private double LongitudLados;

        public Poligono()
        {
            NumeroLados = 0;
            LongitudLados = 0.0;
        }

        public Poligono(int NumeroLados, double LongitudLados)
        {
            this.NumeroLados = NumeroLados;
            this.LongitudLados = LongitudLados;
        }

        public int numeroLados
        {
            get
            {
                return NumeroLados;
            }

            set
            {
                if (NumeroLados < 0)
                {
                    NumeroLados = 0;
                }
                else
                {
                    NumeroLados = value;
                }

            }
        }

        public double longitudLados
        {
            get
            {
                return LongitudLados;
            }

            set
            {
                if (LongitudLados < 0)
                    LongitudLados = 0;
                else
                    LongitudLados = value;
            }
        }

        public double CalcularPerimetro()
        {
            return longitudLados * numeroLados;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El Perimetro es:" + CalcularPerimetro());
            return sb.ToString();
        }
    }
}
