using deepcheesebacon;
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
    public partial class AttendanceView : UserControl
    {
        private DBManager dbManager;

        public AttendanceView()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();

        }

        // 출퇴근 시간 출력
        private void AttendTimeBtn_Click(object sender, EventArgs e)
        {
            DataSet dataset = dbManager.AttendanceViewTable();
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
