using DeepCheeseBacon.SourceCode.ApprovalSystem;
using DeepCheeseBacon.SourceCode.ApprovalSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeepCheeseBacon.SourceCode.LoginSystem.Forms
{
    public partial class LoginForm : Form
    {
        DBManager dbManager;
        public LoginForm()
        {
            InitializeComponent();
            dbManager = DBManager.GetDBManager();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User originUser = dbManager.GetUserByEmail(textBoxEmail.Text);
            if (textBoxPassword.Text == originUser.Password)
            {
                MyInfo myInfo = MyInfo.GetMyInfo();
                myInfo.email = originUser.Email;
                myInfo.userId = originUser.UserId;
                myInfo.role = originUser.UserRole;

                MessageBox.Show("로그인에 성공하였습니다");

                // 로그인 후 실행할 메서드 작성
                ApprovalSystemMainForm form = new ApprovalSystemMainForm(); 
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("로그인에 실패하였습니다");
                Console.WriteLine("originUser.Password: " + originUser.Password);
            }
        }
    }
}
