using deepcheesebacon.Work;

namespace deepcheesebacon {
    public partial class WorkForm : Form {
        DBHandlerForWork db;
        public WorkForm() {
            InitializeComponent();
            //DB = DBHandler.Instance();
            //DB.setTopCategoryItem(this.TopCategoryCombo, this.MiddleCategoryCombo, this.BottomCategoryCombo);
            //SetCustomTimePicker();

            InitDatabase();
        }

        private void InitDatabase() {
            DBHandlerForWork.Instance.SetDBSource("34.64.40.193", "deep_cheese", "seoungjun", "1234", "utf8");
            db = DBHandlerForWork.Instance;
        }






        /*
        private void SetCustomTimePicker() {
            this.StartTime.Format = DateTimePickerFormat.Custom;
            this.StartTime.CustomFormat = "HH:mm";
            this.EndTime.Format = DateTimePickerFormat.Custom;
            this.EndTime.CustomFormat = "HH:mm";
        }
        */

        private void MiddleCategoryCombo_SelectedIndexChanged(object sender, EventArgs e) {
            //DB.setBottomCategory(this.BottomCategoryCombo, TopCategoryCombo.SelectedItem.ToString(), MiddleCategoryCombo.SelectedItem.ToString());
        }

        private void TopCategoryCombo_SelectedIndexChanged(object sender, EventArgs e) {
            //DB.setMiddleCategory(MiddleCategoryCombo, this.BottomCategoryCombo, TopCategoryCombo.SelectedItem.ToString());
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            /*
            string topCategory = this.TopCategoryCombo.Text;
            string middleCategory = this.MiddleCategoryCombo.Text;
            string bottomCategory = this.BottomCategoryCombo.Text;
            if (topCategory.Length == 0 || middleCategory.Length == 0 || bottomCategory.Length == 0) {
                MessageBox.Show("작업 카테고리를 모두 선택해주세요.");
            } else {
                DB.searchResult(topCategory, middleCategory, bottomCategory, this.DataView);
            }
            */
        }

        private void RegisterButton_Click(object sender, EventArgs e) {
            /*
            DateTime startday = this.StartDay.Value.Date;
            DateTime starttime = this.StartTime.Value;

            DateTime start = startday.AddHours(starttime.Hour).AddMinutes(starttime.Minute);

            DateTime endday = this.EndDay.Value.Date;
            DateTime endtime = this.EndTime.Value;

            DateTime end = endday.AddHours(endtime.Hour).AddMinutes(endtime.Minute);

            string contents = this.WorkDetailBox.Text;
            string topCategory = this.TopCategoryCombo.Text;
            string middleCategory = this.MiddleCategoryCombo.Text;
            string bottomCategory = this.BottomCategoryCombo.Text;

            DB.insertWork(topCategory, middleCategory, bottomCategory, start, end, contents);
            */
        }

        private void WorkMasterButton_Click(object sender, EventArgs e) {
            Form form = new WorkMasterForm();
            form.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e) {

        }

        private void ModifyButton_Click(object sender, EventArgs e) {

        }

        private void WorkDetailBox_TextChanged(object sender, EventArgs e) {

        }

        private void IdSearchBox_TextChanged(object sender, EventArgs e) {

        }

        private void IdSearchLabel_Click(object sender, EventArgs e) {

        }

        private void customGroupBox1_Enter(object sender, EventArgs e) {

        }

        private void WorkForm_Load(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}