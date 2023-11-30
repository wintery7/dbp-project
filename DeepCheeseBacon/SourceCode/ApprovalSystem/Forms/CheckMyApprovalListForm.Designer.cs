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
            label1 = new Label();
            listBoxMyApprovalProgressList = new ListBox();
            label2 = new Label();
            listBoxPendingApprovalList = new ListBox();
            label3 = new Label();
            listBoxCompletedApprovalList = new ListBox();
            listBoxTaskRequiringMyApprovalList = new ListBox();
            label4 = new Label();
            buttonApproveApproval = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 0;
            label1.Text = "내가 등록한 결재들의 진행 사항";
            // 
            // listBoxMyApprovalProgressList
            // 
            listBoxMyApprovalProgressList.FormattingEnabled = true;
            listBoxMyApprovalProgressList.ItemHeight = 20;
            listBoxMyApprovalProgressList.Location = new Point(94, 101);
            listBoxMyApprovalProgressList.Margin = new Padding(4, 4, 4, 4);
            listBoxMyApprovalProgressList.Name = "listBoxMyApprovalProgressList";
            listBoxMyApprovalProgressList.Size = new Size(387, 124);
            listBoxMyApprovalProgressList.TabIndex = 1;
            listBoxMyApprovalProgressList.SelectedIndexChanged += listBoxMyApprovalProgressList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(548, 77);
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
            listBoxPendingApprovalList.Location = new Point(548, 101);
            listBoxPendingApprovalList.Margin = new Padding(4, 4, 4, 4);
            listBoxPendingApprovalList.Name = "listBoxPendingApprovalList";
            listBoxPendingApprovalList.Size = new Size(372, 124);
            listBoxPendingApprovalList.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 271);
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
            listBoxCompletedApprovalList.Location = new Point(548, 295);
            listBoxCompletedApprovalList.Margin = new Padding(4, 4, 4, 4);
            listBoxCompletedApprovalList.Name = "listBoxCompletedApprovalList";
            listBoxCompletedApprovalList.Size = new Size(372, 124);
            listBoxCompletedApprovalList.TabIndex = 5;
            // 
            // listBoxTaskRequiringMyApprovalList
            // 
            listBoxTaskRequiringMyApprovalList.FormattingEnabled = true;
            listBoxTaskRequiringMyApprovalList.ItemHeight = 20;
            listBoxTaskRequiringMyApprovalList.Location = new Point(94, 295);
            listBoxTaskRequiringMyApprovalList.Margin = new Padding(4, 4, 4, 4);
            listBoxTaskRequiringMyApprovalList.Name = "listBoxTaskRequiringMyApprovalList";
            listBoxTaskRequiringMyApprovalList.Size = new Size(387, 124);
            listBoxTaskRequiringMyApprovalList.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 271);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 20);
            label4.TabIndex = 6;
            label4.Text = "내가 결재해야할 업무 리스트";
            // 
            // buttonApproveApproval
            // 
            buttonApproveApproval.Location = new Point(94, 453);
            buttonApproveApproval.Margin = new Padding(4, 4, 4, 4);
            buttonApproveApproval.Name = "buttonApproveApproval";
            buttonApproveApproval.Size = new Size(96, 31);
            buttonApproveApproval.TabIndex = 8;
            buttonApproveApproval.Text = "결재하기";
            buttonApproveApproval.UseVisualStyleBackColor = true;
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
            Controls.Add(listBoxMyApprovalProgressList);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CheckMyApprovalListForm";
            Text = "CheckMyApprovalListForm";
            Load += CheckMyApprovalListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxMyApprovalProgressList;
        private Label label2;
        private ListBox listBoxPendingApprovalList;
        private Label label3;
        private ListBox listBoxCompletedApprovalList;
        private ListBox listBoxTaskRequiringMyApprovalList;
        private Label label4;
        private Button buttonApproveApproval;
    }
}