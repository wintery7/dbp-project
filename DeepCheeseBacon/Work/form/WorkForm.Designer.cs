using deepcheesebacon.Customizing;
using deepcheesebacon.work.src;

namespace deepcheesebacon
{
    partial class WorkForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopCatergoryLabel = new Label();
            MiddleCategoryLabel = new Label();
            BottomCategoryLabel = new Label();
            StartTime = new DateTimePicker();
            StartDay = new DateTimePicker();
            EndTime = new DateTimePicker();
            EndDay = new DateTimePicker();
            WorkDetailBox = new RichTextBox();
            WorkView = new DataGridView();
            TopCategoryCombo = new ComboBox();
            MiddleCategoryCombo = new ComboBox();
            BottomCategoryCombo = new ComboBox();
            TimeSearchButton = new CustomButtonStyle();
            customGroupBox1 = new CustomGroupBox();
            customGroupBox2 = new CustomGroupBox();
            customGroupBox3 = new CustomGroupBox();
            customGroupBox4 = new CustomGroupBox();
            label1 = new Label();
            DeleteButton = new CustomButtonStyle();
            EditButton = new CustomButtonStyle();
            WorkId = new ComboBox();
            RegisterButton = new CustomButtonStyle();
            KeywordSearchButton = new CustomButtonStyle();
            Reload = new CustomButtonStyle();
            WorkMasterButton = new CustomButtonStyle();
            ((System.ComponentModel.ISupportInitialize)WorkView).BeginInit();
            customGroupBox1.SuspendLayout();
            customGroupBox2.SuspendLayout();
            customGroupBox3.SuspendLayout();
            customGroupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // TopCatergoryLabel
            // 
            TopCatergoryLabel.AutoSize = true;
            TopCatergoryLabel.Location = new Point(12, 79);
            TopCatergoryLabel.Margin = new Padding(6, 0, 6, 0);
            TopCatergoryLabel.Name = "TopCatergoryLabel";
            TopCatergoryLabel.Size = new Size(86, 32);
            TopCatergoryLabel.TabIndex = 0;
            TopCatergoryLabel.Text = "대분류";
            // 
            // MiddleCategoryLabel
            // 
            MiddleCategoryLabel.AutoSize = true;
            MiddleCategoryLabel.Location = new Point(262, 79);
            MiddleCategoryLabel.Margin = new Padding(6, 0, 6, 0);
            MiddleCategoryLabel.Name = "MiddleCategoryLabel";
            MiddleCategoryLabel.Size = new Size(86, 32);
            MiddleCategoryLabel.TabIndex = 1;
            MiddleCategoryLabel.Text = "중분류";
            // 
            // BottomCategoryLabel
            // 
            BottomCategoryLabel.AutoSize = true;
            BottomCategoryLabel.Location = new Point(512, 79);
            BottomCategoryLabel.Margin = new Padding(6, 0, 6, 0);
            BottomCategoryLabel.Name = "BottomCategoryLabel";
            BottomCategoryLabel.Size = new Size(86, 32);
            BottomCategoryLabel.TabIndex = 2;
            BottomCategoryLabel.Text = "소분류";
            // 
            // StartTime
            // 
            StartTime.Format = DateTimePickerFormat.Time;
            StartTime.Location = new Point(11, 141);
            StartTime.Margin = new Padding(6);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(309, 39);
            StartTime.TabIndex = 1;
            // 
            // StartDay
            // 
            StartDay.Format = DateTimePickerFormat.Short;
            StartDay.Location = new Point(11, 90);
            StartDay.Margin = new Padding(6);
            StartDay.Name = "StartDay";
            StartDay.Size = new Size(309, 39);
            StartDay.TabIndex = 0;
            // 
            // EndTime
            // 
            EndTime.Format = DateTimePickerFormat.Time;
            EndTime.Location = new Point(11, 141);
            EndTime.Margin = new Padding(6);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(308, 39);
            EndTime.TabIndex = 12;
            // 
            // EndDay
            // 
            EndDay.Format = DateTimePickerFormat.Short;
            EndDay.Location = new Point(11, 90);
            EndDay.Margin = new Padding(6);
            EndDay.Name = "EndDay";
            EndDay.Size = new Size(308, 39);
            EndDay.TabIndex = 2;
            // 
            // WorkDetailBox
            // 
            WorkDetailBox.Location = new Point(12, 79);
            WorkDetailBox.Margin = new Padding(6);
            WorkDetailBox.Name = "WorkDetailBox";
            WorkDetailBox.Size = new Size(1100, 91);
            WorkDetailBox.TabIndex = 8;
            WorkDetailBox.Text = "";
            // 
            // WorkView
            // 
            WorkView.BackgroundColor = Color.White;
            WorkView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorkView.Location = new Point(15, 519);
            WorkView.Margin = new Padding(6);
            WorkView.Name = "WorkView";
            WorkView.ReadOnly = true;
            WorkView.RowHeadersWidth = 82;
            WorkView.RowTemplate.Height = 25;
            WorkView.Size = new Size(1472, 463);
            WorkView.TabIndex = 12;
            // 
            // TopCategoryCombo
            // 
            TopCategoryCombo.FormattingEnabled = true;
            TopCategoryCombo.Location = new Point(12, 117);
            TopCategoryCombo.Margin = new Padding(6);
            TopCategoryCombo.Name = "TopCategoryCombo";
            TopCategoryCombo.Size = new Size(238, 40);
            TopCategoryCombo.TabIndex = 18;
            TopCategoryCombo.Click += TopCategoryCombo_Click;
            // 
            // MiddleCategoryCombo
            // 
            MiddleCategoryCombo.FormattingEnabled = true;
            MiddleCategoryCombo.Location = new Point(262, 117);
            MiddleCategoryCombo.Margin = new Padding(6);
            MiddleCategoryCombo.Name = "MiddleCategoryCombo";
            MiddleCategoryCombo.Size = new Size(238, 40);
            MiddleCategoryCombo.TabIndex = 19;
            MiddleCategoryCombo.Click += MiddleCategoryCombo_Click;
            // 
            // BottomCategoryCombo
            // 
            BottomCategoryCombo.FormattingEnabled = true;
            BottomCategoryCombo.Location = new Point(512, 117);
            BottomCategoryCombo.Margin = new Padding(6);
            BottomCategoryCombo.Name = "BottomCategoryCombo";
            BottomCategoryCombo.Size = new Size(238, 40);
            BottomCategoryCombo.TabIndex = 20;
            BottomCategoryCombo.Click += BottomCategoryCombo_Click;
            // 
            // TimeSearchButton
            // 
            TimeSearchButton.BackColor = Color.FromArgb(94, 159, 242);
            TimeSearchButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            TimeSearchButton.BorderColor = Color.PaleVioletRed;
            TimeSearchButton.BorderRadius = 20;
            TimeSearchButton.BorderSize = 0;
            TimeSearchButton.FlatAppearance.BorderSize = 0;
            TimeSearchButton.FlatStyle = FlatStyle.Flat;
            TimeSearchButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimeSearchButton.ForeColor = Color.White;
            TimeSearchButton.Location = new Point(656, 450);
            TimeSearchButton.Margin = new Padding(6);
            TimeSearchButton.Name = "TimeSearchButton";
            TimeSearchButton.Size = new Size(269, 57);
            TimeSearchButton.TabIndex = 21;
            TimeSearchButton.Text = "날짜 검색";
            TimeSearchButton.TextColor = Color.White;
            TimeSearchButton.UseVisualStyleBackColor = false;
            TimeSearchButton.Click += SearchButton_Click;
            // 
            // customGroupBox1
            // 
            customGroupBox1.BackColor = Color.Transparent;
            customGroupBox1.Controls.Add(StartTime);
            customGroupBox1.Controls.Add(StartDay);
            customGroupBox1.Location = new Point(796, 49);
            customGroupBox1.Margin = new Padding(6);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Padding = new Padding(6);
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(343, 195);
            customGroupBox1.TabIndex = 26;
            customGroupBox1.TabStop = false;
            customGroupBox1.Text = "시작 시간";
            customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox1.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox1.TitleForeColor = Color.White;
            customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(EndDay);
            customGroupBox2.Controls.Add(EndTime);
            customGroupBox2.Location = new Point(1156, 49);
            customGroupBox2.Margin = new Padding(6);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(6);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(331, 195);
            customGroupBox2.TabIndex = 27;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "종료 시간";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // customGroupBox3
            // 
            customGroupBox3.BackColor = Color.Transparent;
            customGroupBox3.Controls.Add(TopCategoryCombo);
            customGroupBox3.Controls.Add(MiddleCategoryCombo);
            customGroupBox3.Controls.Add(BottomCategoryCombo);
            customGroupBox3.Controls.Add(TopCatergoryLabel);
            customGroupBox3.Controls.Add(MiddleCategoryLabel);
            customGroupBox3.Controls.Add(BottomCategoryLabel);
            customGroupBox3.Location = new Point(15, 49);
            customGroupBox3.Margin = new Padding(6);
            customGroupBox3.Name = "customGroupBox3";
            customGroupBox3.Padding = new Padding(6);
            customGroupBox3.Radious = 25;
            customGroupBox3.Size = new Size(769, 195);
            customGroupBox3.TabIndex = 28;
            customGroupBox3.TabStop = false;
            customGroupBox3.Text = "업무 카테고리";
            customGroupBox3.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox3.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox3.TitleForeColor = Color.White;
            customGroupBox3.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // customGroupBox4
            // 
            customGroupBox4.BackColor = Color.Transparent;
            customGroupBox4.Controls.Add(WorkDetailBox);
            customGroupBox4.Location = new Point(15, 256);
            customGroupBox4.Margin = new Padding(6);
            customGroupBox4.Name = "customGroupBox4";
            customGroupBox4.Padding = new Padding(6);
            customGroupBox4.Radious = 25;
            customGroupBox4.Size = new Size(1124, 182);
            customGroupBox4.TabIndex = 29;
            customGroupBox4.TabStop = false;
            customGroupBox4.Text = "업무 내용 키워드";
            customGroupBox4.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox4.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox4.TitleForeColor = Color.White;
            customGroupBox4.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 450);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 47);
            label1.TabIndex = 37;
            label1.Text = "ID";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(94, 159, 242);
            DeleteButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            DeleteButton.BorderColor = Color.PaleVioletRed;
            DeleteButton.BorderRadius = 20;
            DeleteButton.BorderSize = 0;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(937, 450);
            DeleteButton.Margin = new Padding(6);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(269, 57);
            DeleteButton.TabIndex = 39;
            DeleteButton.Text = "삭제";
            DeleteButton.TextColor = Color.White;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(94, 159, 242);
            EditButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            EditButton.BorderColor = Color.PaleVioletRed;
            EditButton.BorderRadius = 20;
            EditButton.BorderSize = 0;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(1218, 450);
            EditButton.Margin = new Padding(6);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(269, 57);
            EditButton.TabIndex = 38;
            EditButton.Text = "수정";
            EditButton.TextColor = Color.White;
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // WorkId
            // 
            WorkId.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            WorkId.FormattingEnabled = true;
            WorkId.Location = new Point(70, 450);
            WorkId.Margin = new Padding(6);
            WorkId.Name = "WorkId";
            WorkId.Size = new Size(303, 55);
            WorkId.TabIndex = 40;
            WorkId.SelectedIndexChanged += WorkId_SelectedIndexChanged;
            WorkId.Click += WorkId_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(94, 159, 242);
            RegisterButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            RegisterButton.BorderColor = Color.PaleVioletRed;
            RegisterButton.BorderRadius = 20;
            RegisterButton.BorderSize = 0;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(1156, 256);
            RegisterButton.Margin = new Padding(6);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(331, 182);
            RegisterButton.TabIndex = 41;
            RegisterButton.Text = "등록";
            RegisterButton.TextColor = Color.White;
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click_1;
            // 
            // KeywordSearchButton
            // 
            KeywordSearchButton.BackColor = Color.FromArgb(94, 159, 242);
            KeywordSearchButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            KeywordSearchButton.BorderColor = Color.PaleVioletRed;
            KeywordSearchButton.BorderRadius = 20;
            KeywordSearchButton.BorderSize = 0;
            KeywordSearchButton.FlatAppearance.BorderSize = 0;
            KeywordSearchButton.FlatStyle = FlatStyle.Flat;
            KeywordSearchButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            KeywordSearchButton.ForeColor = Color.White;
            KeywordSearchButton.Location = new Point(375, 450);
            KeywordSearchButton.Margin = new Padding(6);
            KeywordSearchButton.Name = "KeywordSearchButton";
            KeywordSearchButton.Size = new Size(269, 57);
            KeywordSearchButton.TabIndex = 42;
            KeywordSearchButton.Text = "키워드 검색";
            KeywordSearchButton.TextColor = Color.White;
            KeywordSearchButton.UseVisualStyleBackColor = false;
            KeywordSearchButton.Click += KeywordSearchButton_Click;
            // 
            // Reload
            // 
            Reload.BackColor = Color.FromArgb(94, 159, 242);
            Reload.BackgroundColor = Color.FromArgb(94, 159, 242);
            Reload.BorderColor = Color.PaleVioletRed;
            Reload.BorderRadius = 20;
            Reload.BorderSize = 0;
            Reload.FlatAppearance.BorderSize = 0;
            Reload.FlatStyle = FlatStyle.Flat;
            Reload.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Reload.ForeColor = Color.White;
            Reload.Location = new Point(1218, 994);
            Reload.Margin = new Padding(6);
            Reload.Name = "Reload";
            Reload.Size = new Size(269, 57);
            Reload.TabIndex = 43;
            Reload.Text = "Reload";
            Reload.TextColor = Color.White;
            Reload.UseVisualStyleBackColor = false;
            Reload.Click += Reload_Click;
            // 
            // WorkMasterButton
            // 
            WorkMasterButton.BackColor = Color.FromArgb(94, 159, 242);
            WorkMasterButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            WorkMasterButton.BorderColor = Color.PaleVioletRed;
            WorkMasterButton.BorderRadius = 20;
            WorkMasterButton.BorderSize = 0;
            WorkMasterButton.FlatAppearance.BorderSize = 0;
            WorkMasterButton.FlatStyle = FlatStyle.Flat;
            WorkMasterButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            WorkMasterButton.ForeColor = Color.White;
            WorkMasterButton.Location = new Point(838, 995);
            WorkMasterButton.Margin = new Padding(6);
            WorkMasterButton.Name = "WorkMasterButton";
            WorkMasterButton.Size = new Size(368, 57);
            WorkMasterButton.TabIndex = 44;
            WorkMasterButton.Text = "업무 마스터 편집";
            WorkMasterButton.TextColor = Color.White;
            WorkMasterButton.UseVisualStyleBackColor = false;
            WorkMasterButton.Click += WorkMasterButton_Click_1;
            // 
            // WorkForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1502, 1067);
            Controls.Add(WorkMasterButton);
            Controls.Add(Reload);
            Controls.Add(KeywordSearchButton);
            Controls.Add(RegisterButton);
            Controls.Add(WorkId);
            Controls.Add(label1);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(customGroupBox4);
            Controls.Add(customGroupBox3);
            Controls.Add(customGroupBox2);
            Controls.Add(customGroupBox1);
            Controls.Add(TimeSearchButton);
            Controls.Add(WorkView);
            Margin = new Padding(6);
            Name = "WorkForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)WorkView).EndInit();
            customGroupBox1.ResumeLayout(false);
            customGroupBox2.ResumeLayout(false);
            customGroupBox3.ResumeLayout(false);
            customGroupBox3.PerformLayout();
            customGroupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TopCatergoryLabel;
        private Label MiddleCategoryLabel;
        private Label BottomCategoryLabel;
        private RichTextBox WorkDetailBox;
        private DateTimePicker StartTimeFrom;
        private DataGridView WorkView;
        private DateTimePicker EndTimeTo;
        private DateTimePicker EndTimeFrom;
        private DateTimePicker StartTimeTo;
        private ComboBox BottomCategoryCombo;
        private ComboBox MiddleCategoryCombo;
        private ComboBox TopCategoryCombo;
        private DateTimePicker StartTime;
        private DateTimePicker StartDay;
        private DateTimePicker EndTime;
        private DateTimePicker EndDay;
        private CustomButtonStyle TimeSearchButton;
        private CustomGroupBox customGroupBox1;
        private CustomGroupBox customGroupBox2;
        private CustomGroupBox customGroupBox3;
        private CustomGroupBox customGroupBox4;
        private Label label1;
        private CustomButtonStyle DeleteButton;
        private CustomButtonStyle EditButton;
        private ComboBox WorkId;
        private CustomButtonStyle RegisterButton;
        private CustomButtonStyle KeywordSearchButton;
        private CustomButtonStyle Reload;
        private CustomButtonStyle WorkMasterButton;
    }
}