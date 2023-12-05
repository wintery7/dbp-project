using deepcheesebacon.Customizing;

namespace deepcheesebacon
{
    partial class AttendanceView
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
            AttendTimeBtn = new CustomButtonStyle();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AttendTimeBtn
            // 
            AttendTimeBtn.BackColor = Color.FromArgb(94, 159, 242);
            AttendTimeBtn.BackgroundColor = Color.FromArgb(94, 159, 242);
            AttendTimeBtn.BorderColor = Color.RoyalBlue;
            AttendTimeBtn.BorderRadius = 20;
            AttendTimeBtn.BorderSize = 0;
            AttendTimeBtn.FlatStyle = FlatStyle.Flat;
            AttendTimeBtn.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AttendTimeBtn.ForeColor = Color.White;
            AttendTimeBtn.Location = new Point(36, 48);
            AttendTimeBtn.Name = "AttendTimeBtn";
            AttendTimeBtn.Size = new Size(138, 43);
            AttendTimeBtn.TabIndex = 43;
            AttendTimeBtn.Text = "출퇴근 시간";
            AttendTimeBtn.TextColor = Color.White;
            AttendTimeBtn.UseVisualStyleBackColor = false;
            AttendTimeBtn.Click += AttendTimeBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(892, 351);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AttendanceView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AttendTimeBtn);
            Controls.Add(dataGridView1);
            Name = "AttendanceView";
            Size = new Size(966, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CustomButtonStyle AttendTimeBtn;
        private DataGridView dataGridView1;
    }
}
