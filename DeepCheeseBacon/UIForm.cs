
using System.Diagnostics;
using System.Timers;

namespace deepcheesebacon
{
    public partial class UIForm : Form
    {
        private Form activeForm;
        LoginedUserInfo myInfo;
        DBManager db;
        private System.Timers.Timer timer;

        public UIForm()
        {
            InitializeComponent();
            db = DBManager.GetInstance();


            activeForm = null;

            LoginForm form = new LoginForm();
            form.ShowDialog();
            while (LoginedUserInfo.loginedUserInfo.email.Equals("test"))
            {
                MessageBox.Show("로그인해주세요");
                form = new LoginForm();
                form.ShowDialog();
            }

            myInfo = LoginedUserInfo.GetMyInfo();

            //ApiManager.CreateChatRoomAsync("테스트용 채팅방1").Wait();

            // 타이머 설정 (3초마다 체크)
            timer = new System.Timers.Timer(4000);
            timer.Elapsed += TimerElapsed;

        }

        private async void UIForm_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 타이머 시작
            timer.Start();

            // 디비 체크를 여기서 처음 한번 호출
            await CheckAndShowAlert();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // 3초마다 디비 체크 및 알람 띄우기 호출
            _ = CheckAndShowAlert();
        }

        private async Task CheckAndShowAlert()
        {
            try
            {
                // 디비 체크 로직을 여기에 구현
                bool hasNewMessage = await db.CheckNewMessageForAlarm(LoginedUserInfo.loginedUserInfo.userId);

                if (hasNewMessage)
                {
                    // 메시지가 있으면 알람 띄우기
                    MessageBox.Show("새로운 메시지가 도착했습니다!");
                }
            }
            catch (Exception ex)
            {
                // 예외 처리: 디비 체크 중 오류가 발생한 경우
                Console.WriteLine($"Error checking for new messages: {ex.Message}");
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ApprovalSystemMainForm(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form(), sender);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // 결재 시스템 메인 폼 오픈
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkForm(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MessageLobbyForm(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
