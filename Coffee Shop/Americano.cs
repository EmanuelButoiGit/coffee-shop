using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    class Americano:Coffee
    {

        private int nr = 0;
        private double s = 0;
        private bool sugar = false;
        private bool milk = false;
        private double price = 0;
        private string name = null;

        public Americano()
        {
            name = "AMERICANO COFFEE ";
        }

        public override void sum()
        {
            s += getPrice();
        }

        public override void makeCoffee()
        {
            price = 2.15;
        }

        public override void addExtra()
        {
            if (sugar == true)
            {
                price += 0.26;
            }

            if (milk == true)
            {
                price += 0.32;
            }

            sum();

        }

        public override void setSugar(bool sugar)
        {
            this.sugar = sugar;
        }
        public override void setMilk(bool milk)
        {
            this.milk = milk;
        }

        public override void setPrice(double price)
        {
            this.price = price;
        }
        public override double getPrice()
        {
            return price;
        }

        public override string getName()
        {
            return name;
        }

        public override void setNr(int nr)
        {
            this.nr = nr;
        }

        public override int getNr()
        {
            return nr;
        }

        public override double getSum()
        {
            return s;
        }

        public override void setSum(double s)
        {
            this.s = s;
        }

    }
}
