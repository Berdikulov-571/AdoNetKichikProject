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

            EmployeeDTO em = new EmployeeDTO();

            em.Name = "Sanjarbek";
            em.Surname = "Berdikulov";
            em.Email = "bsanjarbek06@gmail.com";
            em.Login = "berdikulov_571";
            em.Password = "sanjarbek2006";
            em.Role = Enums.Role.Admin;

            employee.CreateEmployee(em);
        }
    }
}