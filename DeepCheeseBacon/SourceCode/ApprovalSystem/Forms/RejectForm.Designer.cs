using deepcheesebacon.Work;

namespace deepcheesebacon
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
            label4 = new Label();
            buttonRejectApproval = new CustomButtonStyle();
            textBoxMemo = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 16;
            label4.Text = "반려 시 메모 작성";
            // 
            // buttonRejectApproval
            // 
            buttonRejectApproval.BackColor = Color.FromArgb(94, 159, 242);
            buttonRejectApproval.BackgroundColor = Color.FromArgb(94, 159, 242);
            buttonRejectApproval.BorderColor = Color.PaleVioletRed;
            buttonRejectApproval.BorderRadius = 20;
            buttonRejectApproval.BorderSize = 0;
            buttonRejectApproval.FlatStyle = FlatStyle.Flat;
            buttonRejectApproval.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRejectApproval.ForeColor = Color.White;
            buttonRejectApproval.Location = new Point(412, 221);
            buttonRejectApproval.Margin = new Padding(4);
            buttonRejectApproval.Name = "buttonRejectApproval";
            buttonRejectApproval.Size = new Size(113, 43);
            buttonRejectApproval.TabIndex = 15;
            buttonRejectApproval.Text = "반려등록";
            buttonRejectApproval.TextColor = Color.White;
            buttonRejectApproval.UseVisualStyleBackColor = false;
            buttonRejectApproval.Click += buttonRejectApproval_Click;
            // 
            // textBoxMemo
            // 
            textBoxMemo.Location = new Point(33, 33);
            textBoxMemo.Margin = new Padding(4);
            textBoxMemo.Multiline = true;
            textBoxMemo.Name = "textBoxMemo";
            textBoxMemo.Size = new Size(492, 180);
            textBoxMemo.TabIndex = 17;
            // 
            // RejectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 277);
            Controls.Add(textBoxMemo);
            Controls.Add(label4);
            Controls.Add(buttonRejectApproval);
            Margin = new Padding(4);
            Name = "RejectForm";
            Text = "RejectForm";
            Load += RejectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxMemo;
        private CustomButtonStyle buttonRejectApproval;
    }
}