using deepcheesebacon.Work;
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
            textBoxApprovalTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxApprovalDescription = new TextBox();
            textBoxApprovalRelatedTask = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxApprovalComment = new TextBox();
            comboBoxApproverList = new ComboBox();
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
            // textBoxApprovalTitle
            // 
            textBoxApprovalTitle.Location = new Point(49, 51);
            textBoxApprovalTitle.Margin = new Padding(4);
            textBoxApprovalTitle.Name = "textBoxApprovalTitle";
            textBoxApprovalTitle.Size = new Size(855, 27);
            textBoxApprovalTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "결재 제목";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 550);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "관련 업무";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 95);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "결재 내용";
            // 
            // textBoxApprovalDescription
            // 
            textBoxApprovalDescription.Location = new Point(49, 119);
            textBoxApprovalDescription.Margin = new Padding(4);
            textBoxApprovalDescription.Multiline = true;
            textBoxApprovalDescription.Name = "textBoxApprovalDescription";
            textBoxApprovalDescription.Size = new Size(855, 289);
            textBoxApprovalDescription.TabIndex = 7;
            // 
            // textBoxApprovalRelatedTask
            // 
            textBoxApprovalRelatedTask.Location = new Point(421, 548);
            textBoxApprovalRelatedTask.Margin = new Padding(4);
            textBoxApprovalRelatedTask.Name = "textBoxApprovalRelatedTask";
            textBoxApprovalRelatedTask.Size = new Size(251, 27);
            textBoxApprovalRelatedTask.TabIndex = 8;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 412);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 11;
            label5.Text = "결재 코멘트";
            // 
            // textBoxApprovalComment
            // 
            textBoxApprovalComment.Location = new Point(49, 436);
            textBoxApprovalComment.Margin = new Padding(4);
            textBoxApprovalComment.Multiline = true;
            textBoxApprovalComment.Name = "textBoxApprovalComment";
            textBoxApprovalComment.Size = new Size(855, 81);
            textBoxApprovalComment.TabIndex = 12;
            // 
            // comboBoxApproverList
            // 
            comboBoxApproverList.FormattingEnabled = true;
            comboBoxApproverList.Location = new Point(146, 547);
            comboBoxApproverList.Margin = new Padding(4);
            comboBoxApproverList.Name = "comboBoxApproverList";
            comboBoxApproverList.Size = new Size(154, 28);
            comboBoxApproverList.TabIndex = 13;
            // 
            // CreateNewApprovalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 616);
            Controls.Add(comboBoxApproverList);
            Controls.Add(textBoxApprovalComment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxApprovalRelatedTask);
            Controls.Add(textBoxApprovalDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxApprovalTitle);
            Controls.Add(buttonCreateApproval);
            Margin = new Padding(4);
            Name = "CreateNewApprovalForm";
            Text = "CreateNewApprovalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxApprovalTitle;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxApprovalDescription;
        private TextBox textBox2;
        private TextBox textBoxApprovalRelatedTask;
        private Label label4;
        private Label label5;
        private TextBox textBoxApprovalComment;
        private ComboBox comboBoxApproverList;
        private CustomButtonStyle buttonCreateApproval;
    }
}