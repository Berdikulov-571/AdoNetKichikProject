using AdoNetProject.Dtos;
using AdoNetProject.Enums;
using AdoNetProject.Interfaces;
using System.Data.SqlClient;

namespace AdoNetProject.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StudyCenterDB;Trusted_Connection=True;";
        public void CreateEmployee(EmployeeDTO employee)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string query = $"insert into Employee(Name,Surname,Email,Login,Password,Status,Role) values('{employee.Name}', '{employee.Surname}', '{employee.Email}','{employee.Login}','{employee.Password}','{Status.Created}','{employee.Role}')";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader()) { }
            }
        }

        public void DeleteEmployee(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public void EmployeeDeepDelete(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public void GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeById(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }
    }
}
