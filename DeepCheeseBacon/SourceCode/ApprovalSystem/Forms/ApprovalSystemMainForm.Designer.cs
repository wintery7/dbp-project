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
        buttonCreateNewApproval = new Button();
        buttonCheckMyApprovalList = new Button();
        dataGridViewApprovalList = new DataGridView();
        dataGridViewTaskSummary = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewApprovalList).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewTaskSummary).BeginInit();
        SuspendLayout();
        // 
        // buttonCreateNewApproval
        // 
        buttonCreateNewApproval.Location = new Point(29, 38);
        buttonCreateNewApproval.Name = "buttonCreateNewApproval";
        buttonCreateNewApproval.Size = new Size(172, 23);
        buttonCreateNewApproval.TabIndex = 0;
        buttonCreateNewApproval.Text = "신규 결재 등록";
        buttonCreateNewApproval.UseVisualStyleBackColor = true;
        buttonCreateNewApproval.Click += buttonCreateNewApproval_Click;
        // 
        // buttonCheckMyApprovalList
        // 
        buttonCheckMyApprovalList.Location = new Point(29, 275);
        buttonCheckMyApprovalList.Name = "buttonCheckMyApprovalList";
        buttonCheckMyApprovalList.Size = new Size(172, 23);
        buttonCheckMyApprovalList.TabIndex = 4;
        buttonCheckMyApprovalList.Text = "나의 결재 리스트 확인";
        buttonCheckMyApprovalList.UseVisualStyleBackColor = true;
        buttonCheckMyApprovalList.Click += buttonCheckMyApprovalList_Click;
        // 
        // dataGridViewApprovalList
        // 
        dataGridViewApprovalList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewApprovalList.Location = new Point(29, 76);
        dataGridViewApprovalList.Name = "dataGridViewApprovalList";
        dataGridViewApprovalList.RowTemplate.Height = 25;
        dataGridViewApprovalList.Size = new Size(437, 150);
        dataGridViewApprovalList.TabIndex = 5;
        // 
        // dataGridViewTaskSummary
        // 
        dataGridViewTaskSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewTaskSummary.Location = new Point(29, 304);
        dataGridViewTaskSummary.Name = "dataGridViewTaskSummary";
        dataGridViewTaskSummary.Size = new Size(437, 150);
        dataGridViewTaskSummary.TabIndex = 6;
        // 
        // ApprovalSystemMainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1084, 661);
        Controls.Add(dataGridViewTaskSummary);
        Controls.Add(dataGridViewApprovalList);
        Controls.Add(buttonCheckMyApprovalList);
        Controls.Add(buttonCreateNewApproval);
        Name = "ApprovalSystemMainForm";
        Text = "ApprovalSystemMainForm";
        ((System.ComponentModel.ISupportInitialize)dataGridViewApprovalList).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewTaskSummary).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonCreateNewApproval;
    private Button buttonCheckMyApprovalList;
    private DataGridView dataGridViewApprovalList;
    private DataGridView dataGridViewTaskSummary;
}