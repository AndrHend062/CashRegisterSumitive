// Andrew Cash register October 2017 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CashRegisterSumitive
{
    public partial class cashForm : Form
    {
        const double BURGER_PRICE = 2.49;
        const double FRIES_PRICE = 1.89;
        const double DRINK_PRICE = 0.99;
        const double TAX = 0.13;
        double burgers;
        double fries;
        double drinks;
        double burgersCost;
        double friesCost;
        double drinksCost;
        double costBFD;
        double taxPrice;
        double totalPrice;
        double changePay;
        double changeDue;

        public cashForm()


        {
            InitializeComponent();



        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {


                burgers = Convert.ToDouble(textBoxBurger.Text);
                fries = Convert.ToDouble(textBoxfries.Text);
                drinks = Convert.ToDouble(textBoxdrinks.Text);

                friesCost = fries * FRIES_PRICE;
                burgersCost = burgers * BURGER_PRICE;
                drinksCost = drinks * DRINK_PRICE;
                costBFD = burgersCost + drinksCost + friesCost; //calculate prices 
                taxPrice = costBFD * TAX;
                totalPrice = taxPrice + costBFD;
                changeDue = changePay - totalPrice;

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
            try
            {
                changePay = Convert.ToDouble(textBoxChange.Text);

                changeDue = changePay - totalPrice; //calculate change 

                changeLabel.Text = changeDue.ToString("C");  // draw change 
                receiptButton.Visible = true;
            }
            catch
            {
                changeLabel.Text = "error";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics onScreen = this.CreateGraphics(); //Sets up on-screen graphics
                Bitmap bm = new Bitmap(this.Width, this.Height); //bitmap area size of whole screen
                Graphics offScreen = Graphics.FromImage(bm); //Sets off-screen graphics to the bitmap

                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Pen penPen = new Pen(Color.Red, 10);
                Font arialFont = new Font("Arial", 10, FontStyle.Regular);
                SoundPlayer printPlayer = new SoundPlayer(Properties.Resources.print);
                printPlayer.Play();



                offScreen.FillRectangle(whiteBrush, 300, 50, 150, 300); //print receipt 
                offScreen.DrawString("             receipt  1" + "\n"+
                    "Burgers  X" + burgers + "\n" +
                    "Fries    X" + fries + "\n"+
                    "Drinks   X" +drinks + "\n"+
                    "Sub total" +"\n"+
                    "Tax \n"+ 
                    "Total \n" + "Tendered \n Change due "
                    , arialFont, blackBrush, 300, 60);
                offScreen.DrawString(  "\n"+burgersCost + "\n" + //drawing values 
                    friesCost + "\n"+ 
                    drinksCost + "\n"+
                    costBFD +"\n"+
                    taxPrice+ "\n"+
                    totalPrice+ "\n"+
                    changePay + "\n"+
                    changeDue

                    , arialFont, blackBrush, 380, 60);



                onScreen.DrawImage(bm, 0, 0);

                newButton.Visible = true;

            }
            catch
            {
                totalLable.Text = "error";
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
           
            Graphics onScreen = this.CreateGraphics(); //Sets up on-screen graphics
            Bitmap bm = new Bitmap(this.Width, this.Height); //bitmap area size of whole screen
            Graphics offScreen = Graphics.FromImage(bm); //Sets off-screen graphics to the bitmap

            SolidBrush whiteBrush = new SolidBrush(Color.LightGray);

            offScreen.FillRectangle(whiteBrush, 300, 50, 150, 300);

            onScreen.DrawImage(bm, 0, 0);
        }
    }
}