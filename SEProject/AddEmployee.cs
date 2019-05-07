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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void generateContractButton_Click(object sender, EventArgs e)
        {
            IBlockDBEntities1 IBlockEntity = new IBlockDBEntities1();
            Employees_Table employee = new Employees_Table();
            employee.Name = newEmplNameBox.Text;
            employee.Surname = newEmplSurnameBox.Text;
            employee.Address = newEmplAddressBox.Text;
            employee.Series = newEmpilDSeriesBox.Text;
            employee.Data = newEmplIDDataBox.Text;
            employee.CNP = newEmplCNPBox.Text;
            employee.Job = newEmplJobBox.Text;

            IBlockEntity.Employees_Table.Add(employee);

            Contract_Table contract = new Contract_Table();
            contract.Contract_period = newEmplContractComboBox.Text;
            contract.Start_date = newEmplStartDataBox.Text;
            contract.End_date = newEmplEndDateBox.Text;
            contract.Salary = newEmplSalaryBox.Text;

            IBlockEntity.Contract_Table.Add(contract);
            IBlockEntity.SaveChanges();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
