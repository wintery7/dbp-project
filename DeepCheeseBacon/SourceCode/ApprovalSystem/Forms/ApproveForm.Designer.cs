using deepcheesebacon.Customizing;

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
            buttonRejectApproval = new CustomButtonStyle();
            buttonApproveApproval = new CustomButtonStyle();
            listBoxTaskRequiringMyApprovalList = new ListBox();
            labelDateTime = new Label();
            customGroupBox1 = new CustomGroupBox();
            customGroupBox2 = new CustomGroupBox();
            customGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRejectApproval
            // 
            buttonRejectApproval.BackColor = Color.FromArgb(94, 159, 242);
            buttonRejectApproval.BackgroundColor = Color.FromArgb(94, 159, 242);
            buttonRejectApproval.BorderColor = Color.FromArgb(4, 96, 217);
            buttonRejectApproval.BorderRadius = 10;
            buttonRejectApproval.BorderSize = 0;
            buttonRejectApproval.FlatStyle = FlatStyle.Flat;
            buttonRejectApproval.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRejectApproval.ForeColor = Color.White;
            buttonRejectApproval.Location = new Point(731, 547);
            buttonRejectApproval.Margin = new Padding(4);
            buttonRejectApproval.Name = "buttonRejectApproval";
            buttonRejectApproval.Size = new Size(96, 35);
            buttonRejectApproval.TabIndex = 11;
            buttonRejectApproval.Text = "반려";
            buttonRejectApproval.TextColor = Color.White;
            buttonRejectApproval.UseVisualStyleBackColor = false;
            buttonRejectApproval.Click += buttonRejectApproval_Click;
            // 
            // buttonApproveApproval
            // 
            buttonApproveApproval.BackColor = Color.FromArgb(94, 159, 242);
            buttonApproveApproval.BackgroundColor = Color.FromArgb(94, 159, 242);
            buttonApproveApproval.BorderColor = Color.FromArgb(4, 96, 217);
            buttonApproveApproval.BorderRadius = 10;
            buttonApproveApproval.BorderSize = 0;
            buttonApproveApproval.FlatStyle = FlatStyle.Flat;
            buttonApproveApproval.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApproveApproval.ForeColor = Color.White;
            buttonApproveApproval.Location = new Point(617, 547);
            buttonApproveApproval.Margin = new Padding(4);
            buttonApproveApproval.Name = "buttonApproveApproval";
            buttonApproveApproval.Size = new Size(96, 35);
            buttonApproveApproval.TabIndex = 10;
            buttonApproveApproval.Text = "결재";
            buttonApproveApproval.TextColor = Color.White;
            buttonApproveApproval.UseVisualStyleBackColor = false;
            buttonApproveApproval.Click += buttonApproveApproval_Click;
            // 
            // listBoxTaskRequiringMyApprovalList
            // 
            listBoxTaskRequiringMyApprovalList.FormattingEnabled = true;
            listBoxTaskRequiringMyApprovalList.ItemHeight = 20;
            listBoxTaskRequiringMyApprovalList.Location = new Point(8, 48);
            listBoxTaskRequiringMyApprovalList.Margin = new Padding(4);
            listBoxTaskRequiringMyApprovalList.Name = "listBoxTaskRequiringMyApprovalList";
            listBoxTaskRequiringMyApprovalList.Size = new Size(203, 444);
            listBoxTaskRequiringMyApprovalList.TabIndex = 13;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Location = new Point(35, 552);
            labelDateTime.Margin = new Padding(4, 0, 4, 0);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(82, 20);
            labelDateTime.TabIndex = 14;
            labelDateTime.Text = "결재 시각: ";
            // 
            // customGroupBox1
            // 
            customGroupBox1.BackColor = Color.Transparent;
            customGroupBox1.Controls.Add(listBoxTaskRequiringMyApprovalList);
            customGroupBox1.Location = new Point(27, 23);
            customGroupBox1.Margin = new Padding(4);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Padding = new Padding(4);
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(220, 503);
            customGroupBox1.TabIndex = 28;
            customGroupBox1.TabStop = false;
            customGroupBox1.Text = "업무 리스트";
            customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox1.TitleFont = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox1.TitleForeColor = Color.White;
            customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Location = new Point(278, 23);
            customGroupBox2.Margin = new Padding(4);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(4);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(549, 503);
            customGroupBox2.TabIndex = 29;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "업무 내용";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // ApproveForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 598);
            Controls.Add(customGroupBox2);
            Controls.Add(customGroupBox1);
            Controls.Add(labelDateTime);
            Controls.Add(buttonRejectApproval);
            Controls.Add(buttonApproveApproval);
            Margin = new Padding(4);
            Name = "ApproveForm";
            Text = "ApproveForm";
            customGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxTaskRequiringMyApprovalList;
        private Label labelDateTime;
        private CustomGroupBox customGroupBox1;
        private CustomButtonStyle buttonRejectApproval;
        private CustomButtonStyle buttonApproveApproval;
        private CustomGroupBox customGroupBox2;
    }
}