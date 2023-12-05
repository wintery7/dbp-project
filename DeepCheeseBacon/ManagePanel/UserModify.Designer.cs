using deepcheesebacon.Customizing;

namespace deepcheesebacon
{
    partial class UserModify
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            modifyBtn = new CustomButtonStyle();
            label2 = new Label();
            nameText = new TextBox();
            addrText = new TextBox();
            pnumText = new TextBox();
            roleText = new TextBox();
            genderText = new TextBox();
            dateText = new TextBox();
            pwText = new TextBox();
            emailText = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // modifyBtn
            // 
            modifyBtn.BackColor = SystemColors.Window;
            modifyBtn.BackgroundColor = SystemColors.Window;
            modifyBtn.BorderColor = Color.FromArgb(94, 159, 242);
            modifyBtn.BorderRadius = 10;
            modifyBtn.BorderSize = 2;
            modifyBtn.FlatStyle = FlatStyle.Flat;
            modifyBtn.ForeColor = Color.DarkBlue;
            modifyBtn.Location = new Point(520, 328);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(343, 45);
            modifyBtn.TabIndex = 59;
            modifyBtn.Text = "수정";
            modifyBtn.TextColor = Color.DarkBlue;
            modifyBtn.UseVisualStyleBackColor = false;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(95, 126);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 58;
            label2.Text = "* 이메일은 변경 불가";
            // 
            // nameText
            // 
            nameText.ForeColor = Color.Silver;
            nameText.Location = new Point(95, 252);
            nameText.Multiline = true;
            nameText.Name = "nameText";
            nameText.Size = new Size(343, 35);
            nameText.TabIndex = 49;
            nameText.Text = "이름";
            nameText.Enter += nameText_Enter;
            // 
            // addrText
            // 
            addrText.ForeColor = Color.Silver;
            addrText.Location = new Point(520, 271);
            addrText.Multiline = true;
            addrText.Name = "addrText";
            addrText.Size = new Size(343, 35);
            addrText.TabIndex = 51;
            addrText.Text = "주소";
            addrText.TextChanged += addrText_TextChanged;
            addrText.Enter += addrText_Enter;
            // 
            // pnumText
            // 
            pnumText.ForeColor = Color.Silver;
            pnumText.Location = new Point(520, 230);
            pnumText.Multiline = true;
            pnumText.Name = "pnumText";
            pnumText.Size = new Size(343, 35);
            pnumText.TabIndex = 52;
            pnumText.Text = "전화번호";
            pnumText.Enter += pnumText_Enter;
            // 
            // roleText
            // 
            roleText.ForeColor = Color.Silver;
            roleText.Location = new Point(520, 148);
            roleText.Multiline = true;
            roleText.Name = "roleText";
            roleText.Size = new Size(343, 35);
            roleText.TabIndex = 53;
            roleText.Text = "직급";
            roleText.Enter += roleText_Enter;
            // 
            // genderText
            // 
            genderText.ForeColor = Color.Silver;
            genderText.Location = new Point(95, 335);
            genderText.Multiline = true;
            genderText.Name = "genderText";
            genderText.Size = new Size(343, 35);
            genderText.TabIndex = 54;
            genderText.Text = "성별";
            genderText.Enter += genderText_Enter;
            // 
            // dateText
            // 
            dateText.ForeColor = Color.Silver;
            dateText.Location = new Point(95, 294);
            dateText.Multiline = true;
            dateText.Name = "dateText";
            dateText.Size = new Size(343, 35);
            dateText.TabIndex = 55;
            dateText.Text = "생년월일";
            dateText.Enter += dateText_Enter;
            // 
            // pwText
            // 
            pwText.ForeColor = Color.Silver;
            pwText.Location = new Point(95, 190);
            pwText.Multiline = true;
            pwText.Name = "pwText";
            pwText.Size = new Size(343, 35);
            pwText.TabIndex = 56;
            pwText.Text = "비밀번호";
            pwText.Enter += pwText_Enter;
            // 
            // emailText
            // 
            emailText.ForeColor = Color.Silver;
            emailText.Location = new Point(95, 148);
            emailText.Multiline = true;
            emailText.Name = "emailText";
            emailText.Size = new Size(343, 35);
            emailText.TabIndex = 57;
            emailText.Text = "이메일";
            emailText.Enter += emailText_Enter;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.ForeColor = Color.Silver;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(520, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(343, 28);
            comboBox1.TabIndex = 60;
            comboBox1.Text = "담당과목";
            // 
            // UserModify
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(modifyBtn);
            Controls.Add(label2);
            Controls.Add(nameText);
            Controls.Add(addrText);
            Controls.Add(pnumText);
            Controls.Add(roleText);
            Controls.Add(genderText);
            Controls.Add(dateText);
            Controls.Add(pwText);
            Controls.Add(emailText);
            Name = "UserModify";
            Size = new Size(966, 520);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButtonStyle modifyBtn;
        private Label label2;
        private TextBox nameText;
        private TextBox addrText;
        private TextBox pnumText;
        private TextBox roleText;
        private TextBox genderText;
        private TextBox dateText;
        private TextBox pwText;
        private TextBox emailText;
        private ComboBox comboBox1;
    }
}
