using deepcheesebacon.Customizing;

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
            buttonRejectApproval = new CustomButtonStyle();
            textBoxMemo = new CustomTextBox();
            SuspendLayout();
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
            textBoxMemo.BackColor = SystemColors.Window;
            textBoxMemo.BorderColor = Color.FromArgb(94, 159, 242);
            textBoxMemo.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxMemo.BorderRadius = 0;
            textBoxMemo.BorderSize = 2;
            textBoxMemo.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMemo.ForeColor = Color.DimGray;
            textBoxMemo.Location = new Point(41, 40);
            textBoxMemo.Multiline = true;
            textBoxMemo.Name = "textBoxMemo";
            textBoxMemo.Padding = new Padding(10, 7, 10, 7);
            textBoxMemo.PasswordChar = false;
            textBoxMemo.PlaceholderColor = Color.DarkGray;
            textBoxMemo.PlaceholderText = "반려 사유를 작성해주세요.";
            textBoxMemo.Size = new Size(484, 163);
            textBoxMemo.TabIndex = 18;
            textBoxMemo.Texts = "";
            textBoxMemo.UnderlinedStyle = false;
            // 
            // RejectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 277);
            Controls.Add(textBoxMemo);
            Controls.Add(buttonRejectApproval);
            Margin = new Padding(4);
            Name = "RejectForm";
            Text = "RejectForm";
            Load += RejectForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private CustomTextBox textBoxMemo;
        private CustomButtonStyle buttonRejectApproval;
    }
}