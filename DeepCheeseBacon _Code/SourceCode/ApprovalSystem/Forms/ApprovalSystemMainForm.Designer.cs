using deepcheesebacon.work;

namespace deepcheesebacon;

partial class ApprovalSystemMainForm
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
        buttonCreateNewApproval = new Customizing.CustomButtonStyle();
        buttonCheckMyApprovalList = new Customizing.CustomButtonStyle();
        dataGridViewApprovalList = new DataGridView();
        dataGridViewTaskSummary = new DataGridView();
        customGroupBox1 = new Customizing.CustomGroupBox();
        customGroupBox2 = new Customizing.CustomGroupBox();
        ((System.ComponentModel.ISupportInitialize)dataGridViewApprovalList).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewTaskSummary).BeginInit();
        customGroupBox1.SuspendLayout();
        customGroupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // buttonCreateNewApproval
        // 
        buttonCreateNewApproval.BackColor = Color.FromArgb(94, 159, 242);
        buttonCreateNewApproval.BackgroundColor = Color.FromArgb(94, 159, 242);
        buttonCreateNewApproval.BorderColor = Color.PaleVioletRed;
        buttonCreateNewApproval.BorderRadius = 20;
        buttonCreateNewApproval.BorderSize = 0;
        buttonCreateNewApproval.FlatStyle = FlatStyle.Flat;
        buttonCreateNewApproval.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
        buttonCreateNewApproval.ForeColor = Color.White;
        buttonCreateNewApproval.Location = new Point(316, 573);
        buttonCreateNewApproval.Margin = new Padding(4);
        buttonCreateNewApproval.Name = "buttonCreateNewApproval";
        buttonCreateNewApproval.Size = new Size(161, 42);
        buttonCreateNewApproval.TabIndex = 21;
        buttonCreateNewApproval.Text = "신규 결재 등록";
        buttonCreateNewApproval.TextColor = Color.White;
        buttonCreateNewApproval.UseVisualStyleBackColor = false;
        buttonCreateNewApproval.Click += buttonCreateNewApproval_Click;
        // 
        // buttonCheckMyApprovalList
        // 
        buttonCheckMyApprovalList.BackColor = Color.FromArgb(94, 159, 242);
        buttonCheckMyApprovalList.BackgroundColor = Color.FromArgb(94, 159, 242);
        buttonCheckMyApprovalList.BorderColor = Color.PaleVioletRed;
        buttonCheckMyApprovalList.BorderRadius = 20;
        buttonCheckMyApprovalList.BorderSize = 0;
        buttonCheckMyApprovalList.FlatStyle = FlatStyle.Flat;
        buttonCheckMyApprovalList.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonCheckMyApprovalList.ForeColor = Color.White;
        buttonCheckMyApprovalList.Location = new Point(758, 574);
        buttonCheckMyApprovalList.Margin = new Padding(4);
        buttonCheckMyApprovalList.Name = "buttonCheckMyApprovalList";
        buttonCheckMyApprovalList.Size = new Size(195, 42);
        buttonCheckMyApprovalList.TabIndex = 4;
        buttonCheckMyApprovalList.Text = "나의 결재 리스트 확인";
        buttonCheckMyApprovalList.TextColor = Color.White;
        buttonCheckMyApprovalList.UseVisualStyleBackColor = false;
        buttonCheckMyApprovalList.Click += buttonCheckMyApprovalList_Click;
        // 
        // dataGridViewApprovalList
        // 
        dataGridViewApprovalList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewApprovalList.Location = new Point(8, 48);
        dataGridViewApprovalList.Margin = new Padding(4);
        dataGridViewApprovalList.Name = "dataGridViewApprovalList";
        dataGridViewApprovalList.RowHeadersWidth = 51;
        dataGridViewApprovalList.RowTemplate.Height = 25;
        dataGridViewApprovalList.Size = new Size(448, 427);
        dataGridViewApprovalList.TabIndex = 5;
        // 
        // dataGridViewTaskSummary
        // 
        dataGridViewTaskSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewTaskSummary.Location = new Point(11, 48);
        dataGridViewTaskSummary.Margin = new Padding(4);
        dataGridViewTaskSummary.Name = "dataGridViewTaskSummary";
        dataGridViewTaskSummary.RowHeadersWidth = 51;
        dataGridViewTaskSummary.Size = new Size(440, 428);
        dataGridViewTaskSummary.TabIndex = 6;
        // 
        // customGroupBox1
        // 
        customGroupBox1.BackColor = Color.Transparent;
        customGroupBox1.Controls.Add(dataGridViewApprovalList);
        customGroupBox1.Location = new Point(13, 82);
        customGroupBox1.Margin = new Padding(4);
        customGroupBox1.Name = "customGroupBox1";
        customGroupBox1.Padding = new Padding(4);
        customGroupBox1.Radious = 25;
        customGroupBox1.Size = new Size(464, 483);
        customGroupBox1.TabIndex = 27;
        customGroupBox1.TabStop = false;
        customGroupBox1.Text = "진행 중인 결재 목록";
        customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
        customGroupBox1.TitleFont = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
        customGroupBox1.TitleForeColor = Color.White;
        customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
        // 
        // customGroupBox2
        // 
        customGroupBox2.BackColor = Color.Transparent;
        customGroupBox2.Controls.Add(dataGridViewTaskSummary);
        customGroupBox2.Location = new Point(494, 82);
        customGroupBox2.Margin = new Padding(4);
        customGroupBox2.Name = "customGroupBox2";
        customGroupBox2.Padding = new Padding(4);
        customGroupBox2.Radious = 25;
        customGroupBox2.Size = new Size(459, 484);
        customGroupBox2.TabIndex = 28;
        customGroupBox2.TabStop = false;
        customGroupBox2.Text = "결재 업무 요약";
        customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
        customGroupBox2.TitleFont = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
        customGroupBox2.TitleForeColor = Color.White;
        customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
        // 
        // ApprovalSystemMainForm
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(966, 659);
        Controls.Add(customGroupBox2);
        Controls.Add(customGroupBox1);
        Controls.Add(buttonCheckMyApprovalList);
        Controls.Add(buttonCreateNewApproval);
        Margin = new Padding(4);
        Name = "ApprovalSystemMainForm";
        Text = "ApprovalSystemMainForm";
        ((System.ComponentModel.ISupportInitialize)dataGridViewApprovalList).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewTaskSummary).EndInit();
        customGroupBox1.ResumeLayout(false);
        customGroupBox2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private DataGridView dataGridViewApprovalList;
    private DataGridView dataGridViewTaskSummary;
    private Customizing.CustomButtonStyle buttonCreateNewApproval;
    private Customizing.CustomButtonStyle buttonCheckMyApprovalList;
    private Customizing.CustomGroupBox customGroupBox1;
    private Customizing.CustomGroupBox customGroupBox2;
}