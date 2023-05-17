using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTesting
{
    public partial class Form1 : Form
    {
        public Form2 NewFormWindow = new Form2();
        public string Username;
        public string Password;
        public Form1()
        {
            InitializeComponent();
        }
        private void HandleSubmit(string username, string password)
        {
            string ErrorTitle;
            string ErrorMessage;

            if ((username == null || password == null) || (username == "" || password == "")) {
                 ErrorTitle = "Warning";
                 ErrorMessage = "Cannot submit without entries";
                MessageBox.Show(ErrorMessage, ErrorTitle);
            }
            else if (username != "Admin" || password != "password")
            {
                ErrorTitle = "Warning";
                ErrorMessage = "Invalid username/password. Try again";
                MessageBox.Show(ErrorMessage, ErrorTitle);
            }
            if (username == "Admin" || password == "password")
            {
                this.Visible = false;
                NewFormWindow.Show();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void userSubmitButton_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            HandleSubmit(Username, Password);
        }

    }
}
