﻿using deepcheesebacon.Customizing;

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
            StartTime = new CustomDatePicker();
            StartDay = new CustomDatePicker();
            EndTime = new CustomDatePicker();
            EndDay = new CustomDatePicker();
            WorkDetailBox = new RichTextBox();
            DataView = new DataGridView();
            TopCategoryCombo = new CustomComboBox();
            MiddleCategoryCombo = new CustomComboBox();
            BottomCategoryCombo = new CustomComboBox();
            SearchButton = new CustomButtonStyle();
            RegisterButton = new CustomButtonStyle();
            WorkMasterButton = new CustomButtonStyle();
            RemoveButton = new CustomButtonStyle();
            ModifyButton = new CustomButtonStyle();
            customGroupBox1 = new CustomGroupBox();
            customGroupBox2 = new CustomGroupBox();
            IdSearchBox = new CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            customGroupBox1.SuspendLayout();
            customGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TopCatergoryLabel
            // 
            TopCatergoryLabel.AutoSize = true;
            TopCatergoryLabel.Location = new Point(30, 59);
            TopCatergoryLabel.Margin = new Padding(4, 0, 4, 0);
            TopCatergoryLabel.Name = "TopCatergoryLabel";
            TopCatergoryLabel.Size = new Size(54, 20);
            TopCatergoryLabel.TabIndex = 0;
            TopCatergoryLabel.Text = "대분류";
            // 
            // MiddleCategoryLabel
            // 
            MiddleCategoryLabel.AutoSize = true;
            MiddleCategoryLabel.Location = new Point(30, 113);
            MiddleCategoryLabel.Margin = new Padding(4, 0, 4, 0);
            MiddleCategoryLabel.Name = "MiddleCategoryLabel";
            MiddleCategoryLabel.Size = new Size(54, 20);
            MiddleCategoryLabel.TabIndex = 1;
            MiddleCategoryLabel.Text = "중분류";
            // 
            // BottomCategoryLabel
            // 
            BottomCategoryLabel.AutoSize = true;
            BottomCategoryLabel.Location = new Point(30, 171);
            BottomCategoryLabel.Margin = new Padding(4, 0, 4, 0);
            BottomCategoryLabel.Name = "BottomCategoryLabel";
            BottomCategoryLabel.Size = new Size(54, 20);
            BottomCategoryLabel.TabIndex = 2;
            BottomCategoryLabel.Text = "소분류";
            // 
            // StartTime
            // 
            StartTime.BorderColor = Color.FromArgb(4, 96, 217);
            StartTime.BorderSize = 2;
            StartTime.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            StartTime.Format = DateTimePickerFormat.Time;
            StartTime.Location = new Point(18, 104);
            StartTime.Margin = new Padding(4);
            StartTime.MinimumSize = new Size(0, 35);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(241, 35);
            StartTime.SkinColor = SystemColors.Window;
            StartTime.TabIndex = 1;
            StartTime.TextColor = Color.DimGray;
            // 
            // StartDay
            // 
            StartDay.BorderColor = Color.FromArgb(4, 96, 217);
            StartDay.BorderSize = 2;
            StartDay.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            StartDay.Location = new Point(18, 65);
            StartDay.Margin = new Padding(4);
            StartDay.MinimumSize = new Size(0, 35);
            StartDay.Name = "StartDay";
            StartDay.Size = new Size(241, 35);
            StartDay.SkinColor = SystemColors.Window;
            StartDay.TabIndex = 0;
            StartDay.TextColor = Color.DimGray;
            // 
            // EndTime
            // 
            EndTime.BorderColor = Color.FromArgb(4, 96, 217);
            EndTime.BorderSize = 2;
            EndTime.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            EndTime.Format = DateTimePickerFormat.Time;
            EndTime.Location = new Point(18, 101);
            EndTime.Margin = new Padding(4);
            EndTime.MinimumSize = new Size(0, 35);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(241, 35);
            EndTime.SkinColor = SystemColors.Window;
            EndTime.TabIndex = 12;
            EndTime.TextColor = Color.DimGray;
            // 
            // EndDay
            // 
            EndDay.BorderColor = Color.FromArgb(4, 96, 217);
            EndDay.BorderSize = 2;
            EndDay.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            EndDay.Location = new Point(18, 63);
            EndDay.Margin = new Padding(4);
            EndDay.MinimumSize = new Size(0, 35);
            EndDay.Name = "EndDay";
            EndDay.Size = new Size(241, 35);
            EndDay.SkinColor = SystemColors.Window;
            EndDay.TabIndex = 2;
            EndDay.TextColor = Color.DimGray;
            // 
            // WorkDetailBox
            // 
            WorkDetailBox.Location = new Point(566, 47);
            WorkDetailBox.Margin = new Padding(4);
            WorkDetailBox.Name = "WorkDetailBox";
            WorkDetailBox.Size = new Size(309, 292);
            WorkDetailBox.TabIndex = 8;
            WorkDetailBox.Text = "";
            WorkDetailBox.TextChanged += WorkDetailBox_TextChanged;
            // 
            // DataView
            // 
            DataView.BackgroundColor = Color.White;
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(35, 397);
            DataView.Margin = new Padding(4);
            DataView.Name = "DataView";
            DataView.ReadOnly = true;
            DataView.RowHeadersWidth = 51;
            DataView.RowTemplate.Height = 25;
            DataView.Size = new Size(1075, 372);
            DataView.TabIndex = 12;
            // 
            // TopCategoryCombo
            // 
            TopCategoryCombo.BackColor = Color.FromArgb(94, 159, 242);
            TopCategoryCombo.BorderColor = Color.FromArgb(242, 242, 242);
            TopCategoryCombo.BorderSize = 1;
            TopCategoryCombo.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TopCategoryCombo.ForeColor = Color.DimGray;
            TopCategoryCombo.FormattingEnabled = true;
            TopCategoryCombo.IconColor = Color.White;
            TopCategoryCombo.ListBackColor = Color.FromArgb(230, 228, 245);
            TopCategoryCombo.ListTextColor = Color.DimGray;
            TopCategoryCombo.Location = new Point(94, 55);
            TopCategoryCombo.Margin = new Padding(4);
            TopCategoryCombo.MinimumSize = new Size(160, 0);
            TopCategoryCombo.Name = "TopCategoryCombo";
            TopCategoryCombo.Size = new Size(160, 31);
            TopCategoryCombo.TabIndex = 18;
            TopCategoryCombo.Texts = "";
            TopCategoryCombo.SelectedIndexChanged += TopCategoryCombo_SelectedIndexChanged;
            // 
            // MiddleCategoryCombo
            // 
            MiddleCategoryCombo.BackColor = Color.FromArgb(94, 159, 242);
            MiddleCategoryCombo.BorderColor = Color.FromArgb(242, 242, 242);
            MiddleCategoryCombo.BorderSize = 1;
            MiddleCategoryCombo.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleCategoryCombo.ForeColor = Color.DimGray;
            MiddleCategoryCombo.FormattingEnabled = true;
            MiddleCategoryCombo.IconColor = Color.White;
            MiddleCategoryCombo.ListBackColor = Color.FromArgb(230, 228, 245);
            MiddleCategoryCombo.ListTextColor = Color.DimGray;
            MiddleCategoryCombo.Location = new Point(94, 109);
            MiddleCategoryCombo.Margin = new Padding(4);
            MiddleCategoryCombo.MinimumSize = new Size(160, 0);
            MiddleCategoryCombo.Name = "MiddleCategoryCombo";
            MiddleCategoryCombo.Size = new Size(160, 31);
            MiddleCategoryCombo.TabIndex = 19;
            MiddleCategoryCombo.Texts = "";
            MiddleCategoryCombo.SelectedIndexChanged += MiddleCategoryCombo_SelectedIndexChanged;
            // 
            // BottomCategoryCombo
            // 
            BottomCategoryCombo.BackColor = Color.FromArgb(94, 159, 242);
            BottomCategoryCombo.BorderColor = Color.FromArgb(242, 242, 242);
            BottomCategoryCombo.BorderSize = 1;
            BottomCategoryCombo.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BottomCategoryCombo.ForeColor = Color.DimGray;
            BottomCategoryCombo.FormattingEnabled = true;
            BottomCategoryCombo.IconColor = Color.White;
            BottomCategoryCombo.ListBackColor = Color.FromArgb(230, 228, 245);
            BottomCategoryCombo.ListTextColor = Color.DimGray;
            BottomCategoryCombo.Location = new Point(94, 167);
            BottomCategoryCombo.Margin = new Padding(4);
            BottomCategoryCombo.MinimumSize = new Size(160, 0);
            BottomCategoryCombo.Name = "BottomCategoryCombo";
            BottomCategoryCombo.Size = new Size(160, 31);
            BottomCategoryCombo.TabIndex = 20;
            BottomCategoryCombo.Texts = "";
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
            SearchButton.Location = new Point(910, 47);
            SearchButton.Margin = new Padding(4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(216, 128);
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
            RegisterButton.Location = new Point(910, 207);
            RegisterButton.Margin = new Padding(4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(216, 128);
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
            WorkMasterButton.Location = new Point(917, 812);
            WorkMasterButton.Margin = new Padding(4);
            WorkMasterButton.Name = "WorkMasterButton";
            WorkMasterButton.Size = new Size(193, 53);
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
            RemoveButton.Location = new Point(406, 812);
            RemoveButton.Margin = new Padding(4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(193, 53);
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
            ModifyButton.Location = new Point(618, 812);
            ModifyButton.Margin = new Padding(4);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(193, 53);
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
            customGroupBox1.Location = new Point(262, 35);
            customGroupBox1.Margin = new Padding(4);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Padding = new Padding(4);
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(280, 156);
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
            customGroupBox2.Location = new Point(262, 207);
            customGroupBox2.Margin = new Padding(4);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(4);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(280, 151);
            customGroupBox2.TabIndex = 27;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "종료 시간";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // IdSearchBox
            // 
            IdSearchBox.BackColor = SystemColors.Window;
            IdSearchBox.BorderColor = Color.FromArgb(94, 159, 242);
            IdSearchBox.BorderFocusColor = Color.FromArgb(4, 96, 217);
            IdSearchBox.BorderRadius = 0;
            IdSearchBox.BorderSize = 2;
            IdSearchBox.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            IdSearchBox.ForeColor = Color.DimGray;
            IdSearchBox.Location = new Point(35, 825);
            IdSearchBox.Multiline = false;
            IdSearchBox.Name = "IdSearchBox";
            IdSearchBox.Padding = new Padding(10, 7, 10, 7);
            IdSearchBox.PasswordChar = false;
            IdSearchBox.PlaceholderColor = Color.DarkGray;
            IdSearchBox.PlaceholderText = "ID를 입력하세요.";
            IdSearchBox.Size = new Size(272, 36);
            IdSearchBox.TabIndex = 28;
            IdSearchBox.Texts = "";
            IdSearchBox.UnderlinedStyle = true;
            // 
            // WorkForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1155, 896);
            Controls.Add(IdSearchBox);
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
            Controls.Add(DataView);
            Controls.Add(WorkDetailBox);
            Controls.Add(BottomCategoryLabel);
            Controls.Add(MiddleCategoryLabel);
            Controls.Add(TopCatergoryLabel);
            Margin = new Padding(4);
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
        private DataGridView DataView;
        private DateTimePicker EndTimeTo;
        private DateTimePicker EndTimeFrom;
        private DateTimePicker StartTimeTo;
        private CustomButtonStyle SearchButton;
        private CustomButtonStyle RegisterButton;
        private CustomButtonStyle WorkMasterButton;
        private CustomButtonStyle RemoveButton;
        private CustomButtonStyle ModifyButton;
        private CustomGroupBox customGroupBox1;
        private CustomGroupBox customGroupBox2;
        private CustomComboBox BottomCategoryCombo;
        private CustomComboBox MiddleCategoryCombo;
        private CustomComboBox TopCategoryCombo;
        private CustomDatePicker StartTime;
        private CustomDatePicker StartDay;
        private CustomDatePicker EndTime;
        private CustomDatePicker EndDay;
        private CustomTextBox IdSearchBox;
    }
}