namespace deepcheesebacon {
    public partial class UIForm : Form {
        private Form activeForm;
        public UIForm() {
            InitializeComponent();
            activeForm = null;
        }

        private void UIForm_Load(object sender, EventArgs e) {

        }
        private void OpenChildForm(Form childForm, object btnSender) {
            if (activeForm != null) {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button3_Click(object sender, EventArgs e) {
            OpenChildForm(new WorkForm(), sender);
        }

        private void button6_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
