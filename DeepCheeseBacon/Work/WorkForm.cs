using deepcheesebacon.Work;
using MySql.Data.MySqlClient;

namespace deepcheesebacon
{
    public partial class WorkForm : Form
    {
        DBHandlerForWork db;
        Log log;

        public WorkForm()
        {
            InitializeComponent();

            InitDatabase();
            Init();
        }

        private void InitDatabase()
        {
            DBHandlerForWork.Instance.SetDBSource("34.64.40.193", "deep_cheese", "seoungjun", "1234", "utf8");
            db = DBHandlerForWork.Instance;
        }

        private void Init()
        {
            log = Log.Instance;
            LoadWork();
        }






        /*
        private void SetCustomTimePicker() {
            this.StartTime.Format = DateTimePickerFormat.Custom;
            this.StartTime.CustomFormat = "HH:mm";
            this.EndTime.Format = DateTimePickerFormat.Custom;
            this.EndTime.CustomFormat = "HH:mm";
        }
        */

        private void MiddleCategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DB.setBottomCategory(this.BottomCategoryCombo, TopCategoryCombo.SelectedItem.ToString(), MiddleCategoryCombo.SelectedItem.ToString());
        }

        private void TopCategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DB.setMiddleCategory(MiddleCategoryCombo, this.BottomCategoryCombo, TopCategoryCombo.SelectedItem.ToString());
        }

        private void LoadWork()
        {
            int userId = LoginedUserInfo.GetMyInfo().userId;

            MySqlDataReader dr = db.Select("work_id AS id, " +
                "top_category AS top, middle_category AS middle, bottom_category AS bottom, start_time AS start, end_time AS end, contents" +
                "").From("work_detail d JOIN work_category c ON d.category_id=c.category_id").Where($"user_id={userId}").Exec();

            db.SetDataSource(dr, WorkView);

            dr.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
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

        private void WorkMasterButton_Click(object sender, EventArgs e)
        {
            Form form = new WorkMasterForm();

            form.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void WorkDetailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void customGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WorkForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemoveButton_Click_1(object sender, EventArgs e)
        {

        }

        private void WorkView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* Top Category Load */
        private void TopCategoryCombo_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = db.Select("top_category").From("work_category").Exec();

            TopCategoryCombo.Items.Clear();
            while (dr.Read())
            {
                TopCategoryCombo.Items.Add(dr.GetString("top_category"));
            }
            MiddleCategoryCombo.Text = "";
            BottomCategoryCombo.Text = "";

            dr.Close();
        }

        /* Middle Category Load */
        private void MiddleCategoryCombo_Click(object sender, EventArgs e)
        {
            string topCategory = TopCategoryCombo.Text;

            if (topCategory == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("middle_category").From("work_category").Where($"top_category='{topCategory}'").Exec();

            MiddleCategoryCombo.Items.Clear();
            while (dr.Read())
            {
                MiddleCategoryCombo.Items.Add(dr.GetString("middle_category"));
            }
            BottomCategoryCombo.Text = "";

            dr.Close();
        }

        /* bottom Category Load */
        private void BottomCategoryCombo_Click(object sender, EventArgs e)
        {
            string topCategory = TopCategoryCombo.Text;
            string middleCategory = MiddleCategoryCombo.Text;

            if (topCategory == "" || middleCategory == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("bottom_category").From("work_category").Where($"top_category='{topCategory}' " +
                $"AND middle_category='{middleCategory}'").Exec();

            BottomCategoryCombo.Items.Clear();
            while (dr.Read())
            {
                BottomCategoryCombo.Items.Add(dr.GetString("bottom_category"));
            }

            dr.Close();
        }

        /* WorkId Load */
        private void WorkId_Click(object sender, EventArgs e)
        {
            int userId = LoginedUserInfo.GetMyInfo().userId;

            MySqlDataReader dr = db.Select("work_id").From("work_detail").Where($"user_id={userId}").Exec();

            WorkId.Items.Clear();
            while (dr.Read())
            {
                WorkId.Items.Add(dr.GetString("work_id"));
            }

            dr.Close();
        }

        /* Register */
        private void RegisterButton_Click_1(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                log.Here("올바른 값이 아닙니다.");

                return;
            }

            if (CheckDuplicate())
            {
                log.Here("시간이 겹치는 업무가 있습니다.");

                return;
            }

            int userId = LoginedUserInfo.GetMyInfo().userId;
            string categoryId = GetCategoryId();
            string startTime = GetStartTime();
            string endTime = GetEndTime();
            string contents = WorkDetailBox.Text;
            bool error = db.Insert("work_detail").Values($"NULL, {userId}, {categoryId}, '{startTime}', '{endTime}', '{contents}'").ExecNon();

            if (error)
            {
                log.Here("WORK REGISTER ERROR");
            }
            LoadWork();
        }

        private bool CheckEmpty()
        {
            string topCategory = TopCategoryCombo.Text;
            string middleCategory = MiddleCategoryCombo.Text;
            string bottomCategory = BottomCategoryCombo.Text;

            if (topCategory == "" || middleCategory == "" || bottomCategory == "")
            {
                return true;
            }

            string contents = WorkDetailBox.Text;

            if (contents == "")
            {
                return true;
            }

            return false;
        }

        private bool CheckDuplicate()
        {
            string startTime = GetStartTime();
            string endTime = GetEndTime();

            MySqlDataReader dr = db.Select("EXISTS (SELECT * FROM work_detail").Where($"(start_time BETWEEN '{startTime}' AND '{endTime}')" +
                $"OR (end_time BETWEEN '{startTime}' AND '{endTime}')" +
                $"OR (start_time <= '{startTime}' AND end_time >= '{endTime}') LIMIT 1) AS result").Exec();

            if (dr.Read())
            {
                string result = dr.GetString("result");

                dr.Close();

                return result == "1";
            }
            log.Here("DUPLICATE CHECK READ ERROR");

            return true;
        }

        private string GetCategoryId()
        {
            string topCategory = TopCategoryCombo.Text;
            string middleCategory = MiddleCategoryCombo.Text;
            string bottomCategory = BottomCategoryCombo.Text;

            MySqlDataReader dr = db.Select("category_id").From("work_category").Where($"top_category='{topCategory}' " +
                $"AND middle_category='{middleCategory}' AND bottom_category='{bottomCategory}'").Exec();

            string categoryId = "";
            if (dr.Read())
            {
                categoryId = dr.GetString("category_id");
            }
            dr.Close();

            return categoryId;
        }

        private string GetStartTime()
        {
            DateTime startday = StartDay.Value.Date;
            DateTime starttime = StartTime.Value;

            DateTime start = startday.AddHours(starttime.Hour).AddMinutes(starttime.Minute);

            return start.ToString("yyyy-MM-dd HH:mm");
        }

        private string GetEndTime()
        {
            DateTime endday = EndDay.Value.Date;
            DateTime endtime = EndTime.Value;

            DateTime end = endday.AddHours(endtime.Hour).AddMinutes(endtime.Minute);

            return end.ToString("yyyy-MM-dd HH:mm");
        }

        /* Delete */
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string workId = WorkId.Text;
            bool error = db.Delete("work_detail").Where($"work_id={workId}").ExecNon();

            if (error)
            {
                log.Here("WORK DELETE ERROR");

                return;
            }

            LoadWork();
        }

        /* Edit */
        private void EditButton_Click(object sender, EventArgs e)
        {
            string workId = WorkId.Text;

            if (workId == "")
            {
                log.Here("올바른 ID 값이 아닙니다.");

                return;
            }

            if (CheckEmpty())
            {
                log.Here("올바른 값이 아닙니다.");

                return;
            }

            if (CheckDuplicateForEdit(workId))
            {
                log.Here("시간이 겹치는 업무가 있습니다.");

                return;
            }

            string categoryId = GetCategoryId();
            string startTime = GetStartTime();
            string endTime = GetEndTime();
            string contents = WorkDetailBox.Text;
            bool error = db.Update("work_detail").Set($"category_id={categoryId}, start_time='{startTime}', end_time='{endTime}', " +
                $"contents='{contents}'").Where($"work_id={workId}").ExecNon();

            if (error)
            {
                log.Here("WORK REGISTER ERROR");
            }
            LoadWork();
        }

        private bool CheckDuplicateForEdit(string workId)
        {
            string startTime = GetStartTime();
            string endTime = GetEndTime();

            MySqlDataReader dr = db.Select("EXISTS (SELECT * FROM work_detail").Where($"((start_time BETWEEN '{startTime}' AND '{endTime}')" +
                $"OR (end_time BETWEEN '{startTime}' AND '{endTime}')" +
                $"OR (start_time <= '{startTime}' AND end_time >= '{endTime}'))" +
                $"AND NOT (work_id={workId}) LIMIT 1) AS result").Exec();

            if (dr.Read())
            {
                string result = dr.GetString("result");

                dr.Close();

                return result == "1";
            }
            log.Here("DUPLICATE CHECK READ ERROR");

            return true;
        }

        /* WorkId COmboBox Index Changed */
        private void WorkId_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWorkDetail();
        }

        private void LoadWorkDetail()
        {
            string workId = WorkId.Text;

            if (workId == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("*").From("work_detail d " +
                "JOIN work_category c ON d.category_id=c.category_id").Where($"work_id={workId}").Exec();

            if (dr.Read())
            {
                TopCategoryCombo.Text = dr.GetString("top_category");
                MiddleCategoryCombo.Text = dr.GetString("middle_category");
                BottomCategoryCombo.Text = dr.GetString("bottom_category");
                WorkDetailBox.Text = dr.GetString("contents");

                // Time
                StartDay.Text = dr.GetString("start_time");
                StartTime.Text = dr.GetString("start_time");
                EndDay.Text = dr.GetString("end_time");
                EndTime.Text = dr.GetString("end_time");
            }
            dr.Close();
        }

        /* Keyword Search */
        private void KeywordSearchButton_Click(object sender, EventArgs e)
        {
            string contents = WorkDetailBox.Text;

            if (contents == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("work_id AS id, " +
                "top_category AS top, middle_category AS middle, bottom_category AS bottom, start_time AS start, end_time AS end, contents" +
                "").From("work_detail d JOIN work_category c " +
                "ON d.category_id=c.category_id").Where($"contents LIKE '%{contents}%'").Exec();

            db.SetDataSource(dr, WorkView);

            dr.Close();
        }

        /* Time Search */
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string startTime = GetStartTime();
            string endTime = GetEndTime();

            MySqlDataReader dr = db.Select("work_id AS id, " +
                "top_category AS top, middle_category AS middle, bottom_category AS bottom, start_time AS start, end_time AS end, contents" +
                "").From("work_detail d JOIN work_category c " +
                "ON d.category_id=c.category_id").Where($"(start_time BETWEEN '{startTime}' AND '{endTime}')" +
                $"OR (end_time BETWEEN '{startTime}' AND '{endTime}')" +
                $"OR (start_time <= '{startTime}' AND end_time >= '{endTime}')").Exec();

            db.SetDataSource(dr, WorkView);

            dr.Close();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            LoadWork();
        }
    }
}