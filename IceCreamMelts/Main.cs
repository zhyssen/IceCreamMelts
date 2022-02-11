using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamMelts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            // Price constants
            const decimal ONE_SCOOP = 2.2m;
            const decimal TWO_SCOOP = 3.0m;
            const decimal THREE_SCOOP = 4.0m;
            const decimal TOPPINGS = 0.5m;

            // Variables
            decimal total = 0;
            decimal scoopTotal = 0;
            decimal toppingTotal = 0;
            int toppingCount = 0;

            // Create an instance of the PriceForm class
            PriceForm myPriceForm = new PriceForm();

            // Find the selected radio button for number of scoops
            // and display the selection
            if (threeScoopsRadioButton.Checked)
            {
                myPriceForm.scoopsLabel.Text = "3";
                scoopTotal = THREE_SCOOP;
            }
            else if (twoScoopsRadioButton.Checked)
            {
                myPriceForm.scoopsLabel.Text = "2";
                scoopTotal = TWO_SCOOP;
            }
            else if (oneScoopRadioButton.Checked)
            {
                myPriceForm.scoopsLabel.Text = "1";
                scoopTotal = ONE_SCOOP;
            }

            // Find the selected radio button for the flavor
            // and display the selection
            if (chocolateRadioButton.Checked)
            {
                myPriceForm.flavorLabel.Text = "Chocolate";
            }
            else if (vanillaRadioButton.Checked)
            {
                myPriceForm.flavorLabel.Text = "Vanilla";
            }
            else if (strawberryRadioButton.Checked)
            {
                myPriceForm.flavorLabel.Text = "Strawberry";
            }

            // Find the selected check boxes
            if (nutsCheckBox.Checked)
            {
                toppingCount = toppingCount + 1;
            }

            if (whippedCheckBox.Checked)
            {
                toppingCount = toppingCount + 1;
            }

            if (cherryCheckBox.Checked)
            {
                toppingCount = toppingCount + 1;
            }

            // Calculate the toppings total
            toppingTotal = toppingCount * TOPPINGS;

            // Calculate to toal cost
            total = toppingTotal + scoopTotal;

            // Display the number of toppings
            myPriceForm.toppingsLabel.Text = toppingCount.ToString();

            // Display the total cost
            myPriceForm.costLabel.Text = total.ToString("c");

            // Display PriceForm
            myPriceForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}