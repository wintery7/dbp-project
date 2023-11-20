using deepcheesebacon.Work;
using MySql.Data.MySqlClient;

namespace deepcheesebacon {
    public partial class WorkMasterForm : Form {
        DBHandlerForWork db;
        public WorkMasterForm() {
            InitializeComponent();
            InitDatabase();
            LoadCategoryList();
        }

        /* ----- Database Init ----- */
        private void InitDatabase() {
            db = DBHandlerForWork.Instance;
        }

        /* ----- Category List Load ----- */
        private void LoadCategoryList() {
            MySqlDataReader dr = db.Select("*").From("work_category").Exec();

            db.SetDataSource(dr, CategoryList);

            dr.Close();
        }

        /* ----- Insert Category ----- */
        private void CategoryRegister_Click(object sender, EventArgs e) {
            string topCategory = TopCategoryBox.Text;
            string middleCategory = MiddleCategoryBox.Text;
            string bottomCategory = BottomCategoryBox.Text;

            MySqlDataReader dr = db.Select("EXISTS (SELECT * FROM work_category").Where($"top_category='{topCategory}' AND" +
                $" middle_category='{middleCategory}' AND bottom_category='{bottomCategory}' LIMIT 1) AS result").Exec();

            if (dr.Read()) {
                string result = dr.GetString("result");
                dr.Close();

                if (result == "1") {
                    Log.Instance.Here("Is Exist");
                } else {
                    db.Insert("work_category").Values($"NULL, '{topCategory}', '{middleCategory}', '{bottomCategory}'").ExecNon();

                    LoadCategoryList();
                }
            }
        }

        /* ----- Delete Category ----- */
        private void CategoryDelete_Click(object sender, EventArgs e) {
            string categoryId = CategoryID.Text;

            bool error = db.Delete("work_category").Where($"category_id={categoryId}").ExecNon();

            if (!error) {
                Log.Instance.Here("Success");

                LoadCategoryList();
            } else {
                Log.Instance.Here("Fail");
            }
        }

        private void MiddleCategoryEdit_TextChanged(object sender, EventArgs e) {

        }
    }
}