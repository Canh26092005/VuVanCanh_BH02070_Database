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
    public partial class AddPurchase : Form
    {
        public AddPurchase()
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InsertData(string PurchaseID, string CustomerCode, string productCode, DateTime PurchaseDate, int Quantity, int status)
        {
            // SQL query to insert data
            string query = "INSERT INTO PurchaseHistory (PurchaseID, CustomerCode, productCode, PurchaseDate, Quantity, status) VALUES (@PurchaseID, @customerCode, @productCode, @purchaseDate, @quantity, @status)";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        command.Parameters.AddWithValue("@CustomerCode", CustomerCode);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@status", status);

                        // Execute the command
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string purchaseDateStr = txb_purchasedate.Text;
            DateTime purchaseDate;

            // Định dạng ngày tháng mong đợi
            string[] dateFormats = { "dd/MM/yyyy", "yyyy-MM-dd" };

            if (DateTime.TryParseExact(purchaseDateStr, dateFormats,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out purchaseDate))
            {
                MessageBox.Show("Ngày hợp lệ: " + purchaseDate.ToString("dd/MM/yyyy"));
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ! Hãy nhập theo định dạng dd/MM/yyyy hoặc yyyy-MM-dd.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Purchase = txb_purchaseid.Text.Trim();
            string Customer = txb_customeid.Text.Trim();
            string masp = txb_code.Text.Trim();
            int Soluong, status;
            DateTime ngay;

            // Kiểm tra ngày tháng hợp lệ
            string[] dateFormats = { "dd/MM/yyyy", "yyyy-MM-dd" };
            if (!DateTime.TryParseExact(txb_purchasedate.Text, dateFormats,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out ngay))
            {
                MessageBox.Show("Ngày không hợp lệ! Vui lòng nhập theo định dạng dd/MM/yyyy hoặc yyyy-MM-dd.");
                return;
            }

            // Kiểm tra số lượng
            if (!int.TryParse(txb_quantity.Text, out Soluong))
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            // Kiểm tra trạng thái
            if (!int.TryParse(txb_status.Text, out status))
            {
                MessageBox.Show("Trạng thái không hợp lệ!");
                return;
            }

            // Thêm dữ liệu vào database
            InsertData(Purchase, Customer, masp, ngay, Soluong, status);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the text in all TextBoxes
            txb_purchaseid.Text = string.Empty;
            txb_customeid.Text = string.Empty;
            txb_code.Text = string.Empty;
            txb_purchasedate.Text = string.Empty;
            txb_quantity.Text = string.Empty;
            txb_status.Text = string.Empty;
        }

        private void AddPuchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel the close event and hide the form instead
            e.Cancel = true;
            this.Hide();
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txb_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_purchasedate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
