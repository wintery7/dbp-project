﻿using deepcheesebacon.Customizing;

namespace deepcheesebacon
{
    partial class AttendanceReg
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
            dateTimePicker1 = new DateTimePicker();
            GoWorkBtn = new CustomButtonStyle();
            OffWorkBtn = new CustomButtonStyle();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(201, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 27);
            dateTimePicker1.TabIndex = 40;
            // 
            // GoWorkBtn
            // 
            GoWorkBtn.BackColor = Color.FromArgb(94, 159, 242);
            GoWorkBtn.BackgroundColor = Color.FromArgb(94, 159, 242);
            GoWorkBtn.BorderColor = Color.RoyalBlue;
            GoWorkBtn.BorderRadius = 20;
            GoWorkBtn.BorderSize = 0;
            GoWorkBtn.FlatStyle = FlatStyle.Flat;
            GoWorkBtn.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GoWorkBtn.ForeColor = Color.White;
            GoWorkBtn.Location = new Point(530, 387);
            GoWorkBtn.Name = "GoWorkBtn";
            GoWorkBtn.Size = new Size(102, 43);
            GoWorkBtn.TabIndex = 41;
            GoWorkBtn.Text = "출근";
            GoWorkBtn.TextColor = Color.White;
            GoWorkBtn.UseVisualStyleBackColor = false;
            GoWorkBtn.Click += GoWorkBtn_Click;
            // 
            // OffWorkBtn
            // 
            OffWorkBtn.BackColor = Color.FromArgb(94, 159, 242);
            OffWorkBtn.BackgroundColor = Color.FromArgb(94, 159, 242);
            OffWorkBtn.BorderColor = Color.RoyalBlue;
            OffWorkBtn.BorderRadius = 20;
            OffWorkBtn.BorderSize = 0;
            OffWorkBtn.FlatStyle = FlatStyle.Flat;
            OffWorkBtn.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            OffWorkBtn.ForeColor = Color.White;
            OffWorkBtn.Location = new Point(639, 387);
            OffWorkBtn.Name = "OffWorkBtn";
            OffWorkBtn.Size = new Size(102, 43);
            OffWorkBtn.TabIndex = 44;
            OffWorkBtn.Text = "퇴근";
            OffWorkBtn.TextColor = Color.White;
            OffWorkBtn.UseVisualStyleBackColor = false;
            OffWorkBtn.Click += OffWorkBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(201, 144);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(540, 223);
            dataGridView2.TabIndex = 45;
            // 
            // AttendanceReg
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView2);
            Controls.Add(OffWorkBtn);
            Controls.Add(GoWorkBtn);
            Controls.Add(dateTimePicker1);
            Name = "AttendanceReg";
            Size = new Size(966, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private CustomButtonStyle GoWorkBtn;
        private CustomButtonStyle OffWorkBtn;
        private DataGridView dataGridView2;
    }
}
