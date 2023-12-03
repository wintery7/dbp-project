using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deepcheesebacon
{
    public partial class Salary : UserControl
    {
        private DBManager dbManager;
        public Salary()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            DataSet dataset = dbManager.ViewTableSalary();
            payView.DataSource = dataset.Tables[0];
        }
    }
}
