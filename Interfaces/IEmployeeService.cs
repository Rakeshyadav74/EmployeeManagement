using EmployeeManagement.DTOs;
using EmployeeManagement.Models;

namespace EmployeeManagement.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponseDto>> GetAllAsync();

        Task<EmployeeResponseDto?> GetByIdAsync(int id);

        Task<EmployeeResponseDto> CreateAsync(CreateEmployeeDto dto);

        Task<bool> UpdateAsync(int id, UpdateEmployeeDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
