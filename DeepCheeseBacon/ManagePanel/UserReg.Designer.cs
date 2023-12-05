﻿using deepcheesebacon.Customizing;

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
            regBtn = new CustomButtonStyle();
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
            regBtn.BackColor = SystemColors.Window;
            regBtn.BackgroundColor = SystemColors.Window;
            regBtn.BorderColor = Color.FromArgb(94, 159, 242);
            regBtn.BorderRadius = 10;
            regBtn.BorderSize = 2;
            regBtn.FlatStyle = FlatStyle.Flat;
            regBtn.ForeColor = Color.DarkBlue;
            regBtn.Location = new Point(509, 316);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(343, 45);
            regBtn.TabIndex = 47;
            regBtn.Text = "등록";
            regBtn.TextColor = Color.DarkBlue;
            regBtn.UseVisualStyleBackColor = false;
            regBtn.Click += regBtn_Click;
            // 
            // nameText
            // 
            nameText.ForeColor = Color.Silver;
            nameText.Location = new Point(113, 246);
            nameText.Multiline = true;
            nameText.Name = "nameText";
            nameText.Size = new Size(343, 35);
            nameText.TabIndex = 38;
            nameText.Text = "이름";
            nameText.Enter += nameText_Enter;
            // 
            // addrText
            // 
            addrText.ForeColor = Color.Silver;
            addrText.Location = new Point(509, 264);
            addrText.Multiline = true;
            addrText.Name = "addrText";
            addrText.Size = new Size(343, 35);
            addrText.TabIndex = 40;
            addrText.Text = "주소";
            addrText.Enter += addrText_Enter;
            // 
            // pnumText
            // 
            pnumText.ForeColor = Color.Silver;
            pnumText.Location = new Point(509, 222);
            pnumText.Multiline = true;
            pnumText.Name = "pnumText";
            pnumText.Size = new Size(343, 35);
            pnumText.TabIndex = 41;
            pnumText.Text = "전화번호";
            pnumText.Enter += pnumText_Enter;
            // 
            // genderText
            // 
            genderText.ForeColor = Color.Silver;
            genderText.Location = new Point(113, 328);
            genderText.Multiline = true;
            genderText.Name = "genderText";
            genderText.Size = new Size(343, 35);
            genderText.TabIndex = 43;
            genderText.Text = "성별";
            genderText.Enter += genderText_Enter;
            // 
            // dateText
            // 
            dateText.ForeColor = Color.Silver;
            dateText.Location = new Point(113, 288);
            dateText.Multiline = true;
            dateText.Name = "dateText";
            dateText.Size = new Size(343, 35);
            dateText.TabIndex = 44;
            dateText.Text = "생년월일";
            dateText.Enter += dateText_Enter;
            // 
            // pwText
            // 
            pwText.ForeColor = Color.Silver;
            pwText.Location = new Point(113, 184);
            pwText.Multiline = true;
            pwText.Name = "pwText";
            pwText.Size = new Size(343, 35);
            pwText.TabIndex = 45;
            pwText.Text = "비밀번호";
            pwText.Enter += pwText_Enter;
            // 
            // emailText
            // 
            emailText.ForeColor = Color.Silver;
            emailText.Location = new Point(113, 142);
            emailText.Multiline = true;
            emailText.Name = "emailText";
            emailText.Size = new Size(343, 35);
            emailText.TabIndex = 48;
            emailText.Text = "이메일";
            emailText.Enter += emailText_Enter;
            // 
            // roleText
            // 
            roleText.ForeColor = Color.Silver;
            roleText.Location = new Point(509, 141);
            roleText.Multiline = true;
            roleText.Name = "roleText";
            roleText.Size = new Size(343, 35);
            roleText.TabIndex = 51;
            roleText.Text = "직급";
            roleText.Enter += roleText_Enter;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.ForeColor = Color.Silver;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(509, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(343, 28);
            comboBox1.TabIndex = 61;
            comboBox1.Text = "담당과목";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UserReg
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
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
            Name = "UserReg";
            Size = new Size(966, 520);
            Load += UserReg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButtonStyle regBtn;
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
