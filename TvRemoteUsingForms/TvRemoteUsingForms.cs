using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvRemoteva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string tv = Convert.ToString(txtName.Text);


            switch (Convert.ToString(tv))
            {
                case "on":
                    Console.WriteLine(lblOutput.Text = "Your Tv Is On");
                    break;

                case "up":
                    Console.WriteLine(lblOutput.Text = "Your Tv Volume Is Up");
                    break;

                case "down":
                    Console.WriteLine(lblOutput.Text = "Your Tv Volume Is Down");
                    break;

                case "off":
                    Console.WriteLine(lblOutput.Text = "Your Tv Is Off");
                    break;
                default:
                    Console.WriteLine(lblOutput.Text = "Cannot Perform Any Operation");
                    break;

            }
        }
    }
}
