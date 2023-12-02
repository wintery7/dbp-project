using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using MySqlX.XDevAPI.Common;
using System.Runtime.InteropServices;


namespace deepcheesebacon
{
    public partial class UserModify : UserControl
    {
        UserManage userManage = new UserManage();
        private DBManager dbManager;
        public UserModify(string id)
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();

            LoadComboBox();

            emailText.Text = id;
            EmailLoad(id);
            emailText.ReadOnly = true;
            PwLoad(id);
            NameLoad(id);
            DateLoad(id);
            GenderLoad(id);
            RoleLoad(id);
            DepLoad(id);
            PnumLoad(id);
            AddrLoad(id);           
        }

        private void LoadComboBox()
        {
            comboBox1.Items.Clear();

            List<string> departmentList = new List<string>();
            departmentList = dbManager.GetDepartment();

            if (departmentList != null && departmentList.Count > 0)
            {
                comboBox1.Items.AddRange(departmentList.ToArray());
            }
        }

        // 비밀번호 암호화 함수
        private string HashPassWord(string pw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pw));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }

        }

        string strconn = "Server=115.85.181.212;Database=s5702003;Uid=s5702003;Pwd=s5702003;Charset=utf8";

        // db에서 department 테이블의 id 값 가져오기
        private int GetDepId(string depid)
        {
            int id = -1;

            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT id FROM department WHERE department_name = @dep_name";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@dep_name", depid);

                    // ExecuteScalar를 사용하여 결과를 가져옴
                    object objResult = com.ExecuteScalar();

                    if (objResult != null && objResult != DBNull.Value)
                    {
                        id = Convert.ToInt32(objResult);
                    }

                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }

            return id;
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
            string pw = HashPassWord(pwText.Text);
            string name = nameText.Text;
            string gender = genderText.Text;
            string pnum = pnumText.Text;
            string addr = addrText.Text;
            string depid = comboBox1.Text;
            int id = GetDepId(depid);
            string date = dateText.Text;
            int role = 0;

            if (roleText.Text == "원장")
            {
                role = 0;
            }
            else if (roleText.Text == "강사")
            {
                role = 1;
            }
            else if (roleText.Text == "보조강사")
            {
                role = 2;
            }

            dbManager.UserModify(role, email, pw, name, gender, pnum, addr, id, date);

            this.Controls.Clear();
            this.Controls.Add(userManage);
        }
        private void EmailLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT email FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id",id);

                    object result = com.ExecuteScalar();
        
                    if(result != null)
                    {
                        emailText.Text = result.ToString();
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }

        private string MaskString(string original)
        {
            int length = original.Length;
            // 길이만큼 * 로 바꿈
            string maskedString = new string('*', length);

            return maskedString;
        }
        private string Pw(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT password FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        // 데이터베이스에서 가져온 값에 대해 마스킹 적용
                        return MaskString(result.ToString());
                    }

                    return string.Empty; // 데이터가 없을 경우 빈 문자열 반환 또는 다른 기본값 설정
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
                return string.Empty; // 오류 발생 시 빈 문자열 반환 또는 다른 기본값 설정
            }
        }

        private void PwLoad(string id)
        {
            string result = Pw(id);
            pwText.Text = result;
        }

        private void NameLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT name FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null)
                    {
                        nameText.Text = result.ToString();
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }

        private void DateLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT DATE_FORMAT(birthDate,'%Y-%m-%d') FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null)
                    {
                        dateText.Text = result.ToString();
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }
        private void GenderLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT gender FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null)
                    {
                        genderText.Text = result.ToString();
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }

        private void RoleLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT user_role FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null)
                    {
                        
                        if((int)result == 0)
                        {
                            roleText.Text = "원장";
                        }
                        else if((int)result == 1)
                        {
                            roleText.Text = "강사";
                        }
                        else if((int)result == 2)
                        {
                            roleText.Text = "보조강사";
                        }
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }

        private void DepLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT department_name FROM department WHERE id IN (SELECT department FROM user WHERE user_id = @id)";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null)
                    {
                        comboBox1.Text = result.ToString();
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }
        private void PnumLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT phone_number FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null)
                    {
                        pnumText.Text = result.ToString();
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }

        private void AddrLoad(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(strconn))
                {
                    con.Open();

                    string query = "SELECT address FROM user WHERE user_id = @id";
                    MySqlCommand com = new MySqlCommand(query, con);
                    com.Parameters.AddWithValue("@id", id);

                    object result = com.ExecuteScalar();

                    if (result != null)
                    {
                        addrText.Text = result.ToString();
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("오류발생: " + e.Message);
            }
        }

        private void emailText_Enter(object sender, EventArgs e)
        {
            if (emailText.Text == "이메일")
            {
                emailText.Text = "";
                emailText.ForeColor = Color.Black;
            }
        }

        private void pwText_Enter(object sender, EventArgs e)
        {
            if (pwText.Text == "비밀번호")
            {
                pwText.Text = "";
                pwText.ForeColor = Color.Black;
            }
        }

        private void nameText_Enter(object sender, EventArgs e)
        {
            if (nameText.Text == "이름")
            {
                nameText.Text = "";
                nameText.ForeColor = Color.Black;
            }
        }

        private void dateText_Enter(object sender, EventArgs e)
        {
            if (dateText.Text == "생년월일")
            {
                dateText.Text = "";
                dateText.ForeColor = Color.Black;
            }
        }

        private void genderText_Enter(object sender, EventArgs e)
        {
            if (genderText.Text == "성별")
            {
                genderText.Text = "";
                genderText.ForeColor = Color.Black;
            }
        }

        private void roleText_Enter(object sender, EventArgs e)
        {
            if (roleText.Text == "직급")
            {
                roleText.Text = "";
                roleText.ForeColor = Color.Black;
            }
        }

        private void depText_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "담당과목")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void pnumText_Enter(object sender, EventArgs e)
        {
            if (pnumText.Text == "전화번호")
            {
                pnumText.Text = "";
                pnumText.ForeColor = Color.Black;
            }
        }

        private void addrText_Enter(object sender, EventArgs e)
        {
            if (addrText.Text == "주소")
            {
                addrText.Text = "";
                addrText.ForeColor = Color.Black;
            }
        }
    }
}
