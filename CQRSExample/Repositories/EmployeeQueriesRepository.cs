using CQRSExample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        private readonly ISqlDatabase _database;
        public EmployeeQueriesRepository(ISqlDatabase database)
        {
            _database = database;
        }
        public Employee GetById(int employeeId)
        {            
            var filter = new { employeeId = employeeId };
            var fields = typeof(Employee).GetProperties();
            string campos = string.Join(",", fields.Select(x => x.Name));
            string sql = $"SELECT {campos} FROM {nameof(Employee)} WHERE ID = @{nameof(employeeId)}";
            var lista = _database.Querys(sql,filter);
            var employee = lista.First();
            return new Employee()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                City = employee.City,
                DateOfBirth = employee.DateOfBirth,
                PostalCode = employee.PostalCode,
                Street = employee.Street
            };
        }        
    }
}
