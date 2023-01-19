using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInUniversidadDelSur
{
    public partial class Form1 : Form
    {
        static int attempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //define username and password
            //username="Perla" and password ="Ladybug1"
            //you have only 3 attempts
            string username = txbxUsername.Text;
            string password = txbxPassword.Text;
            

                if (this.txbxUsername.Text == "Perla" && this.txbxPassword.Text == "Ladybug1")
                {
                    attempts = 0;
                    pictureBox1.Image = new Bitmap(@"C:\Users\perla\source\repos\LogInUniversidadDelSur\unlocklogo.png");
                    MessageBox.Show("Welcome");

                }
                else if (attempts <= 3 && attempts > 0)
                {
                  
                    //warns the user of the number  of attempts left
                    lblWarning.Text = "You have " + Convert.ToString(attempts-1) + " attempts left";
                    attempts--;
                    lblWarning.BackColor = Color.Red;
                    pictureBox1.Image = new Bitmap(@"C:\Users\perla\source\repos\LogInUniversidadDelSur\warning.png");
                   
                }
                else
                {
                    MessageBox.Show("WRONG USERNAME AND PASSWORD");
                    attempts++;
                    MessageBox.Show("You have exceeded the maximum number of attempts. Good bye!");
                    Application.Exit();

                 }
                



        }
    }
}
