namespace DeepCheeseBacon.SourceCode.ApprovalSystem.Forms
{
    partial class RejectForm
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
            label4 = new System.Windows.Forms.Label();
            buttonRejectApproval = new System.Windows.Forms.Button();
            textBoxMemo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(88, 71);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(103, 15);
            label4.TabIndex = 16;
            label4.Text = "반려 시 메모 작성";
            // 
            // buttonRejectApproval
            // 
            buttonRejectApproval.Location = new System.Drawing.Point(88, 147);
            buttonRejectApproval.Name = "buttonRejectApproval";
            buttonRejectApproval.Size = new System.Drawing.Size(75, 23);
            buttonRejectApproval.TabIndex = 15;
            buttonRejectApproval.Text = "반려등록";
            buttonRejectApproval.UseVisualStyleBackColor = true;
            buttonRejectApproval.Click += buttonRejectApproval_Click;
            // 
            // textBoxMemo
            // 
            textBoxMemo.Location = new System.Drawing.Point(88, 106);
            textBoxMemo.Name = "textBoxMemo";
            textBoxMemo.Size = new System.Drawing.Size(163, 23);
            textBoxMemo.TabIndex = 17;
            // 
            // RejectForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBoxMemo);
            Controls.Add(label4);
            Controls.Add(buttonRejectApproval);
            Name = "RejectForm";
            Text = "RejectForm";
            Load += RejectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRejectApproval;
        private System.Windows.Forms.TextBox textBoxMemo;
    }
}