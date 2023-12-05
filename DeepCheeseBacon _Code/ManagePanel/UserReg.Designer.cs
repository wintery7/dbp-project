namespace deepcheesebacon
{
    partial class UserReg
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
            regBtn = new Button();
            nameText = new TextBox();
            addrText = new TextBox();
            pnumText = new TextBox();
            genderText = new TextBox();
            dateText = new TextBox();
            pwText = new TextBox();
            emailText = new TextBox();
            roleText = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // regBtn
            // 
            regBtn.Location = new Point(268, 325);
            regBtn.Margin = new Padding(2, 2, 2, 2);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(267, 34);
            regBtn.TabIndex = 47;
            regBtn.Text = "등록";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // nameText
            // 
            nameText.ForeColor = Color.Silver;
            nameText.Location = new Point(268, 101);
            nameText.Margin = new Padding(2, 2, 2, 2);
            nameText.Multiline = true;
            nameText.Name = "nameText";
            nameText.Size = new Size(268, 27);
            nameText.TabIndex = 38;
            nameText.Text = "이름";
            nameText.Enter += nameText_Enter;
            // 
            // addrText
            // 
            addrText.ForeColor = Color.Silver;
            addrText.Location = new Point(268, 286);
            addrText.Margin = new Padding(2, 2, 2, 2);
            addrText.Multiline = true;
            addrText.Name = "addrText";
            addrText.Size = new Size(268, 27);
            addrText.TabIndex = 40;
            addrText.Text = "주소";
            addrText.Enter += addrText_Enter;
            // 
            // pnumText
            // 
            pnumText.ForeColor = Color.Silver;
            pnumText.Location = new Point(268, 254);
            pnumText.Margin = new Padding(2, 2, 2, 2);
            pnumText.Multiline = true;
            pnumText.Name = "pnumText";
            pnumText.Size = new Size(268, 27);
            pnumText.TabIndex = 41;
            pnumText.Text = "전화번호";
            pnumText.Enter += pnumText_Enter;
            // 
            // genderText
            // 
            genderText.ForeColor = Color.Silver;
            genderText.Location = new Point(268, 163);
            genderText.Margin = new Padding(2, 2, 2, 2);
            genderText.Multiline = true;
            genderText.Name = "genderText";
            genderText.Size = new Size(268, 27);
            genderText.TabIndex = 43;
            genderText.Text = "성별";
            genderText.Enter += genderText_Enter;
            // 
            // dateText
            // 
            dateText.ForeColor = Color.Silver;
            dateText.Location = new Point(268, 133);
            dateText.Margin = new Padding(2, 2, 2, 2);
            dateText.Multiline = true;
            dateText.Name = "dateText";
            dateText.Size = new Size(268, 27);
            dateText.TabIndex = 44;
            dateText.Text = "생년월일";
            dateText.Enter += dateText_Enter;
            // 
            // pwText
            // 
            pwText.ForeColor = Color.Silver;
            pwText.Location = new Point(268, 55);
            pwText.Margin = new Padding(2, 2, 2, 2);
            pwText.Multiline = true;
            pwText.Name = "pwText";
            pwText.PasswordChar = '*';
            pwText.Size = new Size(268, 27);
            pwText.TabIndex = 45;
            pwText.Text = "비밀번호";
            pwText.Enter += pwText_Enter;
            // 
            // emailText
            // 
            emailText.ForeColor = Color.Silver;
            emailText.Location = new Point(268, 23);
            emailText.Margin = new Padding(2, 2, 2, 2);
            emailText.Multiline = true;
            emailText.Name = "emailText";
            emailText.Size = new Size(268, 27);
            emailText.TabIndex = 48;
            emailText.Text = "이메일";
            emailText.Enter += emailText_Enter;
            // 
            // roleText
            // 
            roleText.ForeColor = Color.Silver;
            roleText.Location = new Point(268, 194);
            roleText.Margin = new Padding(2, 2, 2, 2);
            roleText.Multiline = true;
            roleText.Name = "roleText";
            roleText.Size = new Size(268, 27);
            roleText.TabIndex = 51;
            roleText.Text = "직급";
            roleText.Enter += roleText_Enter;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.ForeColor = Color.Silver;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(268, 224);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 23);
            comboBox1.TabIndex = 61;
            comboBox1.Text = "담당과목";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UserReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(roleText);
            Controls.Add(emailText);
            Controls.Add(regBtn);
            Controls.Add(nameText);
            Controls.Add(addrText);
            Controls.Add(pnumText);
            Controls.Add(genderText);
            Controls.Add(dateText);
            Controls.Add(pwText);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserReg";
            Size = new Size(765, 391);
            Load += UserReg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button regBtn;
        private TextBox nameText;
        private TextBox addrText;
        private TextBox pnumText;
        private TextBox genderText;
        private TextBox dateText;
        private TextBox pwText;
        private TextBox emailText;
        private TextBox roleText;
        private ComboBox comboBox1;
    }
}
