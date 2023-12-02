namespace deepcheesebacon
{
    partial class SubjectManage
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
            label2 = new Label();
            modifyBtn = new Button();
            deleteBtn = new Button();
            dataGridView1 = new DataGridView();
            departmentBtn = new Button();
            label3 = new Label();
            gradeText = new TextBox();
            departmentText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 184);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 36;
            label2.Text = "과목등록";
            // 
            // modifyBtn
            // 
            modifyBtn.Location = new Point(357, 302);
            modifyBtn.Margin = new Padding(2, 2, 2, 2);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(88, 32);
            modifyBtn.TabIndex = 38;
            modifyBtn.Text = "수정";
            modifyBtn.UseVisualStyleBackColor = true;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(485, 302);
            deleteBtn.Margin = new Padding(2, 2, 2, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(88, 32);
            deleteBtn.TabIndex = 39;
            deleteBtn.Text = "삭제";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 119);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(436, 136);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // departmentBtn
            // 
            departmentBtn.Location = new Point(227, 302);
            departmentBtn.Margin = new Padding(2, 2, 2, 2);
            departmentBtn.Name = "departmentBtn";
            departmentBtn.Size = new Size(88, 32);
            departmentBtn.TabIndex = 41;
            departmentBtn.Text = "등록";
            departmentBtn.UseVisualStyleBackColor = true;
            departmentBtn.Click += departmentBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 116);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 42;
            label3.Text = "담당학년";
            // 
            // gradeText
            // 
            gradeText.Location = new Point(34, 137);
            gradeText.Margin = new Padding(2, 2, 2, 2);
            gradeText.Multiline = true;
            gradeText.Name = "gradeText";
            gradeText.Size = new Size(122, 32);
            gradeText.TabIndex = 46;
            // 
            // departmentText
            // 
            departmentText.Location = new Point(34, 205);
            departmentText.Margin = new Padding(2, 2, 2, 2);
            departmentText.Multiline = true;
            departmentText.Name = "departmentText";
            departmentText.Size = new Size(122, 32);
            departmentText.TabIndex = 47;
            // 
            // SubjectManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(departmentText);
            Controls.Add(gradeText);
            Controls.Add(label3);
            Controls.Add(departmentBtn);
            Controls.Add(dataGridView1);
            Controls.Add(deleteBtn);
            Controls.Add(modifyBtn);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SubjectManage";
            Size = new Size(684, 490);
            Load += SubjectManage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button modifyBtn;
        private Button deleteBtn;
        private DataGridView dataGridView1;
        private Button departmentBtn;
        private Label label3;
        private TextBox gradeText;
        private TextBox departmentText;
    }
}
