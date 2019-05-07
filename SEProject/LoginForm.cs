using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            IBlockDBEntities1 IBlockEntity = new IBlockDBEntities1();
            if(adminUserLoginBox.Text!=string.Empty || passAdminBox.Text != string.Empty)
            {
                var user1 = IBlockEntity.Admin_Table.FirstOrDefault(a => a.Username.Equals(adminUserLoginBox.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passAdminBox.Text))
                    {
                        if (user1.Type.Equals("admin"))
                        {
                            
                            MainForm mainForm = new MainForm(this);
                            mainForm.ShowDialog();
                           

                        }
                        else
                        {
                            UserForm userForm = new UserForm();
                            userForm.ShowDialog();
                            
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("Empty rows");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }

        private void adminUserLoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passAdminBox_TextChanged(object sender, EventArgs e)
        {

        }

        public string getUser()
        {
            return adminUserLoginBox.Text;
        }
    }
}
