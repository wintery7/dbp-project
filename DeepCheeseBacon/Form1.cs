namespace deepcheesebacon
{
    public partial class form : Form
    {
        UserReg userReg = new UserReg();
        UserManage userManage = new UserManage();
        Salary salary = new Salary();
        SubjectManage subjectManage = new SubjectManage();
        AttendanceView attendanceView = new AttendanceView();
        AttendanceReg attendanceReg = new AttendanceReg();

        private Button? lastClickedItem;

        public form()
        {
            InitializeComponent();
        }



        private void MenuColor(object sender)
        {
            // 이전에 클릭한 메뉴 있으면 색 원래대로 복원
            if (lastClickedItem != null)
            {
                lastClickedItem.BackColor = Color.SteelBlue;
            }

            // 새로 클릭한 메뉴 배경색 변경
            Button menu = (Button)sender;
            menu.BackColor = Color.SkyBlue;
            lastClickedItem = menu;
        }

        private void UserRegBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // 기존 판넬에 있는 판넬 지우고 userReg 띄움
            pMain.Controls.Clear();
            pMain.Controls.Add(userReg);
        }

        private void UserManageBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // 기존 판넬에 있는 판넬 지우고 userManage 띄움
            pMain.Controls.Clear();
            pMain.Controls.Add(userManage);
        }

        private void SubjectManageBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // 기존 판넬에 있는 판넬 지우고 subjectManage 띄움
            pMain.Controls.Clear();
            pMain.Controls.Add(subjectManage);

        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // 기존 판넬에 있는 판넬 지우고 salary 띄움
            pMain.Controls.Clear();
            pMain.Controls.Add(salary);
        }

        private void AttendRegBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // 기존 판넬에 있는 판넬 지우고  attendanceReg 띄움
            pMain.Controls.Clear();
            pMain.Controls.Add(attendanceView);
        }

        private void AttendancelogBtn_Click(object sender, EventArgs e)
        {

            MenuColor((Button)sender);

            // 기존 판넬에 있는 판넬 지우고  attendanceReg 띄움
            pMain.Controls.Clear();
            pMain.Controls.Add(attendanceReg);
        }

    }
}
