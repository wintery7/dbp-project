using deepcheesebacon.Customizing;

namespace deepcheesebacon
{
    partial class WorkMasterForm
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
            TopCategorygGroup = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            BottomCategoryBox = new TextBox();
            MiddleCategoryBox = new TextBox();
            CategoryRegister = new CustomButtonStyle();
            TopCategoryBox = new TextBox();
            CategoryList = new DataGridView();
            CategoryID = new TextBox();
            CategoryDelete = new CustomButtonStyle();
            CategoryEdit = new CustomButtonStyle();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            BottomCategoryEdit = new TextBox();
            MiddleCategoryEdit = new TextBox();
            TopCategoryEdit = new TextBox();
            TopCategorygGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryList).BeginInit();
            SuspendLayout();
            // 
            // TopCategorygGroup
            // 
            TopCategorygGroup.Controls.Add(label6);
            TopCategorygGroup.Controls.Add(label5);
            TopCategorygGroup.Controls.Add(label4);
            TopCategorygGroup.Controls.Add(BottomCategoryBox);
            TopCategorygGroup.Controls.Add(MiddleCategoryBox);
            TopCategorygGroup.Controls.Add(CategoryRegister);
            TopCategorygGroup.Controls.Add(TopCategoryBox);
            TopCategorygGroup.Location = new Point(33, 36);
            TopCategorygGroup.Margin = new Padding(4, 4, 4, 4);
            TopCategorygGroup.Name = "TopCategorygGroup";
            TopCategorygGroup.Padding = new Padding(4, 4, 4, 4);
            TopCategorygGroup.Size = new Size(971, 100);
            TopCategorygGroup.TabIndex = 0;
            TopCategorygGroup.TabStop = false;
            TopCategorygGroup.Text = "카테고리 입력란";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(540, 36);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 15;
            label6.Text = "소분류";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 14;
            label5.Text = "중분류";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 13;
            label4.Text = "대분류";
            // 
            // BottomCategoryBox
            // 
            BottomCategoryBox.Location = new Point(540, 60);
            BottomCategoryBox.Margin = new Padding(4, 4, 4, 4);
            BottomCategoryBox.Name = "BottomCategoryBox";
            BottomCategoryBox.Size = new Size(201, 27);
            BottomCategoryBox.TabIndex = 3;
            // 
            // MiddleCategoryBox
            // 
            MiddleCategoryBox.Location = new Point(301, 60);
            MiddleCategoryBox.Margin = new Padding(4, 4, 4, 4);
            MiddleCategoryBox.Name = "MiddleCategoryBox";
            MiddleCategoryBox.Size = new Size(201, 27);
            MiddleCategoryBox.TabIndex = 2;
            MiddleCategoryBox.TextChanged += MiddleCategoryBox_TextChanged;
            // 
            // CategoryRegister
            // 
            CategoryRegister.BackColor = SystemColors.Window;
            CategoryRegister.BackgroundColor = SystemColors.Window;
            CategoryRegister.BorderColor = Color.FromArgb(4, 96, 217);
            CategoryRegister.BorderRadius = 10;
            CategoryRegister.BorderSize = 2;
            CategoryRegister.FlatStyle = FlatStyle.Flat;
            CategoryRegister.ForeColor = Color.DarkBlue;
            CategoryRegister.Location = new Point(769, 60);
            CategoryRegister.Margin = new Padding(4, 4, 4, 4);
            CategoryRegister.Name = "CategoryRegister";
            CategoryRegister.Size = new Size(188, 30);
            CategoryRegister.TabIndex = 1;
            CategoryRegister.Text = "등록";
            CategoryRegister.TextColor = Color.DarkBlue;
            CategoryRegister.UseVisualStyleBackColor = false;
            CategoryRegister.Click += CategoryRegister_Click;
            // 
            // TopCategoryBox
            // 
            TopCategoryBox.Location = new Point(33, 60);
            TopCategoryBox.Margin = new Padding(4, 4, 4, 4);
            TopCategoryBox.Name = "TopCategoryBox";
            TopCategoryBox.Size = new Size(201, 27);
            TopCategoryBox.TabIndex = 0;
            // 
            // CategoryList
            // 
            CategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryList.Location = new Point(33, 171);
            CategoryList.Margin = new Padding(4, 4, 4, 4);
            CategoryList.Name = "CategoryList";
            CategoryList.RowHeadersWidth = 82;
            CategoryList.RowTemplate.Height = 25;
            CategoryList.Size = new Size(971, 707);
            CategoryList.TabIndex = 2;
            // 
            // CategoryID
            // 
            CategoryID.Location = new Point(62, 909);
            CategoryID.Margin = new Padding(4, 4, 4, 4);
            CategoryID.Name = "CategoryID";
            CategoryID.Size = new Size(201, 27);
            CategoryID.TabIndex = 6;
            // 
            // CategoryDelete
            // 
            CategoryDelete.BackColor = SystemColors.Window;
            CategoryDelete.BackgroundColor = SystemColors.Window;
            CategoryDelete.BorderColor = Color.FromArgb(4, 96, 217);
            CategoryDelete.BorderRadius = 10;
            CategoryDelete.BorderSize = 2;
            CategoryDelete.FlatStyle = FlatStyle.Flat;
            CategoryDelete.ForeColor = Color.DarkBlue;
            CategoryDelete.Location = new Point(811, 909);
            CategoryDelete.Margin = new Padding(4, 4, 4, 4);
            CategoryDelete.Name = "CategoryDelete";
            CategoryDelete.Size = new Size(188, 30);
            CategoryDelete.TabIndex = 8;
            CategoryDelete.Text = "삭제";
            CategoryDelete.TextColor = Color.DarkBlue;
            CategoryDelete.UseVisualStyleBackColor = false;
            CategoryDelete.Click += CategoryDelete_Click;
            // 
            // CategoryEdit
            // 
            CategoryEdit.BackColor = SystemColors.Window;
            CategoryEdit.BackgroundColor = SystemColors.Window;
            CategoryEdit.BorderColor = Color.FromArgb(4, 96, 217);
            CategoryEdit.BorderRadius = 10;
            CategoryEdit.BorderSize = 2;
            CategoryEdit.FlatStyle = FlatStyle.Flat;
            CategoryEdit.ForeColor = Color.DarkBlue;
            CategoryEdit.Location = new Point(811, 983);
            CategoryEdit.Margin = new Padding(4, 4, 4, 4);
            CategoryEdit.Name = "CategoryEdit";
            CategoryEdit.Size = new Size(188, 30);
            CategoryEdit.TabIndex = 9;
            CategoryEdit.Text = "수정";
            CategoryEdit.TextColor = Color.DarkBlue;
            CategoryEdit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 909);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 959);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 21;
            label1.Text = "소분류";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 959);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 20;
            label7.Text = "중분류";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 959);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 19;
            label8.Text = "대분류";
            // 
            // BottomCategoryEdit
            // 
            BottomCategoryEdit.Location = new Point(543, 983);
            BottomCategoryEdit.Margin = new Padding(4, 4, 4, 4);
            BottomCategoryEdit.Name = "BottomCategoryEdit";
            BottomCategoryEdit.Size = new Size(201, 27);
            BottomCategoryEdit.TabIndex = 18;
            // 
            // MiddleCategoryEdit
            // 
            MiddleCategoryEdit.Location = new Point(301, 983);
            MiddleCategoryEdit.Margin = new Padding(4, 4, 4, 4);
            MiddleCategoryEdit.Name = "MiddleCategoryEdit";
            MiddleCategoryEdit.Size = new Size(201, 27);
            MiddleCategoryEdit.TabIndex = 17;
            MiddleCategoryEdit.TextChanged += MiddleCategoryEdit_TextChanged;
            // 
            // TopCategoryEdit
            // 
            TopCategoryEdit.Location = new Point(62, 983);
            TopCategoryEdit.Margin = new Padding(4, 4, 4, 4);
            TopCategoryEdit.Name = "TopCategoryEdit";
            TopCategoryEdit.Size = new Size(201, 27);
            TopCategoryEdit.TabIndex = 16;
            // 
            // WorkMasterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 1055);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(CategoryEdit);
            Controls.Add(BottomCategoryEdit);
            Controls.Add(CategoryDelete);
            Controls.Add(MiddleCategoryEdit);
            Controls.Add(TopCategoryEdit);
            Controls.Add(CategoryID);
            Controls.Add(CategoryList);
            Controls.Add(TopCategorygGroup);
            Margin = new Padding(4, 4, 4, 4);
            Name = "WorkMasterForm";
            Text = "Form2";
            TopCategorygGroup.ResumeLayout(false);
            TopCategorygGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox TopCategorygGroup;
        private TextBox TopCategoryBox;
        private GroupBox MiddleCategorygGroup;
        private ComboBox TopCategoryCombo;
        private Button MiddleCategoryRegi;
        private GroupBox BottomCategorygGroup;
        private Button BottomCategoryRegi;
        private DataGridView CategoryList;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private TextBox textBox7;
        private TextBox CategoryID;
        private TextBox textBox9;
        private ComboBox MiddleCategoryCombo;
        private ComboBox TopCategoryCombo2;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox BottomCategoryBox;
        private TextBox MiddleCategoryBox;
        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox BottomCategoryEdit;
        private TextBox MiddleCategoryEdit;
        private TextBox TopCategoryEdit;
        private Label label3;
        private CustomButtonStyle CategoryRegister;
        private CustomButtonStyle CategoryDelete;
        private CustomButtonStyle CategoryEdit;
    }
}