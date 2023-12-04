using deepcheesebacon.Work;
using MySql.Data.MySqlClient;

namespace deepcheesebacon
{
    public partial class WorkMasterForm : Form
    {
        DBHandlerForWork db;
        Log log;
        public WorkMasterForm()
        {
            InitializeComponent();
            InitDatabase();

            LoadCategoryList();
        }

        /* ----- Database Init ----- */
        private void InitDatabase()
        {
            db = DBHandlerForWork.Instance;
            log = Log.Instance;
        }

        /* ----- Category List Load ----- */
        private void LoadCategoryList()
        {
            MySqlDataReader dr = db.Select("*").From("work_category").Exec();

            db.SetDataSource(dr, CategoryList);

            dr.Close();
        }

        /* ----- Insert Category ----- */
        private void CategoryRegister_Click_1(object sender, EventArgs e)
        {
            string topCategory = TopCategoryBox.Text;
            string middleCategory = MiddleCategoryBox.Text;
            string bottomCategory = BottomCategoryBox.Text;

            if (topCategory == "" || middleCategory == "" || bottomCategory == "")
            {
                log.Here("잘못된 입력입니다.");

                return;
            }

            MySqlDataReader dr = db.Select("EXISTS (SELECT * FROM work_category").Where($"top_category='{topCategory}' AND" +
                $" middle_category='{middleCategory}' AND bottom_category='{bottomCategory}' LIMIT 1) AS result").Exec();

            if (dr.Read())
            {
                string result = dr.GetString("result");

                dr.Close();
                if (result == "1")
                {
                    log.Here("Is Exist");
                }
                else
                {
                    db.Insert("work_category").Values($"NULL, '{topCategory}', '{middleCategory}', '{bottomCategory}'").ExecNon();

                    LoadCategoryList();
                }
            }
        }

        /* ----- Delete Category ----- */
        private void CategoryDelete_Click_1(object sender, EventArgs e)
        {
            string categoryId = CategoryID.Text;
            bool error = db.Delete("work_category").Where($"category_id={categoryId}").ExecNon();

            if (error)
            {
                log.Here("CATEGORY DELETE ERROR");

                return;
            }

            LoadCategoryList();
        }

        /* ----- Edit Category ----- */
        private void CategoryEdit_Click(object sender, EventArgs e)
        {
            string categoryId = CategoryID.Text;
            string topCategory = TopCategoryEdit.Text;
            string middleCategory = MiddleCategoryEdit.Text;
            string bottomCategory = BottomCategoryEdit.Text;

            if (topCategory == "" || middleCategory == "" || bottomCategory == "")
            {
                log.Here("잘못된 입력입니다.");

                return;
            }

            bool error = db.Update("work_category").Set($"top_category='{topCategory}', " +
                $"middle_category='{middleCategory}', bottom_category='{bottomCategory}'").Where($"category_id={categoryId}").ExecNon();

            if (error)
            {
                log.Here("CATEGORY UPDATE ERROR");

                return;
            }

            LoadCategoryList();
        }

        private void MiddleCategoryEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleCategoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        /* CategoryID Click */
        private void CategoryID_Click(object sender, EventArgs e)
        {
            LoadCategoryId();
        }

        private void LoadCategoryId()
        {
            MySqlDataReader dr = db.Select("category_id").From("work_category").Exec();

            CategoryID.Items.Clear();
            while (dr.Read())
            {
                CategoryID.Items.Add(dr.GetString("category_id"));
            }

            dr.Close();
        }

        /* CategoryID Index Changed */
        private void CategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategoryInfo(CategoryID.Text);
        }

        private void LoadCategoryInfo(string categoryId)
        {
            if (categoryId == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("*").From("work_category").Where($"category_id={categoryId}").Exec();

            if (dr.Read())
            {
                TopCategoryEdit.Text = dr.GetString("top_category");
                MiddleCategoryEdit.Text = dr.GetString("middle_category");
                BottomCategoryEdit.Text = dr.GetString("bottom_category");
            }

            dr.Close();
        }
    }
}