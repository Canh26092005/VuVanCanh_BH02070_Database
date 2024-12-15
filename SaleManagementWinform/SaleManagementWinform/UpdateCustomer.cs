using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer(string code, string name, string phoneNumber, string address)
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Disable the maximize/restore button
            this.MaximizeBox = false;
            // Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Populate textboxes with provided data
            tbx_code.Text = code;
            tbx_name.Text = name;
            tbx_address.Text = address;
            tbx_phone.Text = phoneNumber;
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            // Perform any additional initialization if needed
        }

        // Method to update customer information in the database
        private void UpdateCustomerInDatabase(string code, string name, string phoneNumber, string address)
        {
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Code and Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Customer SET name = @name, address = @address, phoneNumber = @phoneNumber WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // Method to "soft delete" customer (set active to 0)
        private void DeleteCustomerFromDatabase(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Code cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Customer SET is_active = 0 WHERE code = @code";
            

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@code", code);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Collect data from textboxes
            string code = tbx_code.Text.Trim();
            string name = tbx_name.Text.Trim();
            string address = tbx_address.Text.Trim();
            string phoneNumber = tbx_phone.Text.Trim();

            // Update customer in the database
            UpdateCustomerInDatabase(code, name, phoneNumber, address);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the customer from the database
                DeleteCustomerFromDatabase(tbx_code.Text.Trim());
            }
        }
    }
}