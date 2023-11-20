using deepcheesebacon.Work;

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
            DataView = new DataGridView();
            IdSearchLabel = new Label();
            IdSearchBox = new TextBox();
            TopCategoryCombo = new ComboBox();
            MiddleCategoryCombo = new ComboBox();
            BottomCategoryCombo = new ComboBox();
            SearchButton = new CustomButtonStyle();
            RegisterButton = new CustomButtonStyle();
            WorkMasterButton = new CustomButtonStyle();
            RemoveButton = new CustomButtonStyle();
            ModifyButton = new CustomButtonStyle();
            customGroupBox1 = new CustomGroupBox();
            customGroupBox2 = new CustomGroupBox();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            customGroupBox1.SuspendLayout();
            customGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TopCatergoryLabel
            // 
            TopCatergoryLabel.AutoSize = true;
            TopCatergoryLabel.Location = new Point(23, 44);
            TopCatergoryLabel.Name = "TopCatergoryLabel";
            TopCatergoryLabel.Size = new Size(43, 15);
            TopCatergoryLabel.TabIndex = 0;
            TopCatergoryLabel.Text = "대분류";
            // 
            // MiddleCategoryLabel
            // 
            MiddleCategoryLabel.AutoSize = true;
            MiddleCategoryLabel.Location = new Point(23, 85);
            MiddleCategoryLabel.Name = "MiddleCategoryLabel";
            MiddleCategoryLabel.Size = new Size(43, 15);
            MiddleCategoryLabel.TabIndex = 1;
            MiddleCategoryLabel.Text = "중분류";
            // 
            // BottomCategoryLabel
            // 
            BottomCategoryLabel.AutoSize = true;
            BottomCategoryLabel.Location = new Point(23, 128);
            BottomCategoryLabel.Name = "BottomCategoryLabel";
            BottomCategoryLabel.Size = new Size(43, 15);
            BottomCategoryLabel.TabIndex = 2;
            BottomCategoryLabel.Text = "소분류";
            // 
            // StartTime
            // 
            StartTime.Location = new Point(14, 78);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(188, 23);
            StartTime.TabIndex = 1;
            // 
            // StartDay
            // 
            StartDay.Location = new Point(14, 49);
            StartDay.Name = "StartDay";
            StartDay.Size = new Size(188, 23);
            StartDay.TabIndex = 0;
            // 
            // EndTime
            // 
            EndTime.Location = new Point(14, 76);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(188, 23);
            EndTime.TabIndex = 12;
            // 
            // EndDay
            // 
            EndDay.Location = new Point(14, 47);
            EndDay.Name = "EndDay";
            EndDay.Size = new Size(188, 23);
            EndDay.TabIndex = 2;
            // 
            // WorkDetailBox
            // 
            WorkDetailBox.Location = new Point(440, 35);
            WorkDetailBox.Name = "WorkDetailBox";
            WorkDetailBox.Size = new Size(241, 220);
            WorkDetailBox.TabIndex = 8;
            WorkDetailBox.Text = "";
            WorkDetailBox.TextChanged += WorkDetailBox_TextChanged;
            // 
            // DataView
            // 
            DataView.BackgroundColor = Color.White;
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(27, 298);
            DataView.Name = "DataView";
            DataView.ReadOnly = true;
            DataView.RowTemplate.Height = 25;
            DataView.Size = new Size(836, 279);
            DataView.TabIndex = 12;
            // 
            // IdSearchLabel
            // 
            IdSearchLabel.AutoSize = true;
            IdSearchLabel.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdSearchLabel.Location = new Point(31, 617);
            IdSearchLabel.Name = "IdSearchLabel";
            IdSearchLabel.Size = new Size(35, 21);
            IdSearchLabel.TabIndex = 13;
            IdSearchLabel.Text = "ID: ";
            IdSearchLabel.Click += IdSearchLabel_Click;
            // 
            // IdSearchBox
            // 
            IdSearchBox.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdSearchBox.Location = new Point(60, 614);
            IdSearchBox.Name = "IdSearchBox";
            IdSearchBox.Size = new Size(175, 29);
            IdSearchBox.TabIndex = 14;
            IdSearchBox.TextChanged += IdSearchBox_TextChanged;
            // 
            // TopCategoryCombo
            // 
            TopCategoryCombo.FormattingEnabled = true;
            TopCategoryCombo.Location = new Point(73, 41);
            TopCategoryCombo.Name = "TopCategoryCombo";
            TopCategoryCombo.Size = new Size(121, 23);
            TopCategoryCombo.TabIndex = 18;
            TopCategoryCombo.SelectedIndexChanged += TopCategoryCombo_SelectedIndexChanged;
            // 
            // MiddleCategoryCombo
            // 
            MiddleCategoryCombo.FormattingEnabled = true;
            MiddleCategoryCombo.Location = new Point(73, 82);
            MiddleCategoryCombo.Name = "MiddleCategoryCombo";
            MiddleCategoryCombo.Size = new Size(121, 23);
            MiddleCategoryCombo.TabIndex = 19;
            MiddleCategoryCombo.SelectedIndexChanged += MiddleCategoryCombo_SelectedIndexChanged;
            // 
            // BottomCategoryCombo
            // 
            BottomCategoryCombo.FormattingEnabled = true;
            BottomCategoryCombo.Location = new Point(73, 125);
            BottomCategoryCombo.Name = "BottomCategoryCombo";
            BottomCategoryCombo.Size = new Size(121, 23);
            BottomCategoryCombo.TabIndex = 20;
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
            SearchButton.Location = new Point(708, 35);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(168, 96);
            SearchButton.TabIndex = 21;
            SearchButton.Text = "검색";
            SearchButton.TextColor = Color.White;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
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
            RegisterButton.Location = new Point(708, 155);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(168, 96);
            RegisterButton.TabIndex = 22;
            RegisterButton.Text = "등록";
            RegisterButton.TextColor = Color.White;
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
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
            WorkMasterButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WorkMasterButton.ForeColor = Color.White;
            WorkMasterButton.Location = new Point(713, 609);
            WorkMasterButton.Name = "WorkMasterButton";
            WorkMasterButton.Size = new Size(150, 40);
            WorkMasterButton.TabIndex = 23;
            WorkMasterButton.Text = "업무 마스터";
            WorkMasterButton.TextColor = Color.White;
            WorkMasterButton.UseVisualStyleBackColor = false;
            WorkMasterButton.Click += WorkMasterButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(94, 159, 242);
            RemoveButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            RemoveButton.BorderColor = Color.PaleVioletRed;
            RemoveButton.BorderRadius = 20;
            RemoveButton.BorderSize = 0;
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(316, 609);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(150, 40);
            RemoveButton.TabIndex = 24;
            RemoveButton.Text = "삭제";
            RemoveButton.TextColor = Color.White;
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click_1;
            // 
            // ModifyButton
            // 
            ModifyButton.BackColor = Color.FromArgb(94, 159, 242);
            ModifyButton.BackgroundColor = Color.FromArgb(94, 159, 242);
            ModifyButton.BorderColor = Color.PaleVioletRed;
            ModifyButton.BorderRadius = 20;
            ModifyButton.BorderSize = 0;
            ModifyButton.FlatAppearance.BorderSize = 0;
            ModifyButton.FlatStyle = FlatStyle.Flat;
            ModifyButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyButton.ForeColor = Color.White;
            ModifyButton.Location = new Point(481, 609);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(150, 40);
            ModifyButton.TabIndex = 25;
            ModifyButton.Text = "수정";
            ModifyButton.TextColor = Color.White;
            ModifyButton.UseVisualStyleBackColor = false;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // customGroupBox1
            // 
            customGroupBox1.BackColor = Color.Transparent;
            customGroupBox1.Controls.Add(StartTime);
            customGroupBox1.Controls.Add(StartDay);
            customGroupBox1.Location = new Point(204, 26);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(218, 117);
            customGroupBox1.TabIndex = 26;
            customGroupBox1.TabStop = false;
            customGroupBox1.Text = "시작 시간";
            customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox1.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox1.TitleForeColor = Color.White;
            customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            customGroupBox1.Enter += customGroupBox1_Enter;
            // 
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(EndDay);
            customGroupBox2.Controls.Add(EndTime);
            customGroupBox2.Location = new Point(204, 155);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(218, 113);
            customGroupBox2.TabIndex = 27;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "종료 시간";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // WorkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(898, 672);
            Controls.Add(customGroupBox2);
            Controls.Add(customGroupBox1);
            Controls.Add(ModifyButton);
            Controls.Add(RemoveButton);
            Controls.Add(WorkMasterButton);
            Controls.Add(RegisterButton);
            Controls.Add(SearchButton);
            Controls.Add(BottomCategoryCombo);
            Controls.Add(MiddleCategoryCombo);
            Controls.Add(TopCategoryCombo);
            Controls.Add(IdSearchBox);
            Controls.Add(IdSearchLabel);
            Controls.Add(DataView);
            Controls.Add(WorkDetailBox);
            Controls.Add(BottomCategoryLabel);
            Controls.Add(MiddleCategoryLabel);
            Controls.Add(TopCatergoryLabel);
            Name = "WorkForm";
            Text = "Form1";
            Load += WorkForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            customGroupBox1.ResumeLayout(false);
            customGroupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TopCatergoryLabel;
        private Label MiddleCategoryLabel;
        private Label BottomCategoryLabel;
        private RichTextBox WorkDetailBox;
        private DateTimePicker StartTimeFrom;
        private TextBox IdSearchBox;
        private Label IdSearchLabel;
        private DataGridView DataView;
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
        private CustomButtonStyle SearchButton;
        private CustomButtonStyle RegisterButton;
        private CustomButtonStyle WorkMasterButton;
        private CustomButtonStyle RemoveButton;
        private CustomButtonStyle ModifyButton;
        private CustomGroupBox customGroupBox1;
        private CustomGroupBox customGroupBox2;
    }
}