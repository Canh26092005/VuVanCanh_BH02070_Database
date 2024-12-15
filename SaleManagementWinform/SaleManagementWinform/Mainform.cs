using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            /*this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);*/

            // set the form border style to ensure it has a standard window look
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // optionally, set startposition to centerscreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoadProductData()
        {

            // SQL query to fetch data
            string query = "SELECT * FROM Product";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with query results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void AddEmployee(string name, string username, string password, int roleId)
        {
            string query = "INSERT INTO Employee (name, username, password, roleId) VALUES (@name, @username, @password, @roleId)";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void UpdateEmployee(int employeeId, string name, string username, string password, int roleId)
        {
            string query = "UPDATE Employee SET name = @name, username = @username, password = @password, roleId = @roleId WHERE employeeId = @employeeId";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM Employee WHERE employeeId = @employeeId";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private DataTable SearchEmployee(string searchTerm)
        {
            string query = "SELECT * FROM Employee WHERE name LIKE @searchTerm";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        private void AddProduct(string name, decimal price, int stockQuantity)
        {
            string query = "INSERT INTO Product (name, price, stockQuantity) VALUES (@name, @price, @stockQuantity)";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stockQuantity", stockQuantity);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void UpdateProduct(int productId, string name, decimal price, int stockQuantity)
        {
            string query = "UPDATE Product SET name = @name, price = @price, stockQuantity = @stockQuantity WHERE productId = @productId";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stockQuantity", stockQuantity);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void DeleteProduct(int productId)
        {
            string query = "DELETE FROM Product WHERE productId = @productId";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@productId", productId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void AddCustomer(string name, string email, string phone)
        {
            string query = "INSERT INTO Customer (name, email, phone) VALUES (@name, @email, @phone)";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void UpdateCustomer(int customerId, string name, string email, string phone)
        {
            string query = "UPDATE Customer SET name = @name, email = @email, phone = @phone WHERE customerId = @customerId";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void DeleteCustomer(int customerId)
        {
            string query = "DELETE FROM Customer WHERE customerId = @customerId";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private DataTable SearchCustomer(string searchTerm)
        {
            string query = "SELECT * FROM Customer WHERE name LIKE @searchTerm";
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }













        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm main = new AddProductForm();
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadProductData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from each cell in the selected row
                var code = selectedRow.Cells["Code"].Value.ToString();
                var name = selectedRow.Cells["Name"].Value.ToString();
                var price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
                var quantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());

                // Display data in textboxes or labels, or use it as needed
                /*  txtID.Text = id.ToString();
                  txtName.Text = name;
                  txtAge.Text = age.ToString();*/

                // MessageBox.Show($"Code  : {code}, Name: {name}, Price: {price},  Quantity: {quantity}");


                UpdateProduct updateProduct = new UpdateProduct(code, name, price, quantity);
                updateProduct.ShowDialog();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(textBox1.Text);
        }
        private void SearchProduct(string searchText)
        {
            // Nếu textbox tìm kiếm rỗng, hiển thị tất cả dữ liệu
            if (string.IsNullOrEmpty(searchText))
            {
                LoadProductData(); // Gọi lại hàm load dữ liệu ban đầu
            }
            else
            {
                // Viết câu lệnh SQL tìm kiếm sản phẩm theo mã hoặc tên
                string query = "SELECT * FROM Product WHERE Code LIKE @searchText OR Name LIKE @searchText";

                // Thực thi truy vấn và cập nhật DataGridView
                using (SqlConnection conn = new SqlConnection(Connection.SQLConnection))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Gán kết quả tìm kiếm vào DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuForm mainForm = new MenuForm();
            mainForm.Show();
            this.Hide();

        }
    }
}
