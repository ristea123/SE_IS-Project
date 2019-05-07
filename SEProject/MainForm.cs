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
    public partial class MainForm : Form
    {
        LoginForm logf;
        public MainForm(LoginForm lf)
        {
            InitializeComponent();
            logf = lf;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            currentUser.Text = logf.getUser();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }
    }
}
