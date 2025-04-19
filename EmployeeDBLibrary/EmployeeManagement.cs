using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDBLibrary;

public class EmployeeManagement
{
    private readonly EmployeeContext _dbContext;
    public EmployeeManagement(EmployeeContext employeeContext)
    {
        _dbContext = employeeContext;
    }

    public async Task<List<Employee>> GetAll()
    {
        return await _dbContext.Employees.AsNoTracking().OrderBy(x => x.EmployeeID).ToListAsync();
    }

    public async Task<Employee> GetById(int id)
    {
        return await _dbContext.Employees.SingleOrDefaultAsync(x => x.EmployeeID == id);
    }

    public async Task<int> Add(Employee employee)
    {
        try
        {
            await _dbContext.Employees.AddAsync(employee);
            _dbContext.SaveChangesAsync();
            return employee.EmployeeID;
        }
        catch
        {
            return -1;
        }
    }

    public async Task<int> Update(
        int id,
        string? firstName = null,
        string? lastName = null,
        string? email = null,
        DateTime? dateOfBirth = null,
        decimal? salary = null)
    {
        var query = _dbContext.Employees.Where(x => x.EmployeeID == id);

        if (!query.Any())
        {
            return -1;
        }

        try
        {
            await query.ExecuteUpdateAsync(s => s
                .SetProperty(x => x.FirstName, x => firstName ?? x.FirstName)
                .SetProperty(x => x.LastName, x => lastName ?? x.LastName)
                .SetProperty(x => x.Email, x => email ?? x.Email)
                .SetProperty(x => x.DateOfBirth, x => dateOfBirth ?? x.DateOfBirth)
                .SetProperty(x => x.Salary, x => salary ?? x.Salary));
        }
        catch
        {
            return -1;
        }

        return id;
    }

    public async Task<int> Delete(int id)
    {
        var query = _dbContext.Employees.Where(x => x.EmployeeID == id);

        if (!query.Any())
        {
            return -1;
        }

        try
        {
            await query.ExecuteDeleteAsync();
        }
        catch
        {
            return -1;
        }
        return id;
    }
}
