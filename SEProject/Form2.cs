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
    public partial class Form2 : Form
    {
        int index;
        IBlockDBEntities1 blockDBEntities = new IBlockDBEntities1();
        List<Employees_Table> emp;
        DataTable dataGridView1;

        public Form2(MainForm adm, int index, System.Windows.Forms.DataGridView dataGridView1)
        {
            InitializeComponent();
            emp = blockDBEntities.Employees_Table.ToList();
            var list = new BindingList<Employees_Table>(emp);
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp.ElementAt(0).Name = "aaa";
            blockDBEntities.SaveChanges();
            
        }
    }
}
