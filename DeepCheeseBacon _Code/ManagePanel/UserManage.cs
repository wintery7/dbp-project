using deepcheesebacon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deepcheesebacon
{
    public partial class UserManage : UserControl
    {
        private DBManager dbManager;

        public UserManage()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();

        }

        // 과목별로 검색
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string dep = depText.Text;

            DataSet dataset = dbManager.GetUser_dep(dep);
            dataGridView1.DataSource = dataset.Tables[0];


            depText.Clear();

        }

        // 이름별로 검색
        private void NameSearchBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;

            DataSet dataset = dbManager.GetUser_name(name);
            dataGridView1.DataSource = dataset.Tables[0];

            nameText.Clear();
        }

        // 나이별로 검색
        private void AgeSearchBtn_Click(object sender, EventArgs e)
        {
            string year = dateText.Text;
            DataSet dataset = dbManager.GetUser_date(year);
            dataGridView1.DataSource = dataset.Tables[0];

            dateText.Clear();
        }

        // 과목별, 이름별, 나이별 셀 클릭시
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow;
                selectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                userIdText.Text = row.Cells[0].Value.ToString(); // user_id를 textbox에 띄움
            }
            catch (Exception ex)
            {

            }
            

        }

        // 목록에서 수정버튼 누를 경우
        private void ModifyBtn_Click(object sender, EventArgs e)
        {

            string id = userIdText.Text;
      
            // UserModify 화면 뜨도록
            this.Controls.Clear();
            UserModify userModify = new UserModify(id);
            this.Controls.Add(userModify);

        }

        // 목록에서 삭제
        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            string delete = userIdText.Text;

            dbManager.UserDeleteData(delete);

            dateText.Clear();
            DataSet dataset = dbManager.ViewTableUser();
            dataGridView1.DataSource = dataset.Tables[0];
        }
    }
}
