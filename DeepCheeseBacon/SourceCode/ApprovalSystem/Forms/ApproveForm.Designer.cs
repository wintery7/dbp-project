namespace deepcheesebacon
{
    partial class ApproveForm
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
            buttonRejectApproval = new System.Windows.Forms.Button();
            buttonApproveApproval = new System.Windows.Forms.Button();
            listBoxTaskRequiringMyApprovalList = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            labelDateTime = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonRejectApproval
            // 
            buttonRejectApproval.Location = new System.Drawing.Point(160, 190);
            buttonRejectApproval.Name = "buttonRejectApproval";
            buttonRejectApproval.Size = new System.Drawing.Size(75, 23);
            buttonRejectApproval.TabIndex = 11;
            buttonRejectApproval.Text = "반려";
            buttonRejectApproval.UseVisualStyleBackColor = true;
            buttonRejectApproval.Click += buttonRejectApproval_Click;
            // 
            // buttonApproveApproval
            // 
            buttonApproveApproval.Location = new System.Drawing.Point(72, 190);
            buttonApproveApproval.Name = "buttonApproveApproval";
            buttonApproveApproval.Size = new System.Drawing.Size(75, 23);
            buttonApproveApproval.TabIndex = 10;
            buttonApproveApproval.Text = "결재";
            buttonApproveApproval.UseVisualStyleBackColor = true;
            buttonApproveApproval.Click += buttonApproveApproval_Click;
            // 
            // listBoxTaskRequiringMyApprovalList
            // 
            listBoxTaskRequiringMyApprovalList.FormattingEnabled = true;
            listBoxTaskRequiringMyApprovalList.ItemHeight = 15;
            listBoxTaskRequiringMyApprovalList.Location = new System.Drawing.Point(72, 90);
            listBoxTaskRequiringMyApprovalList.Name = "listBoxTaskRequiringMyApprovalList";
            listBoxTaskRequiringMyApprovalList.Size = new System.Drawing.Size(179, 94);
            listBoxTaskRequiringMyApprovalList.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(72, 72);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(163, 15);
            label4.TabIndex = 12;
            label4.Text = "내가 결재해야할 업무 리스트";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Location = new System.Drawing.Point(72, 234);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new System.Drawing.Size(66, 15);
            labelDateTime.TabIndex = 14;
            labelDateTime.Text = "결재 시각: ";
            // 
            // ApproveForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(labelDateTime);
            Controls.Add(listBoxTaskRequiringMyApprovalList);
            Controls.Add(label4);
            Controls.Add(buttonRejectApproval);
            Controls.Add(buttonApproveApproval);
            Name = "ApproveForm";
            Text = "ApproveForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonRejectApproval;
        private System.Windows.Forms.Button buttonApproveApproval;
        private System.Windows.Forms.ListBox listBoxTaskRequiringMyApprovalList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDateTime;
    }
}