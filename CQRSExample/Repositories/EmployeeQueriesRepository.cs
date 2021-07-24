using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetById(int employeeId)
        {
            return new Employee()
            {
                Id = 100,
                FirstName = "Gustavo",
                LastName = "Rosauro",
                DateOfBirth = new DateTime(1992, 2, 23),
                Street = "Rua da Conceição",
                City = "Blumenau",
                PostalCode = "2423432"
            };
        }        
    }
}
