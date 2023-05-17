using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTesting
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string CustomerName;
        string CustomerDrink;
        float CustomerPrice;
        
        public Object[] NewRow(string name, string drink, float price) {

            return new Object[] { name, drink, price };
        }

        public void Error(string title, string error)
        {
            MessageBox.Show(title, error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleAddDrink();
            HandleRadioButtons();
        }
        public string HandleRadioButtons()
        {
            if (radio_domestic.Checked)     { CustomerPrice = 5.50f;  return CustomerDrink = "domestic"; };
            if (radio_import.Checked)       { CustomerPrice = 6.15f; return CustomerDrink = "Import";}
            if (radio_shot.Checked)         { CustomerPrice = 5.50f; return CustomerDrink = "Shot"; }
            if (radio_doubleshot.Checked)   { CustomerPrice = 10.00f; return CustomerDrink = "Double Shot"; }
            if (radio_draft.Checked)        { CustomerPrice = 5.75f; return CustomerDrink = "Draft"; }
            if (radio_cooler.Checked)       { CustomerPrice = 6.25f; return CustomerDrink = "Cooler"; }
            if (radio_cocktail.Checked)     { CustomerPrice = 6.75f; return CustomerDrink = "Cocktail"; }
            else return null;
        }
        public void HandleAddDrink()
        {
            HandleRadioButtons();

            if (string.IsNullOrEmpty(customerBox.Text))
            {
            Error("Please Enter the Customer's Name", "Error");
            }
            else if (string.IsNullOrEmpty(CustomerDrink))
            {
            Error("Please Select a Drink", "Error");
            }
            else if ((!string.IsNullOrEmpty(customerBox.Text)) || (!string.IsNullOrEmpty(CustomerDrink))) {
                CustomerName = customerBox.Text;

                //log the drink 
                customerTable.Rows.Add(NewRow(CustomerName, CustomerDrink, CustomerPrice));
                CustomerDrink = "";
            }

        }
    }
}
