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

        private void UserRegBtn_Click(object sender, EventArgs e)
        {

            pMain.Controls.Clear();
            pMain.Controls.Add(userReg);
        }

        private void UserManageBtn_Click(object sender, EventArgs e)
        {

            pMain.Controls.Clear();
            pMain.Controls.Add(userManage);
        }

        private void SubjectManageBtn_Click(object sender, EventArgs e)
        {

            pMain.Controls.Clear();
            pMain.Controls.Add(subjectManage);

        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {

            pMain.Controls.Clear();
            pMain.Controls.Add(salary);
        }

        private void AttendRegBtn_Click(object sender, EventArgs e)
        {

            pMain.Controls.Clear();
            pMain.Controls.Add(attendanceView);
        }

        private void AttendancelogBtn_Click(object sender, EventArgs e)
        {


            pMain.Controls.Clear();
            pMain.Controls.Add(attendanceReg);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
