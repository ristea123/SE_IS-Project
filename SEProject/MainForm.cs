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
        IBlockDBEntities1 blockDBEntities = new IBlockDBEntities1();
        List<Employees_Table> emp;
        public MainForm(LoginForm lf)
        {
            InitializeComponent();
            logf = lf;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            currentUser.Text = logf.getUser();
            emp = blockDBEntities.Employees_Table.ToList();
            var list = new BindingList<Employees_Table>(emp);
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this);
            addEmployee.ShowDialog();
            emp = blockDBEntities.Employees_Table.ToList();
            var list = new BindingList<Employees_Table>(emp);
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
            this.Refresh();
        }

        public void updateGrid()
        {
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Employees_Table employee = emp.ElementAt(index);
            blockDBEntities.Employees_Table.Remove(employee);
            blockDBEntities.SaveChanges();
            dataGridView1.Rows.RemoveAt(index);
            dataGridView1.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, 1, dataGridView1);
            form2.ShowDialog();
        }
    }
}
