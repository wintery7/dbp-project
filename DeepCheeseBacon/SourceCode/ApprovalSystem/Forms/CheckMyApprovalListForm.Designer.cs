using deepcheesebacon.Customizing;

namespace deepcheesebacon
{
    partial class CheckMyApprovalListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPendingApprovalList = new ListBox();
            listBoxCompletedApprovalList = new ListBox();
            listBoxTaskRequiringMyApprovalList = new ListBox();
            buttonApproveApproval = new CustomButtonStyle();
            customGroupBox2 = new CustomGroupBox();
            customGroupBox1 = new CustomGroupBox();
            customGroupBox3 = new CustomGroupBox();
            customGroupBox2.SuspendLayout();
            customGroupBox1.SuspendLayout();
            customGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPendingApprovalList
            // 
            listBoxPendingApprovalList.FormattingEnabled = true;
            listBoxPendingApprovalList.ItemHeight = 20;
            listBoxPendingApprovalList.Location = new Point(8, 48);
            listBoxPendingApprovalList.Margin = new Padding(4);
            listBoxPendingApprovalList.Name = "listBoxPendingApprovalList";
            listBoxPendingApprovalList.Size = new Size(275, 464);
            listBoxPendingApprovalList.TabIndex = 3;
            // 
            // listBoxCompletedApprovalList
            // 
            listBoxCompletedApprovalList.FormattingEnabled = true;
            listBoxCompletedApprovalList.ItemHeight = 20;
            listBoxCompletedApprovalList.Location = new Point(8, 48);
            listBoxCompletedApprovalList.Margin = new Padding(4);
            listBoxCompletedApprovalList.Name = "listBoxCompletedApprovalList";
            listBoxCompletedApprovalList.Size = new Size(275, 464);
            listBoxCompletedApprovalList.TabIndex = 5;
            // 
            // listBoxTaskRequiringMyApprovalList
            // 
            listBoxTaskRequiringMyApprovalList.FormattingEnabled = true;
            listBoxTaskRequiringMyApprovalList.ItemHeight = 20;
            listBoxTaskRequiringMyApprovalList.Location = new Point(8, 51);
            listBoxTaskRequiringMyApprovalList.Margin = new Padding(4);
            listBoxTaskRequiringMyApprovalList.Name = "listBoxTaskRequiringMyApprovalList";
            listBoxTaskRequiringMyApprovalList.Size = new Size(275, 404);
            listBoxTaskRequiringMyApprovalList.TabIndex = 7;
            // 
            // buttonApproveApproval
            // 
            buttonApproveApproval.BackColor = SystemColors.Window;
            buttonApproveApproval.BackgroundColor = SystemColors.Window;
            buttonApproveApproval.BorderColor = Color.FromArgb(4, 96, 217);
            buttonApproveApproval.BorderRadius = 10;
            buttonApproveApproval.BorderSize = 2;
            buttonApproveApproval.FlatStyle = FlatStyle.Flat;
            buttonApproveApproval.ForeColor = Color.DarkBlue;
            buttonApproveApproval.Location = new Point(80, 462);
            buttonApproveApproval.Margin = new Padding(4);
            buttonApproveApproval.Name = "buttonApproveApproval";
            buttonApproveApproval.Size = new Size(127, 50);
            buttonApproveApproval.TabIndex = 8;
            buttonApproveApproval.Text = "결재하기";
            buttonApproveApproval.TextColor = Color.DarkBlue;
            buttonApproveApproval.UseVisualStyleBackColor = false;
            buttonApproveApproval.Click += buttonApproveApproval_Click;
            // 
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(listBoxCompletedApprovalList);
            customGroupBox2.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customGroupBox2.Location = new Point(13, 64);
            customGroupBox2.Margin = new Padding(4);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(4);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(291, 520);
            customGroupBox2.TabIndex = 32;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "결재 완료된 결재내역";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // customGroupBox1
            // 
            customGroupBox1.BackColor = Color.Transparent;
            customGroupBox1.Controls.Add(listBoxPendingApprovalList);
            customGroupBox1.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customGroupBox1.Location = new Point(331, 64);
            customGroupBox1.Margin = new Padding(4);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Padding = new Padding(4);
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(291, 520);
            customGroupBox1.TabIndex = 33;
            customGroupBox1.TabStop = false;
            customGroupBox1.Text = "결재 중인 결재내역";
            customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox1.TitleFont = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox1.TitleForeColor = Color.White;
            customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // customGroupBox3
            // 
            customGroupBox3.BackColor = Color.Transparent;
            customGroupBox3.Controls.Add(listBoxTaskRequiringMyApprovalList);
            customGroupBox3.Controls.Add(buttonApproveApproval);
            customGroupBox3.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customGroupBox3.Location = new Point(647, 64);
            customGroupBox3.Margin = new Padding(4);
            customGroupBox3.Name = "customGroupBox3";
            customGroupBox3.Padding = new Padding(4);
            customGroupBox3.Radious = 25;
            customGroupBox3.Size = new Size(291, 520);
            customGroupBox3.TabIndex = 34;
            customGroupBox3.TabStop = false;
            customGroupBox3.Text = "결재해야 할 업무";
            customGroupBox3.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox3.TitleFont = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox3.TitleForeColor = Color.White;
            customGroupBox3.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // CheckMyApprovalListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 616);
            Controls.Add(customGroupBox3);
            Controls.Add(customGroupBox1);
            Controls.Add(customGroupBox2);
            Margin = new Padding(4);
            Name = "CheckMyApprovalListForm";
            Text = "CheckMyApprovalListForm";
            Load += CheckMyApprovalListForm_Load;
            customGroupBox2.ResumeLayout(false);
            customGroupBox1.ResumeLayout(false);
            customGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxPendingApprovalList;
        private ListBox listBoxCompletedApprovalList;
        private ListBox listBoxTaskRequiringMyApprovalList;
        private CustomButtonStyle buttonApproveApproval;
        private CustomGroupBox customGroupBox2;
        private CustomGroupBox customGroupBox1;
        private CustomGroupBox customGroupBox3;
    }
}