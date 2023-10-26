using AdoNetProject.Dtos;
using AdoNetProject.Models;
using AdoNetProject.Services;

namespace AdoNetProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employee = new EmployeeService();

            //employee.DeleteEmployee(7);

            EmployeeDTO em = new EmployeeDTO();

            //employee.GetEmployeeById(7);

            em.Name = "sanjarbek";
            em.Surname = "berdikulov";
            em.Email = "alisher@gmail.com";
            em.Login = "ali";
            em.Password = "alisher1980";
            em.Role = Enums.Role.Admin;

            employee.CreateEmployee(em);

            //employee.UpdateEmployee(6, em);
            //employee.EmployeeDeepDelete(8);
        }
    }
}