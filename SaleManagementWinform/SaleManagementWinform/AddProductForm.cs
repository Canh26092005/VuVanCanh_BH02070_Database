using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txb_code.Text) ||
                    string.IsNullOrWhiteSpace(txb_name.Text) ||
                    string.IsNullOrWhiteSpace(txb_amount.Text) ||
                    string.IsNullOrWhiteSpace(txb_price.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse numeric inputs
                string productCode = txb_code.Text.Trim();
                string productName = txb_name.Text.Trim();
                int quantity;
                decimal price;

                // Validate quantity and price inputs
                if (!int.TryParse(txb_amount.Text.Trim(), out quantity))
                {
                    MessageBox.Show("Invalid quantity. Please enter a whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txb_price.Text.Trim(), out price))
                {
                    MessageBox.Show("Invalid price. Please enter a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert data into the database
                InsertData(productCode, productName, quantity, price);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertData(string code, string name, int amount, decimal price)
        {
            string query = "INSERT INTO Product (Code, Name, Quantity, Price) VALUES (@Code, @Name, @Quantity, @Price)";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Quantity", amount);
                        command.Parameters.AddWithValue("@Price", price);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Check your data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txb_code.Text))
                {
                    MessageBox.Show("Please enter a product code to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string productCode = txb_code.Text.Trim();
                DeleteData(productCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteData(string code)
        {
            string query = "DELETE FROM Product WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given code.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
