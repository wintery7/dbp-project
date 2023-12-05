using deepcheesebacon.work.src;
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

        /* ----- Init Database ----- */
        private void InitDatabase()
        {
            DBHandlerForWork.Instance.SetDBSource("34.64.40.193", "deep_cheese", "seoungjun", "1234", "utf8");
            db = DBHandlerForWork.Instance;
        }

        /* ----- Init ----- */
        private void Init()
        {
            log = Log.Instance;

            LoadWork();     // Work DataGridView Load
        }

        /* Work DataGridView Load */
        private void LoadWork()
        {
            int userId = LoginedUserInfo.GetMyInfo().userId;

            MySqlDataReader dr = db.Select("work_id AS id, " +
                "top_category AS top, middle_category AS middle, bottom_category AS bottom, start_time AS start, end_time AS end, contents" +
                "").From("work_detail d JOIN work_category c ON d.category_id=c.category_id").Where($"user_id={userId}").Exec();

            db.SetDataSource(dr, WorkView);

            dr.Close();
        }

        /* ----- Work Master Edit ----- */
        private void WorkMasterButton_Click_1(object sender, EventArgs e)
        {
            Form form = new WorkMasterForm();

            form.Show();
        }

        /* ----- Top Category Load ----- */
        private void TopCategoryCombo_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = db.Select("top_category").From("work_category").GroupBy("top_category").Exec();

            // Item Add �� Clear
            TopCategoryCombo.Items.Clear();
            while (dr.Read())
            {
                TopCategoryCombo.Items.Add(dr.GetString("top_category"));
            }
            // ���� Category Init
            MiddleCategoryCombo.Text = "";
            BottomCategoryCombo.Text = "";

            dr.Close();
        }

        /* ----- Middle Category Load ----- */
        private void MiddleCategoryCombo_Click(object sender, EventArgs e)
        {
            string topCategory = TopCategoryCombo.Text;

            // Top Category Null Check
            if (topCategory == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("middle_category").From("work_category" +
                "").Where($"top_category='{topCategory}'").GroupBy("middle_category").Exec();

            // Item Add �� Clear
            MiddleCategoryCombo.Items.Clear();
            while (dr.Read())
            {
                MiddleCategoryCombo.Items.Add(dr.GetString("middle_category"));
            }
            // ���� Category Init
            BottomCategoryCombo.Text = "";

            dr.Close();
        }

        /* bottom Category Load */
        private void BottomCategoryCombo_Click(object sender, EventArgs e)
        {
            string topCategory = TopCategoryCombo.Text;
            string middleCategory = MiddleCategoryCombo.Text;

            // Top Category, Middle Category Null Check
            if (topCategory == "" || middleCategory == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("bottom_category").From("work_category").Where($"top_category='{topCategory}' " +
                $"AND middle_category='{middleCategory}'").GroupBy("bottom_category").Exec();

            // Item Add �� Clear
            BottomCategoryCombo.Items.Clear();
            while (dr.Read())
            {
                BottomCategoryCombo.Items.Add(dr.GetString("bottom_category"));
            }

            dr.Close();
        }

        /* ----- WorkId Load ----- */
        private void WorkId_Click(object sender, EventArgs e)
        {
            int userId = LoginedUserInfo.GetMyInfo().userId;
            // �ڱ� �ڽſ��� �ش��ϴ� work_id�� �ҷ���
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
            // �ʼ� �Է� ĭ�� ����� �� �˻�
            if (CheckEmpty())
            {
                log.Here("�ùٸ� ���� �ƴմϴ�.");

                return;
            }

            // StartTime, EndTime�� ���� �˻�
            if (!CheckDate())
            {
                log.Here("�ùٸ� ��¥�� �ƴմϴ�.");

                return;
            }

            // ��ġ�� ������ �ִ��� �˻�
            if (CheckDuplicate())
            {
                log.Here("�ð��� ��ġ�� ������ �ֽ��ϴ�.");

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
            InitControlBox();
        }

        /* Check Empty */
        private bool CheckEmpty()
        {
            string topCategory = TopCategoryCombo.Text;
            string middleCategory = MiddleCategoryCombo.Text;
            string bottomCategory = BottomCategoryCombo.Text;

            // Category�� ����� ���
            if (topCategory == "" || middleCategory == "" || bottomCategory == "")
            {
                return true;
            }

            string contents = WorkDetailBox.Text;

            // Contents�� ����� ���
            if (contents == "")
            {
                return true;
            }

            return false;
        }

        /* Check Date */
        private bool CheckDate()
        {
            string startTime = GetStartTime();
            string endTime = GetEndTime();

            // startTime�� endTime���� �ڿ� ������ false Return
            return string.Compare(startTime, endTime) != 1;
        }

        /* Check Duplicate */
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

                // ��ġ�� ������ ������ true Return
                return result == "1";
            }
            log.Here("DUPLICATE CHECK READ ERROR");

            return true;
        }

        /* Get Category Id */
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
                // ��.��.�� Category�� �ش��ϴ� category_id
                categoryId = dr.GetString("category_id");
            }
            dr.Close();

            return categoryId;
        }

        /* Get Start Time */
        private string GetStartTime()
        {
            DateTime startday = StartDay.Value.Date;
            DateTime starttime = StartTime.Value;

            DateTime start = startday.AddHours(starttime.Hour).AddMinutes(starttime.Minute);

            return start.ToString("yyyy-MM-dd HH:mm");
        }

        /* Get End Time */
        private string GetEndTime()
        {
            DateTime endday = EndDay.Value.Date;
            DateTime endtime = EndTime.Value;

            DateTime end = endday.AddHours(endtime.Hour).AddMinutes(endtime.Minute);

            return end.ToString("yyyy-MM-dd HH:mm");
        }

        /* Init ControlBox */
        private void InitControlBox()
        {
            TopCategoryCombo.Text = "";
            MiddleCategoryCombo.Text = "";
            BottomCategoryCombo.Text = "";

            WorkDetailBox.Text = "";

            WorkId.Text = "";
        }

        /* ----- Delete ----- */
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
            InitControlBox();
        }

        /* ----- Edit ----- */
        private void EditButton_Click(object sender, EventArgs e)
        {
            string workId = WorkId.Text;

            // work_id �Է��� ���� ���
            if (workId == "")
            {
                log.Here("�ùٸ� ID ���� �ƴմϴ�.");

                return;
            }

            // �ʼ� �Է� ĭ�� ����� ���
            if (CheckEmpty())
            {
                log.Here("�ùٸ� ���� �ƴմϴ�.");

                return;
            }

            // Start Time�� End Time���� �ڿ� �ִ� ���
            if (!CheckDate())
            {
                log.Here("�ùٸ� ��¥�� �ƴմϴ�.");

                return;
            }

            // ��ġ�� ������ �ִ� ��� (�ڱ��ڽ� ����)
            if (CheckDuplicateForEdit(workId))
            {
                log.Here("�ð��� ��ġ�� ������ �ֽ��ϴ�.");

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
            InitControlBox();
        }

        /* Check Duplicate For Edit */
        private bool CheckDuplicateForEdit(string workId)
        {
            string startTime = GetStartTime();
            string endTime = GetEndTime();

            // �ڱ��ڽ��� ������ ��ġ�� ������ �����ϴ��� Query
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

        /* ----- WorkId COmboBox Index Changed ----- */
        private void WorkId_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWorkDetail();
        }

        /* Load Work Detail */
        private void LoadWorkDetail()
        {
            string workId = WorkId.Text;

            // �Էµ� work_id�� ���� ���
            if (workId == "")
            {
                return;
            }

            MySqlDataReader dr = db.Select("*").From("work_detail d " +
                "JOIN work_category c ON d.category_id=c.category_id").Where($"work_id={workId}").Exec();

            if (dr.Read())
            {
                // Category
                TopCategoryCombo.Text = dr.GetString("top_category");
                MiddleCategoryCombo.Text = dr.GetString("middle_category");
                BottomCategoryCombo.Text = dr.GetString("bottom_category");

                // Contents
                WorkDetailBox.Text = dr.GetString("contents");

                // Time
                StartDay.Text = dr.GetString("start_time");
                StartTime.Text = dr.GetString("start_time");
                EndDay.Text = dr.GetString("end_time");
                EndTime.Text = dr.GetString("end_time");
            }
            dr.Close();
        }

        /* ----- Keyword Search ----- */
        private void KeywordSearchButton_Click(object sender, EventArgs e)
        {
            string contents = WorkDetailBox.Text;

            // �Էµ� ���� ���� ���
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

        /* ----- Time Search ----- */
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

        /* ----- Click Reload Button ----- */
        private void Reload_Click(object sender, EventArgs e)
        {
            LoadWork();
            InitControlBox();
        }
    }
}