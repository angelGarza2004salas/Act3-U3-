using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Form1 : Form
    {
        private User user;
        private double someOtherVariable; // Using another type of variable


        public Form1()
        {
            InitializeComponent();
            user = new User();
            this.FormClosing += Form1_FormClosing; 
        }
        //
        public Form1(string name, int age, double someOtherValue)
        {
            InitializeComponent();
            user = new User(name, age);
            someOtherVariable = someOtherValue;
            this.FormClosing += Form1_FormClosing;
            UpdateLabel();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtInsertName.Text))
            {
                label1.Text = "Please enter your name.";
            }
            else
            {
                user.Name = TxtInsertName.Text;
                user.Age++;
                UpdateLabel();
            }
        }
        private void UpdateLabel()
        {
            label1.Text = $"{user.Name} has had a birthday. They now have {user.Age} years.";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("The form has been closed.");
        }
        
        //destructor
        ~Form1()
        {
            Console.WriteLine("Form1 object destroyed.");
        }

    }
}

