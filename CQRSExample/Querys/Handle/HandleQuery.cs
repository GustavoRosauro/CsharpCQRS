using CQRSExample.DTOs;
using CQRSExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Querys.Handle
{
    public class HandleQuery:IHandleQuery
    {
        private readonly IEmployeeQueriesRepository _repository;
        public HandleQuery(IEmployeeQueriesRepository repository)
        {
            _repository = repository;
        }
        public EmployeeDTO Handle(EmployeeQueries employee)
        {
            var emp = _repository.GetById(employee.EmployeeId);
            return new EmployeeDTO
            {
                Id = emp.Id,
                FullName = emp.FirstName + " " + emp.LastName,
                Adress = $"{emp.Street} ${emp.City} {emp.PostalCode}",
                Age = Convert.ToInt32(Math.Abs((DateTime.Now - emp.DateOfBirth).TotalDays / 365))
            };
        }
    }
}
