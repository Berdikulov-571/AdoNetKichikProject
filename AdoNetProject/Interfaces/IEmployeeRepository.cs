using AdoNetProject.Models;

namespace AdoNetProject.Interfaces
{
    public interface IEmployeeRepository
    {
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int EmployeeId);
        void EmployeeDeepDelete(int EmployeeId);
        void GetAllEmployees();
        void GetEmployeeById(int EmployeeId);
    }
}
