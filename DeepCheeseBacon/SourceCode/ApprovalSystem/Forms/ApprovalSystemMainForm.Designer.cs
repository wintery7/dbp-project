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
        buttonCreateNewApproval = new System.Windows.Forms.Button();
        buttonCheckMyApprovalList = new System.Windows.Forms.Button();
        dataGridViewApprovalList = new System.Windows.Forms.DataGridView();
        dataGridViewTaskSummary = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewApprovalList).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewTaskSummary).BeginInit();
        SuspendLayout();
        // 
        // buttonCreateNewApproval
        // 
        buttonCreateNewApproval.Location = new System.Drawing.Point(53, 95);
        buttonCreateNewApproval.Name = "buttonCreateNewApproval";
        buttonCreateNewApproval.Size = new System.Drawing.Size(172, 23);
        buttonCreateNewApproval.TabIndex = 0;
        buttonCreateNewApproval.Text = "신규 결재 등록";
        buttonCreateNewApproval.UseVisualStyleBackColor = true;
        buttonCreateNewApproval.Click += buttonCreateNewApproval_Click;
        // 
        // buttonCheckMyApprovalList
        // 
        buttonCheckMyApprovalList.Location = new System.Drawing.Point(53, 332);
        buttonCheckMyApprovalList.Name = "buttonCheckMyApprovalList";
        buttonCheckMyApprovalList.Size = new System.Drawing.Size(172, 23);
        buttonCheckMyApprovalList.TabIndex = 4;
        buttonCheckMyApprovalList.Text = "나의 결재 리스트 확인";
        buttonCheckMyApprovalList.UseVisualStyleBackColor = true;
        buttonCheckMyApprovalList.Click += buttonCheckMyApprovalList_Click;
        // 
        // dataGridViewApprovalList
        // 
        dataGridViewApprovalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewApprovalList.Location = new System.Drawing.Point(53, 133);
        dataGridViewApprovalList.Name = "dataGridViewApprovalList";
        dataGridViewApprovalList.RowTemplate.Height = 25;
        dataGridViewApprovalList.Size = new System.Drawing.Size(437, 150);
        dataGridViewApprovalList.TabIndex = 5;
        // 
        // dataGridViewTaskSummary
        // 
        dataGridViewTaskSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewTaskSummary.Location = new System.Drawing.Point(53, 361);
        dataGridViewTaskSummary.Name = "dataGridViewTaskSummary";
        dataGridViewTaskSummary.Size = new System.Drawing.Size(437, 150);
        dataGridViewTaskSummary.TabIndex = 6;
        // 
        // ApprovalSystemMainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1084, 661);
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

    private System.Windows.Forms.Button buttonCreateNewApproval;
    private System.Windows.Forms.Button buttonCheckMyApprovalList;
    private System.Windows.Forms.DataGridView dataGridViewApprovalList;
    private System.Windows.Forms.DataGridView dataGridViewTaskSummary;
}