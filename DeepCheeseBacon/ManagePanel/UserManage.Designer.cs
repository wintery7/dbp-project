namespace deepcheesebacon
{
    partial class UserManage
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            SubjectSearchBtn = new Button();
            nameText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateText = new TextBox();
            depText = new TextBox();
            label2 = new Label();
            NameSearchBtn = new Button();
            AgeSearchBtn = new Button();
            userIdText = new TextBox();
            ModifyBtn = new Button();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(789, 206);
            dataGridView1.TabIndex = 47;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // SubjectSearchBtn
            // 
            SubjectSearchBtn.Location = new Point(202, 181);
            SubjectSearchBtn.Name = "SubjectSearchBtn";
            SubjectSearchBtn.Size = new Size(97, 30);
            SubjectSearchBtn.TabIndex = 44;
            SubjectSearchBtn.Text = "검색";
            SubjectSearchBtn.UseVisualStyleBackColor = true;
            SubjectSearchBtn.Click += SearchBtn_Click;
            // 
            // nameText
            // 
            nameText.Location = new Point(308, 180);
            nameText.Multiline = true;
            nameText.Name = "nameText";
            nameText.Size = new Size(155, 31);
            nameText.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11F);
            label3.Location = new Point(308, 152);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 39;
            label3.Text = "이름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11F);
            label4.Location = new Point(576, 152);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 40;
            label4.Text = "나이";
            // 
            // dateText
            // 
            dateText.Location = new Point(576, 180);
            dateText.Multiline = true;
            dateText.Name = "dateText";
            dateText.Size = new Size(150, 31);
            dateText.TabIndex = 43;
            // 
            // depText
            // 
            depText.Location = new Point(40, 180);
            depText.Multiline = true;
            depText.Name = "depText";
            depText.Size = new Size(156, 31);
            depText.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F);
            label2.Location = new Point(40, 152);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 38;
            label2.Text = "담당과목";
            // 
            // NameSearchBtn
            // 
            NameSearchBtn.Location = new Point(469, 181);
            NameSearchBtn.Name = "NameSearchBtn";
            NameSearchBtn.Size = new Size(97, 30);
            NameSearchBtn.TabIndex = 51;
            NameSearchBtn.Text = "검색";
            NameSearchBtn.UseVisualStyleBackColor = true;
            NameSearchBtn.Click += NameSearchBtn_Click;
            // 
            // AgeSearchBtn
            // 
            AgeSearchBtn.Location = new Point(732, 181);
            AgeSearchBtn.Name = "AgeSearchBtn";
            AgeSearchBtn.Size = new Size(97, 30);
            AgeSearchBtn.TabIndex = 53;
            AgeSearchBtn.Text = "검색";
            AgeSearchBtn.UseVisualStyleBackColor = true;
            AgeSearchBtn.Click += AgeSearchBtn_Click;
            // 
            // userIdText
            // 
            userIdText.Location = new Point(538, 429);
            userIdText.Multiline = true;
            userIdText.Name = "userIdText";
            userIdText.Size = new Size(85, 31);
            userIdText.TabIndex = 58;
            // 
            // ModifyBtn
            // 
            ModifyBtn.Location = new Point(629, 430);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(97, 30);
            ModifyBtn.TabIndex = 59;
            ModifyBtn.Text = "수정";
            ModifyBtn.UseVisualStyleBackColor = true;
            ModifyBtn.Click += ModifyBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(732, 430);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(97, 30);
            DeleteBtn.TabIndex = 60;
            DeleteBtn.Text = "삭제";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UserManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteBtn);
            Controls.Add(ModifyBtn);
            Controls.Add(userIdText);
            Controls.Add(AgeSearchBtn);
            Controls.Add(NameSearchBtn);
            Controls.Add(dataGridView1);
            Controls.Add(SubjectSearchBtn);
            Controls.Add(dateText);
            Controls.Add(nameText);
            Controls.Add(depText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "UserManage";
            Size = new Size(879, 653);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button SubjectSearchBtn;
        private TextBox nameText;
        private Label label3;
        private Label label4;
        private TextBox dateText;
        private TextBox depText;
        private Label label2;
        private Button NameSearchBtn;
        private Button AgeSearchBtn;
        private TextBox userIdText;
        private Button ModifyBtn;
        private Button DeleteBtn;
    }
}
