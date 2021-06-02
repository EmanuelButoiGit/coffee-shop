using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    class Total
    {
        private double s = 0;
        
        public void addSum(double s)
        {
            this.s += s;
        }

        public double getSum()
        {
            return s;
        } 

        public double getTax()
        {
            return Math.Round(s * (9.0 / 100.0),2);
        }

        public double sumTax()
        {
            return getTax()+s;
        }

    }
}
