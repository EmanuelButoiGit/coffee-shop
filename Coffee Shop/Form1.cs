using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        private Coffee flat;
        private Coffee cap;
        private Coffee mo;
        private Coffee ame;
        private Coffee pan;
        private Coffee car;

        private Total total;

        bool allert;

        public Form1()
        {
            InitializeComponent();
            tbSum.Text += "S.C. COFFEE SHOP S.R.L." + "\r\n\r\n";
            tbSum.Text += "698  Beeghley Street, Waco, TX, 76706" + "\r\n\r\n";
            tbSum.Text += DateTime.Now.ToString() + "\r\n\r\n";
            tbSum.Text += "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + "\r\n\r\n";

            flat = new Coffee();
            cap = new Capuccino();
            total = new Total();
            mo = new Mocha();
            ame = new Americano();
            pan = new Panna();
            car = new Caramel();
            allert = false;
        }

        private void print(System.Windows.Forms.CheckBox cbSugar, System.Windows.Forms.CheckBox cbMilk, Coffee c, string with)
        {
            if (cbSugar.Checked)
            {
                c.setSugar(true);
                with += " WITH SUGAR";
            }

            if (cbMilk.Checked)
            {
                c.setMilk(true);
                with += " WITH MILK";
            }

            c.addExtra();

            tbSum.Text += "\r\n";
            tbSum.Text += c.getName() + with + " x 1 ..... " + c.getPrice().ToString() + "\r\n";
        }

        private void btnAddFlat_Click(object sender, EventArgs e)
        {
            flat.makeCoffee();
            string with = null;

            print(cbFlatSugar,cbFlatMilk,flat,with);

        }

        private void btnAddCap_Click(object sender, EventArgs e)
        {
            cap.makeCoffee();
            string with = null;

            print(cbCapSugar, cbCapMilk, cap, with);
        }

        private void btnAddMo_Click(object sender, EventArgs e)
        {
            mo.makeCoffee();
            string with = null;

            print(cbMoSugar, cbMoMilk, mo, with);
        }

        private void btnAddAme_Click(object sender, EventArgs e)
        {
            ame.makeCoffee();
            string with = null;

            print(cbAmeSugar, cbAmeMilk, ame, with);
        }

        private void btnAddPan_Click(object sender, EventArgs e)
        {
            pan.makeCoffee();
            string with = null;

            print(cbPanSugar, cbPanMilk, pan, with);
        }

        private void btnAddMac_Click(object sender, EventArgs e)
        {   
            car.makeCoffee();
            string with = null;

            print(cbMacSugar, cbMacMilk, car, with);
        }

        private void printDel(Coffee c)
        {
            if (c.getNr() >= 0)
            {
                c.setNr(-1);
                c.setSum(c.getSum() - c.getPrice());
                tbSum.Text += "\r\n" + c.getName() + " x 1 ..... -" + c.getPrice().ToString() + "\r\n";
            }
        }

        private void btnDelFlat_Click(object sender, EventArgs e)
        {
            printDel(flat);
        }

        private void btnDelCap_Click(object sender, EventArgs e)
        {
            printDel(cap);
        }

        private void btnDelMo_Click(object sender, EventArgs e)
        {
            printDel(mo);
        }

        private void btnDelAme_Click(object sender, EventArgs e)
        {
            printDel(ame);
        }

        private void btnDelPan_Click(object sender, EventArgs e)
        {
            printDel(pan);
        }

        private void btnDelMac_Click(object sender, EventArgs e)
        {
            printDel(car);
        }

        private void btnBuyAll_Click(object sender, EventArgs e)
        {
            if (allert == false)
            {
                total.addSum(flat.getSum());
                total.addSum(cap.getSum());
                total.addSum(mo.getSum());
                total.addSum(ame.getSum());
                total.addSum(pan.getSum());
                total.addSum(car.getSum());

                tbSum.Text += "\r\n\r\n" + "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + "\r\n\r\n";
                tbSum.Text += "TOTAL: " + total.getSum().ToString() + "\r\n\r\n";
                tbSum.Text += "TAX: " + total.getTax() + "\r\n\r\n";
                tbSum.Text += "TOTAL COST: " + total.sumTax() + "\r\n\r\n";
                tbSum.Text += DateTime.Now.ToString() + "\r\n\r\n";
                tbSum.Text += "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " + "\r\n\r\n";
                tbSum.Text += "Many thanks for thinking of us and choosing us!" + "\r\n\r\n";
                tbSum.Text += "Butoi Emanuel-Sebastian";

                allert = true;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbSum.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new PointF(100,100));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (allert == false)
            {
                MessageBox.Show("You need to press the 'Buy All' button before printing");
            }

            else
            {

                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            
        }


    }
}
