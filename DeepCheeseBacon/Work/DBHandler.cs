using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace deepcheesebacon.Work {
    internal class DBHandler {
        public MySqlConnection conn;
        private static DBHandler _instacne;
        private DBHandler() {
            string connInfo = $"Server = 115.85.181.212; Database = s5532468; " +
                $"Uid = s5532468; Pwd = s5532468; charset = utf8;";
            conn = new MySqlConnection(connInfo);
        }
        public static DBHandler Instance() {
            if (_instacne == null) {
                _instacne = new DBHandler();
            }
            return _instacne;
        }

        public void setCategoryItem(ComboBox combo, string query) {
            combo.Items.Clear();
            conn.Open();

            using (var cmd = new MySqlCommand(query, conn)) {
                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        combo.Items.Add(reader.GetString(0));
                    }
                }
            }
            conn.Close();
        }
        public void setTopCategoryItem(ComboBox topComboBox, ComboBox middleComboBox, ComboBox bottomComboBox) {
            topComboBox.Items.Clear();
            middleComboBox.Items.Clear();
            bottomComboBox.Items.Clear();
            string query = $"select category from TopWorkCategory";
            setCategoryItem(topComboBox, query);
        }
        public void setMiddleCategory(ComboBox middleComboBox, ComboBox bottomComboBox, string topCategoryValue) {
            middleComboBox.Items.Clear();
            bottomComboBox.Items.Clear();
            middleComboBox.Text = "";
            bottomComboBox.Text = "";
            string query = "select MiddleWorkCategory.category " +
                "from MiddleWorkCategory " +
                "join TopWorkCategory on MiddleWorkCategory.top_category_id = TopWorkCategory.top_category_id " +
                $"where TopWorkCategory.category = '{topCategoryValue}'";
            setCategoryItem(middleComboBox, query);
        }
        public void setBottomCategory(ComboBox bottomComboBox, string topCategoryValue, string middleCategoryValue) {
            bottomComboBox.Items.Clear();
            bottomComboBox.Text = "";
            string query = "select BottomWorkCategory.category " +
                "from BottomWorkCategory " +
                "Join MiddleWorkCategory on BottomWorkCategory.middle_category_id = MiddleWorkCategory.middle_category_id " +
                "Join TopWorkCategory on BottomWorkCategory.top_category_id = TopWorkCategory.top_category_id " +
                $"where TopWorkCategory.category = '{topCategoryValue}' " +
                $"and MiddleWorkCategory.category = '{middleCategoryValue}'";

            setCategoryItem(bottomComboBox, query);
        }
        public void insertWork(string topCategory, string middleCategory, string bottomCategory, DateTime startTime, DateTime endTime, string contents) {
            int topCategoryId = getCategoryId("TopWorkCategory", topCategory, "top");
            int middleCategoryId = getCategoryId("MiddleWorkCategory", middleCategory, "middle");
            int bottomCategoryId = getCategoryId("BottomWorkCategory", bottomCategory, "bottom");

            if (!isTimeOverlap(topCategoryId, middleCategoryId, bottomCategoryId, startTime, endTime)) {
                // 3. 작업 추가
                insertIntoWork(topCategoryId, middleCategoryId, bottomCategoryId, startTime, endTime, contents);
            } else {
                // 겹치는 경우 처리
                MessageBox.Show("이미 예약된 작업시간입니다!");
            }
        }
        private void insertIntoWork(int topCategoryId, int middleCategoryId, int bottomCategoryId, DateTime start, DateTime end, string contents) {
            string startString = ToMySqlDateTime(start) + ":00";
            string endString = ToMySqlDateTime(end) + ":00";

            string query = $"INSERT INTO Work (bottom_category_id, top_category_id, middle_category_id, start_time, end_time, contents) VALUES ({bottomCategoryId}, {topCategoryId}, {middleCategoryId}, '{startString}', '{endString}', '{contents}')";
            conn.Open();
            using (var cmd = new MySqlCommand(query, conn)) {
                if (cmd.ExecuteNonQuery() != -1) {
                    MessageBox.Show("성공적으로 작업이 추가되었습니다!");
                }
            }
            conn.Close();
        }
        private int getCategoryId(string tableName, string category, string categoryClass) {
            string query = $"select {categoryClass}_category_id from {tableName} where category = '{category}'";
            int id = 0;
            conn.Open();

            using (var cmd = new MySqlCommand(query, conn)) {
                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        id = reader.GetInt32(0);
                    }
                }
            }
            conn.Close();
            return id;
        }

        private bool isTimeOverlap(int topCategoryId, int middleCategoryId, int bottomCategoryId, DateTime start, DateTime end) {
            string startString = ToMySqlDateTime(start) + ":00";
            string endString = ToMySqlDateTime(end) + ":00";

            string query = $"SELECT COUNT(*) FROM Work WHERE (start_time < '{endString}' AND end_time > '{startString}') AND top_category_id = {topCategoryId} AND middle_category_id = {middleCategoryId} AND bottom_category_id = {bottomCategoryId}";

            conn.Open();
            int count = 0;
            using (var cmd = new MySqlCommand(query, conn)) {
                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        count = reader.GetInt32(0);
                    }
                }
            }
            conn.Close();
            return count > 0;

        }
        private string ToMySqlDateTime(DateTime date) {
            return date.ToString("yyyy-MM--dd HH:mm");
        }

        public void searchResult(string topCategory, string middleCategory, string bottomCategory, DataGridView dataGridView) {
            conn.Open();

            string query = @"
            SELECT 
                Work.work_id AS '작업번호',
                TopWorkCategory.category AS '대분류',
                MiddleWorkCategory.category AS '중분류',
                BottomWorkCategory.category AS '소분류',
                Work.start_time AS '시작시간',
                Work.end_time AS '종료시간', 
                Work.contents AS '상세내용'
            FROM 
                Work
                JOIN TopWorkCategory ON Work.top_category_id = TopWorkCategory.top_category_id
                JOIN MiddleWorkCategory ON Work.middle_category_id = MiddleWorkCategory.middle_category_id
                JOIN BottomWorkCategory ON Work.bottom_category_id = BottomWorkCategory.bottom_category_id
            WHERE 
                TopWorkCategory.category = @topCategory AND
                MiddleWorkCategory.category = @middleCategory AND
                BottomWorkCategory.category = @bottomCategory";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@topCategory", topCategory);
            cmd.Parameters.AddWithValue("@middleCategory", middleCategory);
            cmd.Parameters.AddWithValue("@bottomCategory", bottomCategory);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.ReadOnly = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.BackgroundColor = Color.FromArgb(255, 255, 255);

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            conn.Close();

            MessageBox.Show("검색 완료!");
        }



        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////


        public void setTopCategoryView(DataGridView topCategoryView) {
            string query = "select category from TopWorkCategory";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            topCategoryView.DataSource = dataTable;
            conn.Close();
        }
        public void setMiddleCategoryView(DataGridView middleCategoryView, string topComboValue) {

            int topCatrgoryId = getCategoryId("TopWorkCategory", topComboValue, "top");

            string query = $"select category from MiddleWorkCategory where top_category_id = {topCatrgoryId}";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            middleCategoryView.DataSource = dataTable;
            conn.Close();


        }
        public void setBottomCategoryView(DataGridView bottomCategoryView, string topComboValue, string middleComboValue) {
            Debug.Write(topComboValue); Debug.WriteLine(middleComboValue);
            bottomCategoryView.DataSource = null;
            int topCatrgoryId = getCategoryId("TopWorkCategory", topComboValue, "top");
            int middleCategoryId = getCategoryId("MiddleWorkCategory", middleComboValue, "middle");

            string query = $"select category from BottomWorkCategory where top_category_id = {topCatrgoryId}" +
                $" and middle_category_id = {middleCategoryId}";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            bottomCategoryView.DataSource = dataTable;
            conn.Close();
        }
        public void insertTopCategory(string value, DataGridView gridView) {
            if (isOverlapedCategory("TopWorkCategory", value)) {
                MessageBox.Show("카테고리가 중복되었습니다.");
                return;
            }
            try {
                string query = $"insert into TopWorkCategory (category) values('{value}')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("성공적으로 등록되었습니다.");
            } catch {
                MessageBox.Show("Error!");
            } finally {
                conn.Close();
            }
            setTopCategoryView(gridView);
        }
        public void insertMiddleCategory(string value, string topCategoryValue) {
            if (isOverlapedCategory("MiddleWorkCategory", value)) {
                MessageBox.Show("카테고리가 중복되었습니다.");
                return;
            }
            try {
                int topCategoryId = getCategoryId("TopWorkCategory", topCategoryValue, "top");
                string query = $"insert into TopWorkCategory (top_category_id, category) values('{value}')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            } catch {
                MessageBox.Show("Error!");
            } finally {
                conn.Close();
            }
        }
        public void insertBottomCategory(string value, string topCategoryValue, string middleCategoryValue) {
            if (isOverlapedCategory("BottomWorkCategory", value)) {
                MessageBox.Show("카테고리가 중복되었습니다.");
                return;
            }
            try {
                int topCategoryId = getCategoryId("TopWorkCategory", topCategoryValue, "top");
                int middleCategoryId = getCategoryId("MiddleWorkCategory,", middleCategoryValue, "middle");
                string query = $"insert into TopWorkCategory (top_category_id, middle_category_id, category) values({topCategoryId},{middleCategoryId},'{value}')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            } catch {
                MessageBox.Show("Error");
            } finally {
                conn.Close();
            }
        }
        // 분류별 중복도 체크해야함. 수정 요망.
        private bool isOverlapedCategory(string table, string category) {
            conn.Open();
            string query = $"select count(category) from {table} where category = '{category}'";

            int count = 0;
            using (var cmd = new MySqlCommand(query, conn)) {
                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        count = reader.GetInt32(0);
                    }
                }
            }
            conn.Close();
            return count > 0;
        }
    }
}
