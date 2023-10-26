﻿using AdoNetProject.Dtos;
using AdoNetProject.Models;

namespace AdoNetProject.Interfaces
{
    public interface IEmployeeRepository
    {
        void CreateEmployee(EmployeeDTO employee);
        void UpdateEmployee(EmployeeDTO employee);
        void DeleteEmployee(int EmployeeId);
        void EmployeeDeepDelete(int EmployeeId);
        void GetAllEmployees();
        void GetEmployeeById(int EmployeeId);
    }
}