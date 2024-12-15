using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class PurchaseHistory : Form
    {
        // Chuỗi kết nối cơ sở dữ liệu
        private string connectionString = Connection.SQLConnection;

        // Trạng thái hiển thị
        private string[] items = { "All", "Cancelled", "Pending", "Finished" };

        public PurchaseHistory()
        {
            InitializeComponent();

            // Cài đặt giao diện ban đầu
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
       

        private void LoadPurchaseData()
        {
            string query = "SELECT * FROM PurchaseHistory";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPurchase main = new AddPurchase();
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPurchaseData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim();
            LoadPurchaseHistoryWithDetails(dataGridView1, 0, searchKeyword); // Mặc định 0 (All)
        }

        private void LoadPurchaseHistoryWithDetails(DataGridView dataGridView, int statusIndex, string searchKeyword = "")
        {
            string query = @"
                SELECT 
                    ph.PurchaseID,
                    ph.CustomerID,
                    c.CustomerName,
                    ph.Code,
                    p.name AS ProductName,
                    ph.PurchaseDate,
                    ph.Quantity,
                    ph.[status],
                   
                FROM 
                    PurchaseHistory ph
                INNER JOIN 
                    Product p ON ph.Code = p.code
                INNER JOIN 
                    Customer c ON ph.CustomerID = c.CustomerID
                WHERE 
                   
                    AND (ph.PurchaseID LIKE @searchKeyword 
                         OR c.CustomerName LIKE @searchKeyword 
                         OR p.name LIKE @searchKeyword)";

            if (statusIndex != 0) // Không phải "All"
            {
                query += " AND ph.[status] = @status";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");

                    if (statusIndex != 0)
                    {
                        command.Parameters.AddWithValue("@status", items[statusIndex]);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message);
                }
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && PasswordHasher.roleID != 3)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    string purchaseID = selectedRow.Cells["PurchaseID"].Value.ToString();
                    string customerID = selectedRow.Cells["CustomerID"].Value.ToString();
                    string productCode = selectedRow.Cells["Code"].Value.ToString();
                    string purchaseDate = Convert.ToDateTime(selectedRow.Cells["PurchaseDate"].Value).ToString("dd/MM/yyyy");
                    int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                    int status = Convert.ToInt32(selectedRow.Cells["status"].Value);
                    int active = Convert.ToInt32(selectedRow.Cells["active"].Value); // Đảm bảo cột 'active' tồn tại và có dữ liệu

                    // Gọi constructor với đủ tham số
                    Updatepurchase updateForm = new Updatepurchase(customerID, purchaseID, productCode, purchaseDate, quantity, status, active);
                    updateForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while processing: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to perform this action.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuForm mainForm = new MenuForm();
            mainForm.Show();
            this.Hide();

        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            LoadPurchaseData();
        }
    }
}
