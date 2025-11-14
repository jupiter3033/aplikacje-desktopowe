using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teststset
{
 
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button_zaloguj_Click(object sender, EventArgs e)
        {
            var login = box_login.Text;
            var password = box_pass.Text;
           

            if (IsUserValid(login,password))
            {

                home formhome = new home();
                formhome.Show();

            }
            else {
                MessageBox.Show("ez?");
            }

        }
        private bool IsUserValid(string login, string haslo) {

            var userRepo = new usersreposi();
            var isvalid = userRepo.users.Any(u => u.login == login && u.password == haslo);
            return isvalid;
        }
    }
}
