using System;
using System.Data;
using System.Data.SqlClient;

namespace YourNamespace
{
    public partial class BookingsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Fetch data from the database and populate the form fields, if needed
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            string customerID = customerID.Value;
            string selectedDate = datepicker.Value;

            // Insert the data into the tblBookings table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblBookings (CustomerID, Date) VALUES (@CustomerID, @Date)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@Date", selectedDate);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Clear the form fields after submission if needed
            customerID.Value = string.Empty;
            datepicker.Value = string.Empty;
        }
    }
}
