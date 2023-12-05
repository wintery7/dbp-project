using deepcheesebacon.Customizing;

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
            modifyBtn = new CustomButtonStyle();
            deleteBtn = new CustomButtonStyle();
            dataGridView1 = new DataGridView();
            departmentBtn = new CustomButtonStyle();
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
            label2.Location = new Point(98, 245);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 36;
            label2.Text = "과목등록";
            // 
            // modifyBtn
            // 
            modifyBtn.BackColor = Color.FromArgb(94, 159, 242);
            modifyBtn.BackgroundColor = Color.FromArgb(94, 159, 242);
            modifyBtn.BorderColor = Color.RoyalBlue;
            modifyBtn.BorderRadius = 20;
            modifyBtn.BorderSize = 0;
            modifyBtn.FlatStyle = FlatStyle.Flat;
            modifyBtn.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            modifyBtn.ForeColor = Color.White;
            modifyBtn.Location = new Point(541, 388);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(113, 43);
            modifyBtn.TabIndex = 38;
            modifyBtn.Text = "수정";
            modifyBtn.TextColor = Color.White;
            modifyBtn.UseVisualStyleBackColor = false;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(94, 159, 242);
            deleteBtn.BackgroundColor = Color.FromArgb(94, 159, 242);
            deleteBtn.BorderColor = Color.RoyalBlue;
            deleteBtn.BorderRadius = 20;
            deleteBtn.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(706, 388);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(113, 43);
            deleteBtn.TabIndex = 39;
            deleteBtn.Text = "삭제";
            deleteBtn.TextColor = Color.White;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(561, 181);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // departmentBtn
            // 
            departmentBtn.BackColor = Color.FromArgb(94, 159, 242);
            departmentBtn.BackgroundColor = Color.FromArgb(94, 159, 242);
            departmentBtn.BorderColor = Color.RoyalBlue;
            departmentBtn.BorderRadius = 20;
            departmentBtn.BorderSize = 0;
            departmentBtn.FlatStyle = FlatStyle.Flat;
            departmentBtn.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            departmentBtn.ForeColor = Color.White;
            departmentBtn.Location = new Point(374, 388);
            departmentBtn.Name = "departmentBtn";
            departmentBtn.Size = new Size(113, 43);
            departmentBtn.TabIndex = 41;
            departmentBtn.Text = "등록";
            departmentBtn.TextColor = Color.White;
            departmentBtn.UseVisualStyleBackColor = false;
            departmentBtn.Click += departmentBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 155);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 42;
            label3.Text = "담당학년";
            // 
            // gradeText
            // 
            gradeText.Location = new Point(98, 183);
            gradeText.Multiline = true;
            gradeText.Name = "gradeText";
            gradeText.Size = new Size(156, 41);
            gradeText.TabIndex = 46;
            // 
            // departmentText
            // 
            departmentText.Location = new Point(98, 273);
            departmentText.Multiline = true;
            departmentText.Name = "departmentText";
            departmentText.Size = new Size(156, 41);
            departmentText.TabIndex = 47;
            // 
            // SubjectManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(departmentText);
            Controls.Add(gradeText);
            Controls.Add(label3);
            Controls.Add(departmentBtn);
            Controls.Add(dataGridView1);
            Controls.Add(deleteBtn);
            Controls.Add(modifyBtn);
            Controls.Add(label2);
            Name = "SubjectManage";
            Size = new Size(966, 520);
            Load += SubjectManage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private CustomButtonStyle modifyBtn;
        private CustomButtonStyle deleteBtn;
        private DataGridView dataGridView1;
        private CustomButtonStyle departmentBtn;
        private Label label3;
        private TextBox gradeText;
        private TextBox departmentText;
    }
}
