using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Accreditation
{
    internal class DataManager
    {
        private readonly string connectionString = "server=localhost; database=accreditation; uid=root; pwd=root;";

        public bool AuthenticateUser(string email, string password)
        {
            using (var conn = new MySqlConnection(connectionString))

            {
                conn.Open();
                var query = $"SELECT COUNT(1) FROM users WHERE Email=@Email AND Password=@Password";
                using (var cmd = new MySqlCommand(query, conn))

                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return count == 1;

                }

            }

        }
        public void InsertUser(
            string username, string email, string firstName, string lastName,
            string phoneNum, string password, int role, int status)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("AddUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_username", username);
                        cmd.Parameters.AddWithValue("@p_email", email);
                        cmd.Parameters.AddWithValue("@p_firstName", firstName);
                        cmd.Parameters.AddWithValue("@p_lastName", lastName);
                        cmd.Parameters.AddWithValue("@p_phoneNum", phoneNum);
                        cmd.Parameters.AddWithValue("@p_pass", password);
                        cmd.Parameters.AddWithValue("@p_role", role);
                        cmd.Parameters.AddWithValue("@p_status", status);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Log or rethrow with more context if needed
                throw new ApplicationException("Database error while inserting user: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Unexpected error while inserting user: " + ex.Message, ex);
            }
        }

        public List<string> LoadCollegeNames()
        {
            List<string> collegeNames = new List<string>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString)) // uses the private field
                {
                    conn.Open();
                    string query = "SELECT college_name FROM colleges ORDER BY college_name ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            collegeNames.Add(reader["college_name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to retrieve college names.", ex);
            }

            return collegeNames;
        }

        public DataTable GetCollegeOrgCounts()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("StudentOrgsInColleges", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void UpdateUser(string username, string password, string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "UPDATE Accounts SET Pass = @Password, Email = @Email WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void DeleteUser(string username)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "DELETE FROM accounts WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT UserID, Username, pass as Password, Email FROM accounts";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        //For account recovery
        public bool DoesEmailExist(string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT COUNT(*) FROM users WHERE Email = @Email";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void SaveResetCode(string email, string code)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "INSERT INTO password_resets (Email, ResetCode, CreatedAt) VALUES (@Email, @Code, NOW())";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.ExecuteNonQuery();
            }
        }

        public bool VerifyResetCode(string email, string code)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT COUNT(*) FROM password_resets WHERE Email = @Email AND ResetCode = @Code AND CreatedAt > NOW() - INTERVAL 15 MINUTE";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Code", code);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void UpdatePasswordByEmail(string email, string newPassword)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "UPDATE users SET Pass = @Pass WHERE Email = @Email";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pass", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }
        //DELETE USER ACCOUNT
        public bool EmailExists(string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void DeleteUserByEmail(string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM users WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }
        public User SearchUserByUsername(string username)
        {
            User user = null;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT Username, Pass, Email FROM Accounts WHERE Username = @Username";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User()
                            {
                                //UserId = reader.GetInt32("UserId"),
                                Username = reader["Username"].ToString(),
                                password = reader["Pass"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                    conn.Close();
                }
            }
            return user;
        }

        //UPDATE USER

        public User GetUserByEmail(string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT FirstName, LastName, Email FROM users WHERE Email = @Email";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Email = reader["Email"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool UpdateUserByEmail(string email, string firstName, string lastName, string password, string username, string phoneNum)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UpdateUserDetailsByEmail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userEmail", email);
                    cmd.Parameters.AddWithValue("@userFirstName", firstName);
                    cmd.Parameters.AddWithValue("@userLastName", lastName);
                    cmd.Parameters.AddWithValue("@userPassword", password); // or hash it
                    cmd.Parameters.AddWithValue("@userNameUp", username);
                    cmd.Parameters.AddWithValue("@userPhoneNum", phoneNum);

                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows > 0;
                }
            }
        }
        public class User
        {
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string PhoneNum { get; set; }
            public string password { get; set; }
            public string Email { get; set; }
        }

    }
}
