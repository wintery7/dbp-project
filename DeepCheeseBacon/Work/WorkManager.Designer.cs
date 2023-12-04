using deepcheesebacon.Customizing;

namespace deepcheesebacon.Work
{
    partial class WorkManager
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
            customGroupBox3 = new CustomGroupBox();
            TopCategoryCombo = new ComboBox();
            MiddleCategoryCombo = new ComboBox();
            BottomCategoryCombo = new ComboBox();
            TopCatergoryLabel = new Label();
            MiddleCategoryLabel = new Label();
            BottomCategoryLabel = new Label();
            customGroupBox4 = new CustomGroupBox();
            WorkDetailBox = new RichTextBox();
            customGroupBox2 = new CustomGroupBox();
            EndDay = new DateTimePicker();
            EndTime = new DateTimePicker();
            customGroupBox1 = new CustomGroupBox();
            StartTime = new DateTimePicker();
            StartDay = new DateTimePicker();
            SearchButton = new CustomButtonStyle();
            DataView = new DataGridView();
            WorkId = new ComboBox();
            customButtonStyle1 = new CustomButtonStyle();
            customButtonStyle2 = new CustomButtonStyle();
            label1 = new Label();
            customGroupBox3.SuspendLayout();
            customGroupBox4.SuspendLayout();
            customGroupBox2.SuspendLayout();
            customGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
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
            customGroupBox3.Location = new Point(15, 15);
            customGroupBox3.Margin = new Padding(6);
            customGroupBox3.Name = "customGroupBox3";
            customGroupBox3.Padding = new Padding(6);
            customGroupBox3.Radious = 25;
            customGroupBox3.Size = new Size(769, 195);
            customGroupBox3.TabIndex = 29;
            customGroupBox3.TabStop = false;
            customGroupBox3.Text = "업무 카테고리";
            customGroupBox3.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox3.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox3.TitleForeColor = Color.White;
            customGroupBox3.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // TopCategoryCombo
            // 
            TopCategoryCombo.FormattingEnabled = true;
            TopCategoryCombo.Location = new Point(12, 117);
            TopCategoryCombo.Margin = new Padding(6);
            TopCategoryCombo.Name = "TopCategoryCombo";
            TopCategoryCombo.Size = new Size(238, 40);
            TopCategoryCombo.TabIndex = 18;
            // 
            // MiddleCategoryCombo
            // 
            MiddleCategoryCombo.FormattingEnabled = true;
            MiddleCategoryCombo.Location = new Point(262, 117);
            MiddleCategoryCombo.Margin = new Padding(6);
            MiddleCategoryCombo.Name = "MiddleCategoryCombo";
            MiddleCategoryCombo.Size = new Size(238, 40);
            MiddleCategoryCombo.TabIndex = 19;
            // 
            // BottomCategoryCombo
            // 
            BottomCategoryCombo.FormattingEnabled = true;
            BottomCategoryCombo.Location = new Point(512, 117);
            BottomCategoryCombo.Margin = new Padding(6);
            BottomCategoryCombo.Name = "BottomCategoryCombo";
            BottomCategoryCombo.Size = new Size(238, 40);
            BottomCategoryCombo.TabIndex = 20;
            // 
            // TopCatergoryLabel
            // 
            TopCatergoryLabel.AutoSize = true;
            TopCatergoryLabel.Location = new Point(15, 82);
            TopCatergoryLabel.Margin = new Padding(6, 0, 6, 0);
            TopCatergoryLabel.Name = "TopCatergoryLabel";
            TopCatergoryLabel.Size = new Size(86, 32);
            TopCatergoryLabel.TabIndex = 0;
            TopCatergoryLabel.Text = "대분류";
            // 
            // MiddleCategoryLabel
            // 
            MiddleCategoryLabel.AutoSize = true;
            MiddleCategoryLabel.Location = new Point(265, 82);
            MiddleCategoryLabel.Margin = new Padding(6, 0, 6, 0);
            MiddleCategoryLabel.Name = "MiddleCategoryLabel";
            MiddleCategoryLabel.Size = new Size(86, 32);
            MiddleCategoryLabel.TabIndex = 1;
            MiddleCategoryLabel.Text = "중분류";
            // 
            // BottomCategoryLabel
            // 
            BottomCategoryLabel.AutoSize = true;
            BottomCategoryLabel.Location = new Point(515, 82);
            BottomCategoryLabel.Margin = new Padding(6, 0, 6, 0);
            BottomCategoryLabel.Name = "BottomCategoryLabel";
            BottomCategoryLabel.Size = new Size(86, 32);
            BottomCategoryLabel.TabIndex = 2;
            BottomCategoryLabel.Text = "소분류";
            // 
            // customGroupBox4
            // 
            customGroupBox4.BackColor = Color.Transparent;
            customGroupBox4.Controls.Add(WorkDetailBox);
            customGroupBox4.Location = new Point(15, 222);
            customGroupBox4.Margin = new Padding(6);
            customGroupBox4.Name = "customGroupBox4";
            customGroupBox4.Padding = new Padding(6);
            customGroupBox4.Radious = 25;
            customGroupBox4.Size = new Size(1124, 182);
            customGroupBox4.TabIndex = 34;
            customGroupBox4.TabStop = false;
            customGroupBox4.Text = "업무 내용 키워드";
            customGroupBox4.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox4.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox4.TitleForeColor = Color.White;
            customGroupBox4.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
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
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(EndDay);
            customGroupBox2.Controls.Add(EndTime);
            customGroupBox2.Location = new Point(1152, 15);
            customGroupBox2.Margin = new Padding(6);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(6);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(331, 195);
            customGroupBox2.TabIndex = 33;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "종료 시간";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
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
            // EndTime
            // 
            EndTime.Format = DateTimePickerFormat.Time;
            EndTime.Location = new Point(11, 141);
            EndTime.Margin = new Padding(6);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(308, 39);
            EndTime.TabIndex = 12;
            // 
            // customGroupBox1
            // 
            customGroupBox1.BackColor = Color.Transparent;
            customGroupBox1.Controls.Add(StartTime);
            customGroupBox1.Controls.Add(StartDay);
            customGroupBox1.Location = new Point(796, 15);
            customGroupBox1.Margin = new Padding(6);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Padding = new Padding(6);
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(343, 195);
            customGroupBox1.TabIndex = 32;
            customGroupBox1.TabStop = false;
            customGroupBox1.Text = "시작 시간";
            customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox1.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox1.TitleForeColor = Color.White;
            customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
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
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(94, 159, 242);
            SearchButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            SearchButton.BorderColor = Color.PaleVioletRed;
            SearchButton.BorderRadius = 20;
            SearchButton.BorderSize = 0;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(1151, 222);
            SearchButton.Margin = new Padding(6);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(331, 182);
            SearchButton.TabIndex = 31;
            SearchButton.Text = "등록";
            SearchButton.TextColor = Color.White;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // DataView
            // 
            DataView.BackgroundColor = Color.White;
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(10, 516);
            DataView.Margin = new Padding(6);
            DataView.Name = "DataView";
            DataView.ReadOnly = true;
            DataView.RowHeadersWidth = 82;
            DataView.RowTemplate.Height = 25;
            DataView.Size = new Size(1472, 765);
            DataView.TabIndex = 30;
            // 
            // WorkId
            // 
            WorkId.FormattingEnabled = true;
            WorkId.Location = new Point(15, 464);
            WorkId.Margin = new Padding(6);
            WorkId.Name = "WorkId";
            WorkId.Size = new Size(318, 40);
            WorkId.TabIndex = 21;
            // 
            // customButtonStyle1
            // 
            customButtonStyle1.BackColor = Color.FromArgb(94, 159, 242);
            customButtonStyle1.BackgroundColor = Color.FromArgb(94, 159, 242);
            customButtonStyle1.BorderColor = Color.PaleVioletRed;
            customButtonStyle1.BorderRadius = 20;
            customButtonStyle1.BorderSize = 0;
            customButtonStyle1.FlatAppearance.BorderSize = 0;
            customButtonStyle1.FlatStyle = FlatStyle.Flat;
            customButtonStyle1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButtonStyle1.ForeColor = Color.White;
            customButtonStyle1.Location = new Point(1155, 421);
            customButtonStyle1.Margin = new Padding(6);
            customButtonStyle1.Name = "customButtonStyle1";
            customButtonStyle1.Size = new Size(331, 83);
            customButtonStyle1.TabIndex = 35;
            customButtonStyle1.Text = "수정";
            customButtonStyle1.TextColor = Color.White;
            customButtonStyle1.UseVisualStyleBackColor = false;
            // 
            // customButtonStyle2
            // 
            customButtonStyle2.BackColor = Color.FromArgb(94, 159, 242);
            customButtonStyle2.BackgroundColor = Color.FromArgb(94, 159, 242);
            customButtonStyle2.BorderColor = Color.PaleVioletRed;
            customButtonStyle2.BorderRadius = 20;
            customButtonStyle2.BorderSize = 0;
            customButtonStyle2.FlatAppearance.BorderSize = 0;
            customButtonStyle2.FlatStyle = FlatStyle.Flat;
            customButtonStyle2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButtonStyle2.ForeColor = Color.White;
            customButtonStyle2.Location = new Point(812, 421);
            customButtonStyle2.Margin = new Padding(6);
            customButtonStyle2.Name = "customButtonStyle2";
            customButtonStyle2.Size = new Size(331, 83);
            customButtonStyle2.TabIndex = 36;
            customButtonStyle2.Text = "삭제";
            customButtonStyle2.TextColor = Color.White;
            customButtonStyle2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 421);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // WorkManager
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 1296);
            Controls.Add(label1);
            Controls.Add(customButtonStyle2);
            Controls.Add(customButtonStyle1);
            Controls.Add(WorkId);
            Controls.Add(customGroupBox4);
            Controls.Add(customGroupBox2);
            Controls.Add(customGroupBox1);
            Controls.Add(SearchButton);
            Controls.Add(DataView);
            Controls.Add(customGroupBox3);
            Name = "WorkManager";
            Text = "WorkManager";
            customGroupBox3.ResumeLayout(false);
            customGroupBox3.PerformLayout();
            customGroupBox4.ResumeLayout(false);
            customGroupBox2.ResumeLayout(false);
            customGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomGroupBox customGroupBox3;
        private ComboBox TopCategoryCombo;
        private ComboBox MiddleCategoryCombo;
        private ComboBox BottomCategoryCombo;
        private Label TopCatergoryLabel;
        private Label MiddleCategoryLabel;
        private Label BottomCategoryLabel;
        private CustomGroupBox customGroupBox4;
        private RichTextBox WorkDetailBox;
        private CustomGroupBox customGroupBox2;
        private DateTimePicker EndDay;
        private DateTimePicker EndTime;
        private CustomGroupBox customGroupBox1;
        private DateTimePicker StartTime;
        private DateTimePicker StartDay;
        private CustomButtonStyle SearchButton;
        private DataGridView DataView;
        private ComboBox WorkId;
        private CustomButtonStyle customButtonStyle1;
        private CustomButtonStyle customButtonStyle2;
        private Label label1;
    }
}