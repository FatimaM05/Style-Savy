using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace OOPProject
{
    public class Customer_Repository
    {
        //Properties AND database connection
        public List<Customer> Customers = new List<Customer>();
        private string connectionstring = "Data Source=FATIMA_MASOOD\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
        //Adding Customer
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void AddCustomerToDatabase(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                string query = "INSERT INTO Customer(Customer_ID, Customer_Name, Customer_Email, Customer_Contact, Customer_CNIC,Membership )" +
                    "VALUES(@Customer_ID, @Customer_Name, @Customer_Email, @Customer_Contact, @Customer_CNIC, @Membership )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Customer_ID", customer.Customer_Id);
                    command.Parameters.AddWithValue("@Customer_Name", customer.Name);
                    command.Parameters.AddWithValue("@Customer_Email", customer.Email);
                    command.Parameters.AddWithValue("@Customer_Contact", customer.Contact_Number);
                    command.Parameters.AddWithValue("@Customer_CNIC", customer.CNIC);
                    command.Parameters.AddWithValue("Membership", customer.Membership);

                    command.ExecuteNonQuery();
                }
            }
        }
        //Deleting Customer
        public void DeleteCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "DELETE FROM Customer WHERE Customer_ID = @Customer_ID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Customer_ID", customer.Customer_Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Displaying Customer
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string Query = " SELECT* FROM Customer";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       Customer cusm = new Customer
                        {
                            Customer_Id = Convert.ToInt32(reader["Customer_ID"]),
                            Name = reader["Customer_Name"].ToString(),
                            Email = reader["Customer_Email"].ToString(),
                            CNIC = reader["Customer_CNIC"].ToString(),
                            Membership = reader["Membership"].ToString(),
                            Contact_Number = Convert.ToInt64(reader["Customer_Contact"]
                            )
                        };
                        customers.Add(cusm);
                    }
                }
            }
            return customers;
        }
        //Updating Customer
        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.Open();
                string query = "UPDATE Employee SET  Customer_Name = @Customer_Name, Customer_Email = @Customer_Email, Customer_CNIC=@Customer_CNIC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Customer_ID", customer.Customer_Id);
                    command.Parameters.AddWithValue("@Customer_Name", customer.Name);
                    command.Parameters.AddWithValue("@Customer_Email", customer.Email);
                    command.Parameters.AddWithValue("@Customer_Contact", customer.Contact_Number);
                    command.Parameters.AddWithValue("@Customer_CNIC", customer.CNIC);
                    command.Parameters.AddWithValue("Membership", customer.Membership);

                    command.ExecuteNonQuery();
                }
            }
        }
        //Displaying Customer details
        public void DisplayCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string Query = "SELECT Customer_ID,Customer_Name, Customer_Email, Customer_CNIC,Customer_Contact, Membership FROM Customer WHERE Customer_ID = @Customer_ID";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@Customer_ID", customer.Customer_Id);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            
                                customer.Customer_Id = Convert.ToInt32(reader["Customer_ID"]);
                                customer.Name = reader["Customer_Name"].ToString();
                                customer.Email = reader["Customer_Email"].ToString();
                                customer.CNIC = reader["Customer_CNIC"].ToString();
                                customer.Membership = reader["Membership"].ToString();
                                customer.Contact_Number = Convert.ToInt64(reader["Customer_Contact"]);
                        }
                    }
                }

            }
        }
    }
}
