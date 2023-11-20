using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deepcheesebacon
{
    public partial class RejectForm : Form
    {
        private string memo;
        public RejectForm()
        {
            InitializeComponent();
        }
        public string GetMemo()
        {
            return memo;
        }

        private void buttonRejectApproval_Click(object sender, EventArgs e)
        {
            memo = textBoxMemo.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void RejectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
