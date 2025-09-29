using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erx6
{
    internal class Milhas
    {
        private int m;
        private double km;

        public void SetMilhas(int m)
        {
            this.m = m;
        }
        public int GetMilhas()
        {
            return this.m;
        }
        public double GetQuilometro()
        {
            return this.km;
        }

        public void Calcular()
        {
            this.km = (this.m * 1852) / 1000.00;
        }
    }
}
