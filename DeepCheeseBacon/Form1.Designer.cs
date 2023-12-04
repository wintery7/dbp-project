namespace deepcheesebacon
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pMain = new Panel();
            panelMenu = new Panel();
            AttendancelogBtn = new Button();
            AttendRegBtn = new Button();
            SalaryBtn = new Button();
            SubjectManageBtn = new Button();
            UserManageBtn = new Button();
            UserRegBtn = new Button();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.BackColor = Color.FromArgb(242, 242, 242);
            pMain.Location = new Point(228, 0);
            pMain.Margin = new Padding(3, 4, 3, 4);
            pMain.Name = "pMain";
            pMain.Size = new Size(977, 816);
            pMain.TabIndex = 9;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(94, 159, 242);
            panelMenu.Controls.Add(AttendancelogBtn);
            panelMenu.Controls.Add(AttendRegBtn);
            panelMenu.Controls.Add(SalaryBtn);
            panelMenu.Controls.Add(SubjectManageBtn);
            panelMenu.Controls.Add(UserManageBtn);
            panelMenu.Controls.Add(UserRegBtn);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ControlText;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(229, 816);
            panelMenu.TabIndex = 8;
            // 
            // AttendancelogBtn
            // 
            AttendancelogBtn.Dock = DockStyle.Top;
            AttendancelogBtn.FlatAppearance.BorderSize = 0;
            AttendancelogBtn.FlatStyle = FlatStyle.Flat;
            AttendancelogBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AttendancelogBtn.ForeColor = SystemColors.HighlightText;
            AttendancelogBtn.Location = new Point(0, 705);
            AttendancelogBtn.Margin = new Padding(3, 4, 3, 4);
            AttendancelogBtn.Name = "AttendancelogBtn";
            AttendancelogBtn.Size = new Size(229, 108);
            AttendancelogBtn.TabIndex = 15;
            AttendancelogBtn.Text = "출퇴근";
            AttendancelogBtn.UseVisualStyleBackColor = true;
            AttendancelogBtn.Click += AttendancelogBtn_Click;
            // 
            // AttendRegBtn
            // 
            AttendRegBtn.Dock = DockStyle.Top;
            AttendRegBtn.FlatAppearance.BorderSize = 0;
            AttendRegBtn.FlatStyle = FlatStyle.Flat;
            AttendRegBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AttendRegBtn.ForeColor = SystemColors.HighlightText;
            AttendRegBtn.Location = new Point(0, 597);
            AttendRegBtn.Margin = new Padding(3, 4, 3, 4);
            AttendRegBtn.Name = "AttendRegBtn";
            AttendRegBtn.Size = new Size(229, 108);
            AttendRegBtn.TabIndex = 0;
            AttendRegBtn.Text = "사원 출근부";
            AttendRegBtn.UseVisualStyleBackColor = true;
            AttendRegBtn.Click += AttendRegBtn_Click;
            // 
            // SalaryBtn
            // 
            SalaryBtn.Dock = DockStyle.Top;
            SalaryBtn.FlatAppearance.BorderSize = 0;
            SalaryBtn.FlatStyle = FlatStyle.Flat;
            SalaryBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            SalaryBtn.ForeColor = SystemColors.HighlightText;
            SalaryBtn.Location = new Point(0, 489);
            SalaryBtn.Margin = new Padding(3, 4, 3, 4);
            SalaryBtn.Name = "SalaryBtn";
            SalaryBtn.Size = new Size(229, 108);
            SalaryBtn.TabIndex = 13;
            SalaryBtn.Text = "급여내역서";
            SalaryBtn.UseVisualStyleBackColor = true;
            SalaryBtn.Click += SalaryBtn_Click;
            // 
            // SubjectManageBtn
            // 
            SubjectManageBtn.Dock = DockStyle.Top;
            SubjectManageBtn.FlatAppearance.BorderSize = 0;
            SubjectManageBtn.FlatStyle = FlatStyle.Flat;
            SubjectManageBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            SubjectManageBtn.ForeColor = SystemColors.HighlightText;
            SubjectManageBtn.Location = new Point(0, 381);
            SubjectManageBtn.Margin = new Padding(3, 4, 3, 4);
            SubjectManageBtn.Name = "SubjectManageBtn";
            SubjectManageBtn.Size = new Size(229, 108);
            SubjectManageBtn.TabIndex = 10;
            SubjectManageBtn.Text = "과목관리";
            SubjectManageBtn.UseVisualStyleBackColor = true;
            SubjectManageBtn.Click += SubjectManageBtn_Click;
            // 
            // UserManageBtn
            // 
            UserManageBtn.Dock = DockStyle.Top;
            UserManageBtn.FlatAppearance.BorderSize = 0;
            UserManageBtn.FlatStyle = FlatStyle.Flat;
            UserManageBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            UserManageBtn.ForeColor = SystemColors.HighlightText;
            UserManageBtn.Location = new Point(0, 273);
            UserManageBtn.Margin = new Padding(3, 4, 3, 4);
            UserManageBtn.Name = "UserManageBtn";
            UserManageBtn.Size = new Size(229, 108);
            UserManageBtn.TabIndex = 9;
            UserManageBtn.Text = "사원관리";
            UserManageBtn.UseVisualStyleBackColor = true;
            UserManageBtn.Click += UserManageBtn_Click;
            // 
            // UserRegBtn
            // 
            UserRegBtn.Dock = DockStyle.Top;
            UserRegBtn.FlatAppearance.BorderSize = 0;
            UserRegBtn.FlatStyle = FlatStyle.Flat;
            UserRegBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            UserRegBtn.ForeColor = SystemColors.HighlightText;
            UserRegBtn.Location = new Point(0, 165);
            UserRegBtn.Margin = new Padding(3, 4, 3, 4);
            UserRegBtn.Name = "UserRegBtn";
            UserRegBtn.Size = new Size(229, 108);
            UserRegBtn.TabIndex = 8;
            UserRegBtn.Text = "사원등록";
            UserRegBtn.UseVisualStyleBackColor = true;
            UserRegBtn.Click += UserRegBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(94, 159, 242);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(229, 165);
            panelLogo.TabIndex = 0;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 816);
            Controls.Add(pMain);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "form";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pMain;
        private Panel panelMenu;
        private Button AttendRegBtn;
        private Button SalaryBtn;
        private Button SubjectManageBtn;
        private Button UserManageBtn;
        private Button UserRegBtn;
        private Panel panelLogo;
        private Button AttendancelogBtn;
    }
}
