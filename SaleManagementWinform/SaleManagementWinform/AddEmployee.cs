using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        // Hàm băm mật khẩu sử dụng SHA256
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); // Chuyển đổi sang dạng hex
                }
                return builder.ToString();
            }
        }


        // Sự kiện nhấn nút Save
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string fullname = tbx_name.Text;
            string code = tbx_code.Text;
            string username = tbx_username.Text;
            string password = tbx_password.Text;
            string hashPassword = HashPassword(password); // Băm mật khẩu
            string position = tbx_position.Text;

            int roleID = 2; // Ví dụ gán vai trò là 2 (thay đổi theo yêu cầu của bạn)

            // Gọi hàm InsertData để lưu vào cơ sở dữ liệu
            InsertData(code, fullname, position, roleID, username, hashPassword);
        }

        // Hàm thêm dữ liệu vào cơ sở dữ liệu
        private void InsertData(string code, string name, string position, int roleID, string username, string password)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = Connection.SQLConnection;

            // Câu lệnh SQL chèn dữ liệu
            string query = "INSERT INTO Employee (code, name, position, roleId, username, password, active) " +
                           "VALUES (@code, @name, @position, @roleId, @username, @password, 1)";

            // Kết nối đến cơ sở dữ liệu và thực thi câu lệnh SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL để tránh SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@roleId", roleID);  // Thêm roleId vào câu lệnh
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password); // Thêm mật khẩu đã mã hóa

                        // Thực thi câu lệnh SQL và lấy số dòng bị ảnh hưởng
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // Các sự kiện không sử dụng có thể bỏ qua
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
        }
    }
}