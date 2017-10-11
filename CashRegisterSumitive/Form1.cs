using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegisterSumitive
{
    public partial class Form1 : Form
    {
        const double BURGER_PRICE = 2.49;
        const double FRIES_PRICE = 1.89;
        const double DRINK_PRICE = 0.99;
        double burgers;
        double fries;
        double drinks;
        double burgersCost;
        double friesCost;
        double drinksCost;
        double Tax = 0.13;
        double costBFD;
        double taxPrice;
        double totalPrice;
        double changePay;
        double changeDue;


        public Form1()


        {
            InitializeComponent();



        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {


                burgers = Convert.ToInt32(textBoxBurger.Text);
                fries = Convert.ToInt32(textBoxfries.Text);
                drinks = Convert.ToInt32(textBoxdrinks.Text);

                friesCost = fries * FRIES_PRICE;
                burgersCost = burgers * BURGER_PRICE;
                drinksCost = drinks * DRINK_PRICE;
                costBFD = burgersCost + drinksCost + friesCost;
                taxPrice = costBFD * Tax;
                totalPrice = taxPrice + costBFD;


                totalLable.Text = "sub total      " + costBFD +
                    "\n tax       " + taxPrice +
                    "\n total    " + totalPrice;


            }
            catch
            {
                totalLable.Text = "enter a whole number";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            friesCost = fries * FRIES_PRICE;
            burgersCost = burgers * BURGER_PRICE;
            drinksCost = drinks * DRINK_PRICE;
            costBFD = burgersCost + drinksCost + friesCost;
            taxPrice = costBFD * Tax;
            totalPrice = taxPrice + costBFD;

            changePay = Convert.ToInt32(textBoxChange.Text);
             
            changeDue = changePay - totalPrice;

            changeLabel.Text = "Change due " + changeDue.ToString("C");
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics fG = this.CreateGraphics();
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Pen penPen = new Pen(Color.Red, 10);
                Font arialFont = new Font("Arial", 10, FontStyle.Regular);


                fG.FillRectangle(whiteBrush, 300, 50, 150, 300);
                fG.DrawString("        receipt" + "\n"+
                    "Burgers  X" + burgers + "\n" +
                    "Fries    X" + fries + "\n"+
                    "Drinks   X" +drinks + "\n", arialFont, blackBrush, 300, 60);
                fG.DrawString(  burgersCost + "\n" +
                    friesCost + "\n"+ 
                    drinksCost + "\n", arialFont, blackBrush, 380, 60);


            }
            catch
            {
                totalLable.Text = "error";
            }
        }
    }
}