using deepcheesebacon.Customizing;
using System.Windows.Forms;

namespace deepcheesebacon
{
    partial class CreateNewApprovalForm
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
            buttonCreateApproval = new CustomButtonStyle();
            label4 = new Label();
            comboBoxApproverList = new CustomComboBox();
            textBoxApprovalTitle = new CustomTextBox();
            textBoxApprovalDescription = new CustomTextBox();
            textBoxApprovalComment = new CustomTextBox();
            textBoxApprovalRelatedTask = new CustomTextBox();
            SuspendLayout();
            // 
            // buttonCreateApproval
            // 
            buttonCreateApproval.BackColor = Color.FromArgb(94, 159, 242);
            buttonCreateApproval.BackgroundColor = Color.FromArgb(94, 159, 242);
            buttonCreateApproval.BorderColor = Color.PaleVioletRed;
            buttonCreateApproval.BorderRadius = 20;
            buttonCreateApproval.BorderSize = 0;
            buttonCreateApproval.FlatStyle = FlatStyle.Flat;
            buttonCreateApproval.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreateApproval.ForeColor = Color.White;
            buttonCreateApproval.Location = new Point(770, 535);
            buttonCreateApproval.Margin = new Padding(4);
            buttonCreateApproval.Name = "buttonCreateApproval";
            buttonCreateApproval.Size = new Size(134, 44);
            buttonCreateApproval.TabIndex = 0;
            buttonCreateApproval.Text = "결재 등록";
            buttonCreateApproval.TextColor = Color.White;
            buttonCreateApproval.UseVisualStyleBackColor = false;
            buttonCreateApproval.Click += buttonCreateApproval_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 550);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 9;
            label4.Text = "결재자 지정";
            // 
            // comboBoxApproverList
            // 
            comboBoxApproverList.BackColor = Color.FromArgb(94, 159, 242);
            comboBoxApproverList.BorderColor = Color.FromArgb(242, 242, 242);
            comboBoxApproverList.BorderSize = 1;
            comboBoxApproverList.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxApproverList.ForeColor = Color.DimGray;
            comboBoxApproverList.FormattingEnabled = true;
            comboBoxApproverList.IconColor = Color.White;
            comboBoxApproverList.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxApproverList.ListTextColor = Color.DimGray;
            comboBoxApproverList.Location = new Point(146, 547);
            comboBoxApproverList.Margin = new Padding(4);
            comboBoxApproverList.MinimumSize = new Size(170, 0);
            comboBoxApproverList.Name = "comboBoxApproverList";
            comboBoxApproverList.Size = new Size(170, 31);
            comboBoxApproverList.TabIndex = 13;
            comboBoxApproverList.Texts = "";
            // 
            // textBoxApprovalTitle
            // 
            textBoxApprovalTitle.BackColor = SystemColors.Window;
            textBoxApprovalTitle.BorderColor = Color.FromArgb(94, 159, 242);
            textBoxApprovalTitle.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxApprovalTitle.BorderRadius = 0;
            textBoxApprovalTitle.BorderSize = 2;
            textBoxApprovalTitle.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApprovalTitle.ForeColor = Color.DimGray;
            textBoxApprovalTitle.Location = new Point(49, 38);
            textBoxApprovalTitle.Multiline = false;
            textBoxApprovalTitle.Name = "textBoxApprovalTitle";
            textBoxApprovalTitle.Padding = new Padding(10, 7, 10, 7);
            textBoxApprovalTitle.PasswordChar = false;
            textBoxApprovalTitle.PlaceholderColor = Color.DarkGray;
            textBoxApprovalTitle.PlaceholderText = "제목을 입력해주세요.";
            textBoxApprovalTitle.Size = new Size(855, 36);
            textBoxApprovalTitle.TabIndex = 14;
            textBoxApprovalTitle.Texts = "";
            textBoxApprovalTitle.UnderlinedStyle = true;
            // 
            // textBoxApprovalDescription
            // 
            textBoxApprovalDescription.BackColor = SystemColors.Window;
            textBoxApprovalDescription.BorderColor = Color.FromArgb(94, 159, 242);
            textBoxApprovalDescription.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxApprovalDescription.BorderRadius = 0;
            textBoxApprovalDescription.BorderSize = 2;
            textBoxApprovalDescription.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApprovalDescription.ForeColor = Color.DimGray;
            textBoxApprovalDescription.Location = new Point(49, 95);
            textBoxApprovalDescription.Multiline = true;
            textBoxApprovalDescription.Name = "textBoxApprovalDescription";
            textBoxApprovalDescription.Padding = new Padding(10, 7, 10, 7);
            textBoxApprovalDescription.PasswordChar = false;
            textBoxApprovalDescription.PlaceholderColor = Color.DarkGray;
            textBoxApprovalDescription.PlaceholderText = "내용을 입력하세요.";
            textBoxApprovalDescription.Size = new Size(855, 330);
            textBoxApprovalDescription.TabIndex = 15;
            textBoxApprovalDescription.Texts = "";
            textBoxApprovalDescription.UnderlinedStyle = false;
            // 
            // textBoxApprovalComment
            // 
            textBoxApprovalComment.BackColor = SystemColors.Window;
            textBoxApprovalComment.BorderColor = Color.FromArgb(94, 159, 242);
            textBoxApprovalComment.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxApprovalComment.BorderRadius = 0;
            textBoxApprovalComment.BorderSize = 2;
            textBoxApprovalComment.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApprovalComment.ForeColor = Color.DimGray;
            textBoxApprovalComment.Location = new Point(49, 444);
            textBoxApprovalComment.Multiline = true;
            textBoxApprovalComment.Name = "textBoxApprovalComment";
            textBoxApprovalComment.Padding = new Padding(10, 7, 10, 7);
            textBoxApprovalComment.PasswordChar = false;
            textBoxApprovalComment.PlaceholderColor = Color.DarkGray;
            textBoxApprovalComment.PlaceholderText = "코멘트를 남겨보세요!";
            textBoxApprovalComment.Size = new Size(855, 84);
            textBoxApprovalComment.TabIndex = 16;
            textBoxApprovalComment.Texts = "";
            textBoxApprovalComment.UnderlinedStyle = false;
            // 
            // textBoxApprovalRelatedTask
            // 
            textBoxApprovalRelatedTask.BackColor = SystemColors.Window;
            textBoxApprovalRelatedTask.BorderColor = Color.FromArgb(94, 159, 242);
            textBoxApprovalRelatedTask.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxApprovalRelatedTask.BorderRadius = 0;
            textBoxApprovalRelatedTask.BorderSize = 2;
            textBoxApprovalRelatedTask.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApprovalRelatedTask.ForeColor = Color.DimGray;
            textBoxApprovalRelatedTask.Location = new Point(374, 542);
            textBoxApprovalRelatedTask.Multiline = false;
            textBoxApprovalRelatedTask.Name = "textBoxApprovalRelatedTask";
            textBoxApprovalRelatedTask.Padding = new Padding(10, 7, 10, 7);
            textBoxApprovalRelatedTask.PasswordChar = false;
            textBoxApprovalRelatedTask.PlaceholderColor = Color.DarkGray;
            textBoxApprovalRelatedTask.PlaceholderText = "관련 업무를 작성하세요.";
            textBoxApprovalRelatedTask.Size = new Size(312, 36);
            textBoxApprovalRelatedTask.TabIndex = 17;
            textBoxApprovalRelatedTask.Texts = "";
            textBoxApprovalRelatedTask.UnderlinedStyle = true;
            // 
            // CreateNewApprovalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 616);
            Controls.Add(textBoxApprovalRelatedTask);
            Controls.Add(textBoxApprovalComment);
            Controls.Add(textBoxApprovalDescription);
            Controls.Add(textBoxApprovalTitle);
            Controls.Add(comboBoxApproverList);
            Controls.Add(label4);
            Controls.Add(buttonCreateApproval);
            Margin = new Padding(4);
            Name = "CreateNewApprovalForm";
            Text = "CreateNewApprovalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private CustomButtonStyle buttonCreateApproval;
        private CustomComboBox comboBoxApproverList;
        private CustomTextBox textBoxApprovalTitle;
        private CustomTextBox textBoxApprovalDescription;
        private CustomTextBox textBoxApprovalComment;
        private CustomTextBox textBoxApprovalRelatedTask;
    }
}