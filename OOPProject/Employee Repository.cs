using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace OOPProject
{
    public class Employee_Repository
    {
        //Properties AND database connection
        public List<Employee> Employees = new List<Employee>();
        private string connectionsrting = "Data Source=FATIMA_MASOOD\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
        //Adding Employee
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            AddEmployeeToDatabase(employee);
            
        }
        public void AddEmployeeToDatabase(Employee Emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionsrting))
            {
                connection.Open();

                string query = "INSERT INTO Employees( Employee_ID,Employee_Name, Employee_Email, Employee_Contact, Employee_Salary, Employee_CNIC)" +
                    "VALUES(@Employee_ID, @Employee_Name, @Employee_Email, @Employee_Contact, @Employee_Salary, @Employee_CNIC)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Employee_ID", Emp.Employee_ID);
                    command.Parameters.AddWithValue("@Employee_Name", Emp.Name);
                    command.Parameters.AddWithValue("@Employee_Email", Emp.Email);
                    command.Parameters.AddWithValue("@Employee_Contact", Emp.Contact_Number);
                    command.Parameters.AddWithValue("@Employee_Salary", Emp.Employee_Salary);
                    command.Parameters.AddWithValue("@Employee_CNIC", Emp.CNIC);

                    command.ExecuteNonQuery();
                }
            }
        }
        //Deleting Employee
        public void DeleteEmployee(Employee emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionsrting))
            {
                connection.Open();
                string query = "DELETE FROM Employees WHERE Employee_ID = @Employee_ID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Employee_ID", emp.Employee_ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Displaying Employees
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionsrting))
            {
                connection.Open();
                string Query = "SELECT* FROM Employees";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee emp = new Employee
                        {
                            Employee_ID = Convert.ToInt32(reader["Employee_ID"]),
                            Name = reader["Employee_Name"].ToString(),
                            Email = reader["Employee_Email"].ToString(),
                            CNIC = reader["Employee_CNIC"].ToString(),
                            Contact_Number = Convert.ToInt64(reader["Employee_Contact"]),
                            Employee_Salary = Convert.ToInt64(reader["Employee_Salary"])
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }
        //Updating Employee
        public void UpdateEmployee(Employee Emp)
        {
            using(SqlConnection connection = new SqlConnection())
            {
                connection.Open();
                string query = "UPDATE Employees SET  Employee_Name = @Employee_Name, Employee_Email = @Employee_Email, Employee_Contact =@Employee_Contact, Employee_Salary =@Employee_Salary, Employee_CNIC=@Employee_CNIC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Employee_ID", Emp.Employee_ID);
                    command.Parameters.AddWithValue("@Employee_Name", Emp.Name);
                    command.Parameters.AddWithValue("@Employee_Email", Emp.Email);
                    command.Parameters.AddWithValue("@Employee_Contact", Emp.Contact_Number);
                    command.Parameters.AddWithValue("@Employee_Salary", Emp.Employee_Salary);
                    command.Parameters.AddWithValue("@Employee_CNIC", Emp.CNIC);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DisplayEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionsrting))
            {
                connection.Open();
                string Query = "SELECT Employee_ID,Employee_Name, Employee_Email, Employee_Contact, Employee_Salary, Employee_CNIC FROM Employees WHERE Employee_ID = @Employee_ID";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@Employee_ID", employee.Employee_ID);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {


                            employee.Employee_ID = Convert.ToInt32(reader["Employee_ID"]);
                            employee.Name = reader["Employee_Name"].ToString();
                            employee.Email = reader["Employee_Email"].ToString();
                            employee.CNIC = reader["Employee_CNIC"].ToString();
                            employee.Contact_Number = Convert.ToInt64(reader["Employee_Contact"]);
                             employee.Employee_Salary = Convert.ToInt64(reader["Employee_Salary"]);
                        }
                    }
                }

            }
        }
    }
}
