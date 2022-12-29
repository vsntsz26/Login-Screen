using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen_Windows_Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtuser.Text.Equals("Vinicius") && txtpass.Text.Equals("12345"))
                {
                    var menu = new MenuLogin();
                    menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("User or Password incorrects.",
                        "Sorry",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtuser.Focus();
                    txtpass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry.",
                       ex.Message,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }
    }
}

       
           
        
    

