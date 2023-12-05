using MySql.Data.MySqlClient;
using System.Data;

namespace deepcheesebacon.work.src
{
    internal class DBHandlerForWork
    {
        private static DBHandlerForWork instance;
        private static string dbSource;
        private string sql;

        /* ----- Constructor ----- */
        private DBHandlerForWork()
        {
            dbSource = "";
            sql = "";
        }

        /* ----- Instance ----- */
        public static DBHandlerForWork Instance
        {
            get
            {
                // Instance 가 없다면 생성
                if (instance == null) instance = new DBHandlerForWork();

                return instance;
            }
        }

        /* ----- Database Source Setting ----- */
        public void SetDBSource(string ip, string db, string id, string password, string format)
        {
            dbSource = $"Server={ip};Database={db};Uid={id};Pwd={password};Charset={format}";
        }

        /* Selete */
        public DBHandlerForWork Select(string query)
        {
            sql += $"SELECT {query}";

            return this;
        }

        public DBHandlerForWork From(string query)
        {
            sql += $" FROM {query}";

            return this;
        }

        public DBHandlerForWork Where(string query)
        {
            sql += $" WHERE {query}";

            return this;
        }

        /* Insert */
        public DBHandlerForWork Insert(string query)
        {
            sql += $"INSERT INTO {query}";

            return this;
        }

        public DBHandlerForWork Values(string query)
        {
            sql += $" VALUES ({query})";

            return this;
        }

        /* Update */
        public DBHandlerForWork Update(string query)
        {
            sql += $"UPDATE {query}";

            return this;
        }

        public DBHandlerForWork Set(string query)
        {
            sql += $" SET {query}";

            return this;
        }

        /* Delete */
        public DBHandlerForWork Delete(string query)
        {
            sql += $"DELETE FROM {query}";

            return this;
        }

        /* Group By */
        public DBHandlerForWork GroupBy(string query)
        {
            sql += $" GROUP BY {query}";

            return this;
        }

        /* Exec */
        public MySqlDataReader Exec()
        {
            sql += ";";
            MySqlConnection conn = new MySqlConnection(dbSource);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            sql = "";

            // MySqlDataReader Type을 반환하기 때문에 Close() 꼭 필요
            return dr;
        }

        public bool ExecNon()
        {
            bool error = false;
            sql += ";";
            using (MySqlConnection conn = new MySqlConnection(dbSource))
            {
                conn.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    // DB Error Catch
                    error = true;
                }
            }
            sql = "";

            // Error Result Return
            return error;
        }

        /* ----- Set DataGridView ----- */
        public void SetDataSource(MySqlDataReader dr, DataGridView dgv)
        {
            DataTable dt = new DataTable();

            dt.Load(dr);
            dgv.DataSource = dt;
        }
    }
}
