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
        LoginedUserInfo myInfo;
        private DBManager dbManager;

        public AttendanceReg()
        {
            myInfo = LoginedUserInfo.GetMyInfo();
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
            DateTime date = dateTimePicker1.Value;
            string outtime = string.Format(DateTime.Now.ToString("HH:mm:ss"));
            DateTime checkouttime = Convert.ToDateTime(outtime);

            dbManager.OffWorkInsert(userid, date.ToString("yyyy-MM-dd"), outtime);
            if (dateTimePicker1.Value == new DateTime(date.Year, date.Month, 1))
            {
                dbManager.InsertSalary(myInfo.userId, dateTimePicker1.Value.Month);
            }

            var salaryResult = dbManager.Getsalary(myInfo.userId, dateTimePicker1.Value.Month);
            int real_gross_pay = salaryResult.gross_pay;
            int real_base_pay = salaryResult.base_pay;
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            double worktime = dbManager.GetWorktime(myInfo.userId, date.ToString("yyyy-MM-dd"));
            int base_pay = Convert.ToInt32(worktime * 9620);
            int add_pay = 0;
            if (wk != DayOfWeek.Saturday || wk != DayOfWeek.Sunday)
            {
                if (checkouttime.TimeOfDay >= TimeSpan.Parse("18:00:00") && checkouttime.TimeOfDay < TimeSpan.Parse("22:00:00"))
                {
                    TimeSpan fixedTime = TimeSpan.Parse("18:00:00");
                    add_pay = Convert.ToInt32((checkouttime.TimeOfDay - fixedTime).TotalHours * 9620 * 0.5);
                }
                else if (checkouttime.TimeOfDay >= TimeSpan.Parse("22:00:00") && checkouttime.TimeOfDay < TimeSpan.Parse("24:00:00"))
                {
                    TimeSpan fixedTime = TimeSpan.Parse("22:00:00");
                    add_pay = Convert.ToInt32((checkouttime.TimeOfDay - fixedTime).TotalHours * 9620) + 19240;
                }
            }
            else
            {
                if (checkouttime.TimeOfDay >= TimeSpan.Parse("09:00:00") && checkouttime.TimeOfDay < TimeSpan.Parse("18:00:00"))
                {
                    TimeSpan fixedTime = TimeSpan.Parse("09:00:00");
                    add_pay = Convert.ToInt32((checkouttime.TimeOfDay - fixedTime).TotalHours * 9620 * 0.5);
                }
                else if (checkouttime.TimeOfDay >= TimeSpan.Parse("18:00:00") && checkouttime.TimeOfDay < TimeSpan.Parse("22:00:00"))
                {
                    TimeSpan fixedTime = TimeSpan.Parse("18:00:00");
                    add_pay = Convert.ToInt32((checkouttime.TimeOfDay - fixedTime).TotalHours * 9620) + 43290;
                }
                else if (checkouttime.TimeOfDay >= TimeSpan.Parse("22:00:00") && checkouttime.TimeOfDay < TimeSpan.Parse("24:00:00"))
                {
                    TimeSpan fixedTime = TimeSpan.Parse("22:00:00");
                    add_pay = Convert.ToInt32((checkouttime.TimeOfDay - fixedTime).TotalHours * 9620 * 1.5) + 81770;
                }
            }
            int gross_pay = base_pay + add_pay;
            real_base_pay += base_pay;
            real_gross_pay += gross_pay;
            int n_pension = Convert.ToInt32(real_gross_pay * 0.045);
            int n_hinsurance = Convert.ToInt32(real_gross_pay * 0.03545);
            int n_long_hinsurance = Convert.ToInt32(real_gross_pay * 0.009082 * 0.5);
            int e_insurance = Convert.ToInt32(real_gross_pay * 0.009);
            int net_pay = Convert.ToInt32(real_gross_pay - n_pension - n_hinsurance - n_long_hinsurance - e_insurance);

            dbManager.InsertPay(myInfo.userId, real_gross_pay, real_base_pay, n_pension, n_hinsurance, n_long_hinsurance, e_insurance, net_pay, dateTimePicker1.Value.Month);
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
