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
            label1 = new System.Windows.Forms.Label();
            listBoxMyApprovalProgressList = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            listBoxPendingApprovalList = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            listBoxCompletedApprovalList = new System.Windows.Forms.ListBox();
            listBoxTaskRequiringMyApprovalList = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            buttonApproveApproval = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(73, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 15);
            label1.TabIndex = 0;
            label1.Text = "내가 등록한 결재들의 진행 사항";
            // 
            // listBoxMyApprovalProgressList
            // 
            listBoxMyApprovalProgressList.FormattingEnabled = true;
            listBoxMyApprovalProgressList.ItemHeight = 15;
            listBoxMyApprovalProgressList.Location = new System.Drawing.Point(73, 76);
            listBoxMyApprovalProgressList.Name = "listBoxMyApprovalProgressList";
            listBoxMyApprovalProgressList.Size = new System.Drawing.Size(302, 94);
            listBoxMyApprovalProgressList.TabIndex = 1;
            listBoxMyApprovalProgressList.SelectedIndexChanged += listBoxMyApprovalProgressList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(426, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 15);
            label2.TabIndex = 2;
            label2.Text = "내가 결재하였고 결재 중인 내역";
            // 
            // listBoxPendingApprovalList
            // 
            listBoxPendingApprovalList.FormattingEnabled = true;
            listBoxPendingApprovalList.ItemHeight = 15;
            listBoxPendingApprovalList.Location = new System.Drawing.Point(426, 76);
            listBoxPendingApprovalList.Name = "listBoxPendingApprovalList";
            listBoxPendingApprovalList.Size = new System.Drawing.Size(290, 94);
            listBoxPendingApprovalList.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(426, 203);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(191, 15);
            label3.TabIndex = 4;
            label3.Text = "내가 결재해줬고 결재 완료된 내역";
            label3.Click += label3_Click;
            // 
            // listBoxCompletedApprovalList
            // 
            listBoxCompletedApprovalList.FormattingEnabled = true;
            listBoxCompletedApprovalList.ItemHeight = 15;
            listBoxCompletedApprovalList.Location = new System.Drawing.Point(426, 221);
            listBoxCompletedApprovalList.Name = "listBoxCompletedApprovalList";
            listBoxCompletedApprovalList.Size = new System.Drawing.Size(290, 94);
            listBoxCompletedApprovalList.TabIndex = 5;
            // 
            // listBoxTaskRequiringMyApprovalList
            // 
            listBoxTaskRequiringMyApprovalList.FormattingEnabled = true;
            listBoxTaskRequiringMyApprovalList.ItemHeight = 15;
            listBoxTaskRequiringMyApprovalList.Location = new System.Drawing.Point(73, 221);
            listBoxTaskRequiringMyApprovalList.Name = "listBoxTaskRequiringMyApprovalList";
            listBoxTaskRequiringMyApprovalList.Size = new System.Drawing.Size(302, 94);
            listBoxTaskRequiringMyApprovalList.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(73, 203);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(163, 15);
            label4.TabIndex = 6;
            label4.Text = "내가 결재해야할 업무 리스트";
            // 
            // buttonApproveApproval
            // 
            buttonApproveApproval.Location = new System.Drawing.Point(73, 340);
            buttonApproveApproval.Name = "buttonApproveApproval";
            buttonApproveApproval.Size = new System.Drawing.Size(75, 23);
            buttonApproveApproval.TabIndex = 8;
            buttonApproveApproval.Text = "결재하기";
            buttonApproveApproval.UseVisualStyleBackColor = true;
            buttonApproveApproval.Click += buttonApproveApproval_Click;
            // 
            // CheckMyApprovalListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1084, 661);
            Controls.Add(buttonApproveApproval);
            Controls.Add(listBoxTaskRequiringMyApprovalList);
            Controls.Add(label4);
            Controls.Add(listBoxCompletedApprovalList);
            Controls.Add(label3);
            Controls.Add(listBoxPendingApprovalList);
            Controls.Add(label2);
            Controls.Add(listBoxMyApprovalProgressList);
            Controls.Add(label1);
            Name = "CheckMyApprovalListForm";
            Text = "CheckMyApprovalListForm";
            Load += CheckMyApprovalListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMyApprovalProgressList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPendingApprovalList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCompletedApprovalList;
        private System.Windows.Forms.ListBox listBoxTaskRequiringMyApprovalList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonApproveApproval;
    }
}