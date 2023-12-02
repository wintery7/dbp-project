using deepcheesebacon;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deepcheesebacon
{
    public partial class AttendanceReg : UserControl
    {
        private DBManager dbManager;

        public AttendanceReg()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();
            
        }
        string strconn = "Server=115.85.181.212;Database=s5702003;Uid=s5702003;Pwd=s5702003;Charset=utf8";

        // 출근 버튼 누를 경우
        private void GoWorkBtn_Click(object sender, EventArgs e)
        {
            string name = UserNameText.Text;
            int userid = GetUserId(name); 
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string intime = string.Format(DateTime.Now.ToString("HH:mm:ss"));

            dbManager.GoWorkInsert(userid, date, intime);
        }


        // db에서 user 테이블의 user_id 값 가져오기
        private int GetUserId(string name)
        {
            int userid = -1;

            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT user_id FROM user WHERE name = @name";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@name", name);

                    // ExecuteScalar를 사용하여 결과를 가져옴
                    object objResult = com.ExecuteScalar();

                    if (objResult != null && objResult != DBNull.Value)
                    {
                        userid = Convert.ToInt32(objResult);
                    }

                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }

            return userid;
        }

        // 퇴근 버튼 누를 경우
        private void OffWorkBtn_Click(object sender, EventArgs e)
        {
            int userid = GetUserId(UserNameText.Text);
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string outtime = string.Format(DateTime.Now.ToString("HH:mm:ss"));

            dbManager.OffWorkInsert(userid, date, outtime);
        }

/*
        // db에 저장되어 있는 AttendanceLog attendDate값 가져오기
        private string GetUserDate(string name)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT attendDate FROM AttendanceLog WHERE name = @name";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@name", name);

                    // ExecuteScalar를 사용하여 결과를 가져옴
                    object objResult = com.ExecuteScalar();

                    if (objResult != null && objResult != DBNull.Value)
                    {
                        name = Convert.ToString(objResult);
                    }

                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
            return name;
        }*/
    }
}
