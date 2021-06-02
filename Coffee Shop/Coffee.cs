using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    class Coffee
    {

        private int nr = 0;
        private double s = 0;
        private bool sugar = false;
        private bool milk = false;
        private double price = 0;
        private string name = null;
        

        public Coffee()
        {
            name = "FLAT WHITTE COFFEE ";
        }

        public virtual void sum()
        {
            s += getPrice();
        }

        public virtual void makeCoffee()
        {
            price = 1.75;
            nr++;
        }

        public virtual void addExtra()
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

        public virtual void setSugar(bool sugar)
        {
            this.sugar = sugar;
        }
        public virtual void setMilk(bool milk)
        {
            this.milk = milk;
        }

        public virtual void setPrice(double price)
        {
            this.price=price;
        }
        public virtual double getPrice()
        {
            return price;
        }

        public virtual string getName()
        {
            return name;
        }

        public virtual void setNr(int nr)
        {
            this.nr=nr;
        }

        public virtual int getNr()
        {
            return nr;
        }

        public virtual double getSum()
        {
            return s;
        }

        public virtual void setSum(double s)
        {
            this.s = s;
        }

    }
}
