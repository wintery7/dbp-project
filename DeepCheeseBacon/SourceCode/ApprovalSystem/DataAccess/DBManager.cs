using deepcheesebacon.SourceCode.ApprovalSystem.Models;
using deepcheesebacon.SourceCode.LoginSystem.MyInfo;
using deepcheesebacon.SourceCode.MessageSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;
using Message = deepcheesebacon.SourceCode.MessageSystem.Models.Message;

namespace deepcheesebacon.SourceCode.ApprovalSystem.DataAccess
{
    public class DBManager
    {
        private static DBManager dB = new DBManager();
        MySqlConnection connection;
        MyInfo myInfo = MyInfo.GetMyInfo();

        private DBManager()
        {
            InitializeConnection();
        }

        public static DBManager GetDBManager()
        {
            return dB;
        }

        public int SaveOrUpdateApproval(Approval approval)
        {
            // 데이터베이스에 approvals 테이블이 존재하지 않으면 테이블 생성
            if (!IsApprovalTableExists())
            {
                CreateApprovalTableIfNotExists();
            }

            // 검색할 쿼리를 작성하여 해당 approval의 유무를 확인
            string searchQuery = "SELECT COUNT(*) FROM approval WHERE Id = @id";
            int existingId = 0;

            using (MySqlCommand searchCmd = new MySqlCommand(searchQuery, connection))
            {
                searchCmd.Parameters.AddWithValue("@id", approval.Id);
                object searchResult = searchCmd.ExecuteScalar();

                if (searchResult != null)
                {
                    existingId = Convert.ToInt32(searchResult);
                }
            }

            if (existingId > 0)
            {
                // approval가 이미 존재하므로 업데이트 수행
                string updateQuery = "UPDATE approval SET request_id = @request_id, approver_id = @approver_id, first_approver_id = @first_approver_id, second_approver_id = @seconde_approver_id,approval_date = @approval_date, title = @title, description = @description, comments = @comments, status = @status, role_status = @role_status, memo = @memo, related_task = @related_task WHERE Id = @id";

                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.AddWithValue("@id", approval.Id);
                    updateCmd.Parameters.AddWithValue("@request_id", approval.RequestId);
                    updateCmd.Parameters.AddWithValue("@approver_id", approval.ApproverId);
                    updateCmd.Parameters.AddWithValue("@first_approver_id", approval.FirstApproverId);
                    updateCmd.Parameters.AddWithValue("@seconde_approver_id", approval.SecondApproverId);
                    updateCmd.Parameters.AddWithValue("@approval_date", approval.ApprovalDate);
                    updateCmd.Parameters.AddWithValue("@title", approval.Title);
                    updateCmd.Parameters.AddWithValue("@description", approval.Description);
                    updateCmd.Parameters.AddWithValue("@comments", approval.Comment);
                    updateCmd.Parameters.AddWithValue("@status", approval.Status);
                    updateCmd.Parameters.AddWithValue("@role_status", approval.RoleStatus);
                    updateCmd.Parameters.AddWithValue("@memo", approval.Memo);
                    updateCmd.Parameters.AddWithValue("@related_task", approval.RelatedTask);

                    updateCmd.ExecuteNonQuery();
                }

                return approval.Id;
            }
            else
            {
                // approval가 존재하지 않으므로 새로 삽입
                string insertQuery = "INSERT INTO approval (request_id, approver_id, approval_date, title, description, comments, status, role_status, memo, related_task) VALUES (@request_id, @approver_id, @approval_date, @title, @description, @comments, @status, @role_status, @memo, @related_task); SELECT LAST_INSERT_ID();";
                int insertedId = 0;

                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@request_id", approval.RequestId);
                    insertCmd.Parameters.AddWithValue("@approver_id", approval.ApproverId);
                    insertCmd.Parameters.AddWithValue("@approval_date", approval.ApprovalDate);
                    insertCmd.Parameters.AddWithValue("@title", approval.Title);
                    insertCmd.Parameters.AddWithValue("@description", approval.Description);
                    insertCmd.Parameters.AddWithValue("@comments", approval.Comment);
                    insertCmd.Parameters.AddWithValue("@status", approval.Status);
                    insertCmd.Parameters.AddWithValue("@role_status", approval.RoleStatus);
                    insertCmd.Parameters.AddWithValue("@memo", approval.Memo);
                    insertCmd.Parameters.AddWithValue("@related_task", approval.RelatedTask);


                    object insertResult = insertCmd.ExecuteScalar();

                    if (insertResult != null)
                    {
                        insertedId = Convert.ToInt32(insertResult);
                    }
                }

