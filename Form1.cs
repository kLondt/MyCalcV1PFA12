using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalcV1PFA12
{
    public partial class Form1 : Form

    {
        int FirstNUM;
        int SeconNUM;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
               
            }
           
        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            FirstNUM = int.Parse(txtnum1.Text);
            SeconNUM = int.Parse(txtnum2.Text);
            if (txtoper.Text == "+") {  
                int addition = FirstNUM + SeconNUM;
                lstout.Items.Add(FirstNUM+""+"+"+""+SeconNUM+"=" +addition);
            }
           else if( txtoper.Text=="-")
            {
                int subtraction = FirstNUM - SeconNUM;
                lstout.Items.Add(FirstNUM + "" + "-" + "" + SeconNUM+"=" +subtraction);
            }
            else if (txtoper.Text == "*")
            {
                int product = FirstNUM * SeconNUM;
                lstout.Items.Add(FirstNUM + "" + "*"+ "" + SeconNUM +"="+ product);

            }
            else if (txtoper.Text == "/")
            {
                int division = FirstNUM / SeconNUM;
                lstout.Items.Add(FirstNUM + "" + "/" + "" + SeconNUM + "=" +division);

            }
           else if (txtoper.Text == "%")
            {
                int modules = FirstNUM % SeconNUM;
                lstout.Items.Add(FirstNUM + "" + "%" + "" + SeconNUM + "=" + modules);
            }
            
            else
            {
                lstout.Items.Add("please insert a valid input ");
            }

        


        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lstout.Items.Clear();
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtoper.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
