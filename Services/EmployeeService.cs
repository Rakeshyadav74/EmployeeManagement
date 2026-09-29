using EmployeeManagement.DTOs;
using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EmployeeResponseDto>> GetAllAsync()
        {
            var employees = await _repository.GetAllAsync();

            return employees.Select(e => new EmployeeResponseDto
            {
                Id = e.Id,
                Name = e.Name,
                Department = e.Department,
                Salary = e.Salary,
                Email = e.Email
            }).ToList();
        }

        public async Task<EmployeeResponseDto?> GetByIdAsync(int id)
        {
            var employee = await _repository.GetByIdAsync(id);

            if (employee == null)
                return null;

            return new EmployeeResponseDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                Salary = employee.Salary,
                Email = employee.Email
            };
        }

        public async Task<EmployeeResponseDto> CreateAsync(CreateEmployeeDto dto)
        {
            var employee = new Employee
            {
                Name = dto.Name,
                Department = dto.Department,
                Salary = dto.Salary,
                Email = dto.Email
            };

            var createdEmployee = await _repository.AddAsync(employee);

            return new EmployeeResponseDto
            {
                Id = createdEmployee.Id,
                Name = createdEmployee.Name,
                Department = createdEmployee.Department,
                Salary = createdEmployee.Salary,
                Email = createdEmployee.Email
            };
        }

        public async Task<bool> UpdateAsync(int id, UpdateEmployeeDto dto)
        {
            var existingEmployee = await _repository.GetByIdAsync(id);

            if (existingEmployee == null)
                return false;

            existingEmployee.Name = dto.Name;
            existingEmployee.Department = dto.Department;
            existingEmployee.Salary = dto.Salary;
            existingEmployee.Email = dto.Email;

            await _repository.UpdateAsync(existingEmployee);

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var employee = await _repository.GetByIdAsync(id);

            if (employee == null)
                return false;

            await _repository.DeleteAsync(employee);

            return true;
        }
    }
}