                return insertedId;
            }
        }

        private bool IsApprovalTableExists()
        {

            string checkTableQuery = "SELECT 1 FROM approval LIMIT 1";

            using (MySqlCommand checkCmd = new MySqlCommand(checkTableQuery, connection))
            {
                try
                {
                    checkCmd.ExecuteScalar();
                    return true; // 테이블이 존재함
                }
                catch (MySqlException)
                {
                    return false; // 테이블이 존재하지 않음
                }
            }
        }

        private void CreateApprovalTableIfNotExists()
        {
            string createTableQuery = @"
CREATE TABLE IF NOT EXISTS approval (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    request_id INT DEFAULT 0, -- request_id의 기본값을 0으로 설정
    approver_id INT DEFAULT 0, -- approver_id의 기본값을 0으로 설정
    first_approver_id INT DEFAULT 0, -- first_approver_id의 기본값을 0으로 설정
    second_approver_id INT DEFAULT 0, -- second_approver_id의 기본값을 0으로 설정
    approval_date DATETIME DEFAULT '2023-01-01 00:00:00', -- approval_date의 기본값을 '2023-01-01 00:00:00'으로 설정
    title VARCHAR(255) DEFAULT '', -- title의 기본값을 빈 문자열로 설정
    description TEXT DEFAULT '', -- description의 기본값을 빈 문자열로 설정
    comments TEXT DEFAULT '', -- comments의 기본값을 빈 문자열로 설정
    status INT DEFAULT 0, -- status의 기본값을 0으로 설정
    role_status INT DEFAULT 1, -- role_status의 기본값을 1로 설정
    related_task VARCHAR(255) DEFAULT '' -- related_task의 기본값을 빈 문자열로 설정
) CHARSET=utf8;";

            using (MySqlCommand createCmd = new MySqlCommand(createTableQuery, connection))
            {
                createCmd.ExecuteNonQuery();
            }
        }




        public Approval GetApprovalById(int approvalId)
        {
            string query = "SELECT * FROM approval WHERE Id = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", approvalId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // 데이터베이스에서 가져온 열을 사용하여 Approval 객체 생성
                        Approval approval = new Approval
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            RequestId = reader.GetInt32(reader.GetOrdinal("request_id")),
                            ApproverId = reader.GetInt32(reader.GetOrdinal("approver_id")),
                            FirstApproverId = reader.GetInt32(reader.GetOrdinal("first_approver_id")),
                            SecondApproverId = reader.GetInt32(reader.GetOrdinal("second_approver_id")),
                            ApprovalDate = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                            Title = reader.GetString(reader.GetOrdinal("title")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Comment = reader.GetString(reader.GetOrdinal("comments")),
                            Status = (Approval.ApprovalStatus)reader.GetInt32(reader.GetOrdinal("status")),
                            RoleStatus = (Role)reader.GetInt32(reader.GetOrdinal("role_status")), // RoleStatus가 데이터베이스 스키마에 없다면 주석 처리
                            Memo = reader.GetString(reader.GetOrdinal("memo")),
                            RelatedTask = reader.GetString(reader.GetOrdinal("related_task")),

                        };

                        return approval;
                    }
                }
            }

            // 데이터를 찾지 못한 경우 null 반환
            return null;
        }




        private void InitializeConnection()
        {
            string connectionString = "Server=115.85.181.212;Database=s5701562;Uid=s5701562;Pwd=s5701562;Charset=utf8";

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // 내가 등록한 결재 검색
        public List<Approval> GetAllApprovalsByUserId(int userId)
        {
            List<Approval> approvals = new List<Approval>();

            // 유저 ID를 사용하여 해당 유저에 관련된 모든 결재를 검색
            string query = "SELECT * FROM approval WHERE request_id = @userId";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 데이터베이스에서 가져온 열을 사용하여 Approval 객체 생성
                        Approval approval = new Approval
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            RequestId = reader.GetInt32(reader.GetOrdinal("request_id")),
                            ApproverId = reader.GetInt32(reader.GetOrdinal("approver_id")),
                            FirstApproverId = reader.GetInt32(reader.GetOrdinal("first_approver_id")),
                            SecondApproverId = reader.GetInt32(reader.GetOrdinal("second_approver_id")),
                            ApprovalDate = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                            Title = reader.GetString(reader.GetOrdinal("title")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Comment = reader.GetString(reader.GetOrdinal("comments")),
                            Status = (Approval.ApprovalStatus)reader.GetInt32(reader.GetOrdinal("status")),
                            RoleStatus = (Role)reader.GetInt32(reader.GetOrdinal("role_status")), // RoleStatus가 데이터베이스 스키마에 없다면 주석 처리
                            Memo = reader.GetString(reader.GetOrdinal("memo")),
                            RelatedTask = reader.GetString(reader.GetOrdinal("related_task")),

                        };

                        approvals.Add(approval);
                    }
                }
            }

            return approvals;
        }

        public List<Approval> GetPendingApprovalsByUserId(int userId)
        {
            List<Approval> pendingApprovals = new List<Approval>();

            // 유저 ID를 사용하여 해당 유저에 관련된 "결재 중"인 결재를 검색
            string query = "SELECT * FROM approval WHERE approver_id = @userId AND status = @status";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@status", (int)Approval.ApprovalStatus.Pending);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 데이터베이스에서 가져온 열을 사용하여 Approval 객체 생성
                        Approval approval = new Approval
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            RequestId = reader.GetInt32(reader.GetOrdinal("request_id")),
                            ApproverId = reader.GetInt32(reader.GetOrdinal("approver_id")),
                            FirstApproverId = reader.GetInt32(reader.GetOrdinal("first_approver_id")),
                            SecondApproverId = reader.GetInt32(reader.GetOrdinal("second_approver_id")),
                            ApprovalDate = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                            Title = reader.GetString(reader.GetOrdinal("title")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Comment = reader.GetString(reader.GetOrdinal("comments")),
                            Status = (Approval.ApprovalStatus)reader.GetInt32(reader.GetOrdinal("status")),
                            RoleStatus = (Role)reader.GetInt32(reader.GetOrdinal("role_status")), // RoleStatus가 데이터베이스 스키마에 없다면 주석 처리
                            Memo = reader.GetString(reader.GetOrdinal("memo")),
                            RelatedTask = reader.GetString(reader.GetOrdinal("related_task")),

                        };

                        pendingApprovals.Add(approval);
                    }
                }
            }

            return pendingApprovals;
        }

        /// <summary>
        /// 1차 승인자가 자신인 결재를 불러오는 함수
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Approval> GetFirstApproverIsMeByUserId(int userId)
        {
            List<Approval> pendingApprovals = new List<Approval>();

            // 유저 ID를 사용하여 해당 유저에 관련된 "결재 중"인 결재를 검색
            string query = "SELECT * FROM approval WHERE first_approver_id = @userId AND status = @status";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@status", (int)Approval.ApprovalStatus.Pending); // 결재 중인 상태


                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 데이터베이스에서 가져온 열을 사용하여 Approval 객체 생성
                        Approval approval = new Approval
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            RequestId = reader.GetInt32(reader.GetOrdinal("request_id")),
                            ApproverId = reader.GetInt32(reader.GetOrdinal("approver_id")),
                            FirstApproverId = reader.GetInt32(reader.GetOrdinal("first_approver_id")),
                            SecondApproverId = reader.GetInt32(reader.GetOrdinal("second_approver_id")),
                            ApprovalDate = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                            Title = reader.GetString(reader.GetOrdinal("title")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Comment = reader.GetString(reader.GetOrdinal("comments")),
                            Status = (Approval.ApprovalStatus)reader.GetInt32(reader.GetOrdinal("status")),
                            RoleStatus = (Role)reader.GetInt32(reader.GetOrdinal("role_status")),
                            Memo = reader.GetString(reader.GetOrdinal("memo")),
                            RelatedTask = reader.GetString(reader.GetOrdinal("related_task")),

                        };

                        pendingApprovals.Add(approval);
                    }
                }
            }

            return pendingApprovals;
        }

        public List<Approval> GetCompletedApprovalsByUserId(int userId)
        {
            List<Approval> completedApprovals = new List<Approval>();

            // 유저 ID를 사용하여 해당 유저에 관련된 "결재 완료"된 결재를 검색
            string query = "SELECT * FROM approval WHERE (first_approver_id = @userId OR second_approver_id = @userId) AND status = @status";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@status", (int)Approval.ApprovalStatus.Approved); // 결재 완료 상태

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 데이터베이스에서 가져온 열을 사용하여 Approval 객체 생성
                        Approval approval = new Approval
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            RequestId = reader.GetInt32(reader.GetOrdinal("request_id")),
                            ApproverId = reader.GetInt32(reader.GetOrdinal("approver_id")),
                            FirstApproverId = reader.GetInt32(reader.GetOrdinal("first_approver_id")),
                            SecondApproverId = reader.GetInt32(reader.GetOrdinal("second_approver_id")),
                            ApprovalDate = reader.GetDateTime(reader.GetOrdinal("approval_date")),
                            Title = reader.GetString(reader.GetOrdinal("title")),
                            Description = reader.GetString(reader.GetOrdinal("description")),
                            Comment = reader.GetString(reader.GetOrdinal("comments")),
                            Status = (Approval.ApprovalStatus)reader.GetInt32(reader.GetOrdinal("status")),
                            RoleStatus = (Role)reader.GetInt32(reader.GetOrdinal("role_status")), // RoleStatus가 데이터베이스 스키마에 없다면 주석 처리
                            Memo = reader.GetString(reader.GetOrdinal("memo")),
                            RelatedTask = reader.GetString(reader.GetOrdinal("related_task")),


                        };

                        completedApprovals.Add(approval);
                    }
                }
            }

            return completedApprovals;
        }

        public List<(int, string)> GetFirstApproverIdsList()
        {
            List<(int, string)> firstApproverIdList = new List<(int, string)>();

            string query = "SELECT user_id, email FROM user WHERE user_role = 1";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        firstApproverIdList.Add((reader.GetInt32(reader.GetOrdinal("user_id")), reader.GetString(reader.GetOrdinal("email"))));
                    }
                }
            }

            return firstApproverIdList;
        }


        public User GetUserByEmail(string email)
        {
            string query = "SELECT * FROM user WHERE email = @email";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // 데이터베이스에서 가져온 열을 사용하여 Approval 객체 생성
                        User user = new User
                        {
                            UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            Password = reader.GetString(reader.GetOrdinal("password")),
                            UserRole = (Role)reader.GetInt32(reader.GetOrdinal("user_role")),
                        };

                        return user;
                    }
                }
            }
            return null; // 값을 찾지 못한 경우 null 반환
        }

        internal List<string> GetChattingListByUserId(int userId)
        {
            string query = "SELECT DISTINCT u.email FROM user u WHERE u.id IN (" +
                "SELECT DISTINCT m.sender_id" +
                "FROM message m" +
                "WHERE m.receivedr_id = @userId" +
                "UNION" +
                "SELECT DISTINCT m.receiver_id" +
                "FROM message m" +
                "WHERE m.sender_id = @userId" +
                ");";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                List<string> chattingList = new List<string>();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        chattingList.Add(reader.GetInt32(reader.GetOrdinal("user_id")).ToString());
                    }
                }
                return chattingList;
            }
        }

        private void InitializeDataGridView(DataGridView dataGridView)
        {
            // DataSource를 null로 설정하여 DataGridView의 데이터를 지웁니다.
            dataGridView.DataSource = null;

            // DataGridView의 컬럼들을 지웁니다.
            dataGridView.Columns.Clear();
        }


        // 진행 중인 결재 목록에 들어갈 데이터 불러오기
        internal void LoadDataGridViewApprovalList(DataGridView dataGridViewApprovalList)
        {
            // 결재 제목 / 진행 상태 등록일(이건 교수님 요구사항에 없어서 다른 것들 다 하고 추가할 예정)
            // 정렬  진행 중 > 반려 > 결재 

            string query = "SELECT title, " +
                           "CASE " +
                           "   WHEN status = 0 THEN '보류 중' " +
                           "   WHEN status = 1 THEN '승인됨' " +
                           "   WHEN status = 2 THEN '반려됨' " +
                           "   ELSE '알 수 없음' " + // 예상치 못한 값에 대한 ELSE 절을 추가할 수 있습니다
                           "END AS status " +
                           "FROM approval " +
                           "WHERE request_id = @myId";

            using (MySqlCommand cmd = new MySqlCommand(@query, connection))
            {
                cmd.Parameters.AddWithValue("@myId", myInfo.userId);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 열의 헤더 텍스트 변경
                    dt.Columns["status"].ColumnName = "결재 상태";
                    dt.Columns["title"].ColumnName = "결재 제목";

                    InitializeDataGridView(dataGridViewApprovalList);
                    dataGridViewApprovalList.DataSource = dt;
                }
            }
        }



        internal void LoadDataGridViewTaskSummary(DataGridView dataGridViewTaskSummary)
        {
            string query = "SELECT " +
                "(SELECT COUNT(*) FROM approval WHERE status = 0 AND request_id = @myId) AS count_pending_approval, " +
                "(SELECT COUNT(*) FROM approval WHERE status = 1 AND request_id = @myId) AS count_approved_approval, " +
                "(SELECT COUNT(*) FROM approval WHERE status = 2 AND request_id = @myId) AS count_rejected_approval ";



            using (MySqlCommand cmd = new MySqlCommand(@query, connection))
            {
                cmd.Parameters.AddWithValue("@myId", myInfo.userId);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns["count_pending_approval"].ColumnName = "결재진행 중인 건 수";
                    dt.Columns["count_approved_approval"].ColumnName = "결재승인된 건 수";
                    dt.Columns["count_rejected_approval"].ColumnName = "결재 반려된 건 수";

                    InitializeDataGridView(dataGridViewTaskSummary);
                    dataGridViewTaskSummary.DataSource = dt;
                }
            }
        }

        internal List<Message> GetMessagesByEmail(string email, string opponentUserEmail)
        {
            List<Message> messages = new List<Message>();

            string query = "SELECT * FROM message " +
                           "WHERE (sender_id = @senderId AND receiver_id = @receiverId) " +
                           "   OR (sender_id = @receiverId AND receiver_id = @senderId) " +
                           "ORDER BY sent_at";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@senderId", GetUserIdByEmail(email));
                cmd.Parameters.AddWithValue("@receiverId", GetUserIdByEmail(opponentUserEmail));
                Console.WriteLine($"getting message / senderID: {GetUserIdByEmail(email)} / receiverid: {GetUserIdByEmail(opponentUserEmail)} ");


                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Message message = new Message
                            {
                                senderId = reader.GetInt32("sender_id"),
                                receiverId = reader.GetInt32("receiver_id"),
                                content = reader.GetString("content"),
                                sentAt = reader.GetDateTime("sent_at")
                            };

                            messages.Add(message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 예외 처리: 가져오는 중에 오류가 발생한 경우
                    Console.WriteLine("Error getting messages: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return messages;
        }

        // 이메일로부터 사용자 ID를 가져오는 보조 함수
        private int GetUserIdByEmail(string email)
        {
            string query = "SELECT user_id FROM user WHERE email = @email";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting user ID: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return -1; // 실패한 경우 -1을 반환하거나 예외 처리 방식을 조정할 수 있습니다.
        }

        internal bool SaveMessage(Message message)
        {
            string query = "INSERT INTO message (sender_id, receiver_id, content, sent_at) " +
                           "VALUES (@senderId, @receiverId, @content, @sentAt)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@senderId", message.senderId);
                cmd.Parameters.AddWithValue("@receiverId", message.receiverId);
                cmd.Parameters.AddWithValue("@content", message.content);
                cmd.Parameters.AddWithValue("@sentAt", message.sentAt);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // 저장이 성공적으로 이루어졌으면 rowsAffected는 1 이상이 됩니다.
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // 예외 처리: 저장 중에 오류가 발생한 경우
                    Console.WriteLine("Error saving message: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        internal List<Message> GetMessagesById(int userId, int opponentUserId)
        {
            List<Message> messages = new List<Message>();

            string query = "SELECT * FROM message " +
                           "WHERE (sender_id = @userId AND receiver_id = @opponentUserId) " +
                           "   OR (sender_id = @opponentUserId AND receiver_id = @userId) ";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@opponentUserId", opponentUserId);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Message message = new Message
                            {
                                senderId = reader.GetInt32("sender_id"),
                                receiverId = reader.GetInt32("receiver_id"),
                                content = reader.GetString("content"),
                                sentAt = reader.GetDateTime("sent_at")
                            };

                            messages.Add(message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting messages: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return messages;
        }

    }
}
