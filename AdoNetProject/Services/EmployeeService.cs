using AdoNetProject.Models;
using System.Data.SqlClient;

namespace AdoNetProject.Services
{
    public class EmployeeService
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";
        public static void CreateEmployee(Employee employee)
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = $"insert into userTable(Name,Surname,Email,Login,Password,Status,Role) values('{employee.Name}', '{employee.Surname}', '')";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader()) { }
            }
        }
    }
}
