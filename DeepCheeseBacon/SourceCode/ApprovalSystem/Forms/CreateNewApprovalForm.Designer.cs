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
            buttonCreateApproval = new Button();
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
            buttonCreateApproval.Location = new System.Drawing.Point(21, 271);
            buttonCreateApproval.Name = "buttonCreateApproval";
            buttonCreateApproval.Size = new System.Drawing.Size(75, 23);
            buttonCreateApproval.TabIndex = 0;
            buttonCreateApproval.Text = "결재 등록";
            buttonCreateApproval.UseVisualStyleBackColor = true;
            buttonCreateApproval.Click += buttonCreateApproval_Click;
            // 
            // textBoxApprovalTitle
            // 
            textBoxApprovalTitle.Location = new System.Drawing.Point(95, 87);
            textBoxApprovalTitle.Name = "textBoxApprovalTitle";
            textBoxApprovalTitle.Size = new System.Drawing.Size(153, 23);
            textBoxApprovalTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "결재 제목";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "관련 업무";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 172);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "결재 내용";
            // 
            // textBoxApprovalDescription
            // 
            textBoxApprovalDescription.Location = new System.Drawing.Point(95, 169);
            textBoxApprovalDescription.Name = "textBoxApprovalDescription";
            textBoxApprovalDescription.Size = new System.Drawing.Size(153, 23);
            textBoxApprovalDescription.TabIndex = 7;
            // 
            // textBoxApprovalRelatedTask
            // 
            textBoxApprovalRelatedTask.Location = new System.Drawing.Point(95, 130);
            textBoxApprovalRelatedTask.Name = "textBoxApprovalRelatedTask";
            textBoxApprovalRelatedTask.Size = new System.Drawing.Size(153, 23);
            textBoxApprovalRelatedTask.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(290, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 15);
            label4.TabIndex = 9;
            label4.Text = "결재자 지정";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 212);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 15);
            label5.TabIndex = 11;
            label5.Text = "결재 코멘트";
            // 
            // textBoxApprovalComment
            // 
            textBoxApprovalComment.Location = new System.Drawing.Point(95, 209);
            textBoxApprovalComment.Name = "textBoxApprovalComment";
            textBoxApprovalComment.Size = new System.Drawing.Size(153, 23);
            textBoxApprovalComment.TabIndex = 12;
            // 
            // comboBoxApproverList
            // 
            comboBoxApproverList.FormattingEnabled = true;
            comboBoxApproverList.Location = new System.Drawing.Point(278, 91);
            comboBoxApproverList.Name = "comboBoxApproverList";
            comboBoxApproverList.Size = new System.Drawing.Size(121, 23);
            comboBoxApproverList.TabIndex = 13;
            // 
            // CreateNewApprovalForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1084, 661);
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
            Name = "CreateNewApprovalForm";
            Text = "CreateNewApprovalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreateApproval;
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
    }
}