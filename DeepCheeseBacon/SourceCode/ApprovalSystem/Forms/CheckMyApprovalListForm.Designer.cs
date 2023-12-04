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
            label2 = new Label();
            listBoxPendingApprovalList = new ListBox();
            label3 = new Label();
            listBoxCompletedApprovalList = new ListBox();
            listBoxTaskRequiringMyApprovalList = new ListBox();
            label4 = new Label();
            buttonApproveApproval = new CustomButtonStyle();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(224, 20);
            label2.TabIndex = 2;
            label2.Text = "내가 결재하였고 결재 중인 내역";
            // 
            // listBoxPendingApprovalList
            // 
            listBoxPendingApprovalList.FormattingEnabled = true;
            listBoxPendingApprovalList.ItemHeight = 20;
            listBoxPendingApprovalList.Location = new Point(337, 108);
            listBoxPendingApprovalList.Margin = new Padding(4);
            listBoxPendingApprovalList.Name = "listBoxPendingApprovalList";
            listBoxPendingApprovalList.Size = new Size(270, 464);
            listBoxPendingApprovalList.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 64);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(239, 20);
            label3.TabIndex = 4;
            label3.Text = "내가 결재해줬고 결재 완료된 내역";
            label3.Click += label3_Click;
            // 
            // listBoxCompletedApprovalList
            // 
            listBoxCompletedApprovalList.FormattingEnabled = true;
            listBoxCompletedApprovalList.ItemHeight = 20;
            listBoxCompletedApprovalList.Location = new Point(34, 108);
            listBoxCompletedApprovalList.Margin = new Padding(4);
            listBoxCompletedApprovalList.Name = "listBoxCompletedApprovalList";
            listBoxCompletedApprovalList.Size = new Size(270, 464);
            listBoxCompletedApprovalList.TabIndex = 5;
            // 
            // listBoxTaskRequiringMyApprovalList
            // 
            listBoxTaskRequiringMyApprovalList.FormattingEnabled = true;
            listBoxTaskRequiringMyApprovalList.ItemHeight = 20;
            listBoxTaskRequiringMyApprovalList.Location = new Point(643, 108);
            listBoxTaskRequiringMyApprovalList.Margin = new Padding(4);
            listBoxTaskRequiringMyApprovalList.Name = "listBoxTaskRequiringMyApprovalList";
            listBoxTaskRequiringMyApprovalList.Size = new Size(270, 384);
            listBoxTaskRequiringMyApprovalList.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(643, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 20);
            label4.TabIndex = 6;
            label4.Text = "내가 결재해야할 업무 리스트";
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
            buttonApproveApproval.Location = new Point(720, 522);
            buttonApproveApproval.Margin = new Padding(4);
            buttonApproveApproval.Name = "buttonApproveApproval";
            buttonApproveApproval.Size = new Size(127, 50);
            buttonApproveApproval.TabIndex = 8;
            buttonApproveApproval.Text = "결재하기";
            buttonApproveApproval.TextColor = Color.DarkBlue;
            buttonApproveApproval.UseVisualStyleBackColor = false;
            buttonApproveApproval.Click += buttonApproveApproval_Click;
            // 
            // CheckMyApprovalListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 616);
            Controls.Add(buttonApproveApproval);
            Controls.Add(listBoxTaskRequiringMyApprovalList);
            Controls.Add(label4);
            Controls.Add(listBoxCompletedApprovalList);
            Controls.Add(label3);
            Controls.Add(listBoxPendingApprovalList);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "CheckMyApprovalListForm";
            Text = "CheckMyApprovalListForm";
            Load += CheckMyApprovalListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ListBox listBoxPendingApprovalList;
        private Label label3;
        private ListBox listBoxCompletedApprovalList;
        private ListBox listBoxTaskRequiringMyApprovalList;
        private Label label4;
        private CustomButtonStyle buttonApproveApproval;
    }
}