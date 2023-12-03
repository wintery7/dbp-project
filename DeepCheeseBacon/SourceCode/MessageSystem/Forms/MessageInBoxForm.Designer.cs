namespace deepcheesebacon.SourceCode.MessageSystem.Forms
{
    partial class MessageInBoxForm
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
            listBoxMessage = new ListBox();
            label1 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxContent = new TextBox();
            buttonSearchByTitle = new Button();
            buttonSearchByContent = new Button();
            SuspendLayout();
            // 
            // listBoxMessage
            // 
            listBoxMessage.FormattingEnabled = true;
            listBoxMessage.ItemHeight = 15;
            listBoxMessage.Location = new Point(12, 49);
            listBoxMessage.Name = "listBoxMessage";
            listBoxMessage.Size = new Size(431, 334);
            listBoxMessage.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "받은 쪽지들";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(594, 97);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(134, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 51);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "쪽지 검색";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 100);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 4;
            label3.Text = "쪽지 보낸 사람 이메일";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 196);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "쪽지 내용";
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new Point(594, 193);
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Size = new Size(134, 23);
            textBoxContent.TabIndex = 5;
            // 
            // buttonSearchByTitle
            // 
            buttonSearchByTitle.Location = new Point(461, 126);
            buttonSearchByTitle.Name = "buttonSearchByTitle";
            buttonSearchByTitle.Size = new Size(267, 28);
            buttonSearchByTitle.TabIndex = 7;
            buttonSearchByTitle.Text = "검색";
            buttonSearchByTitle.UseVisualStyleBackColor = true;
            buttonSearchByTitle.Click += buttonSearchByTitle_Click;
            // 
            // buttonSearchByContent
            // 
            buttonSearchByContent.Location = new Point(461, 222);
            buttonSearchByContent.Name = "buttonSearchByContent";
            buttonSearchByContent.Size = new Size(267, 28);
            buttonSearchByContent.TabIndex = 8;
            buttonSearchByContent.Text = "검색";
            buttonSearchByContent.UseVisualStyleBackColor = true;
            buttonSearchByContent.Click += buttonSearchByContent_Click;
            // 
            // MessageInBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 462);
            Controls.Add(buttonSearchByContent);
            Controls.Add(buttonSearchByTitle);
            Controls.Add(label4);
            Controls.Add(textBoxContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Controls.Add(listBoxMessage);
            Name = "MessageInBoxForm";
            Text = "MessageInBoxForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMessage;
        private Label label1;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxContent;
        private Button buttonSearchByTitle;
        private Button buttonSearchByContent;
    }
}