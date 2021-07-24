using CQRSExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Commands.Handle
{
    public class HandleCommand:IHandleCoomand
    {
        IEmployeeCommandsRepository _repository;
        public HandleCommand(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }
        public void Handle(EmployeeCommands command)
        {
            Employee employee = new Employee()
            {
                Id = command.Id,
                FirstName = command.FirstName,
                LastName = command.LastName,
                DateOfBirth = command.DateOfBirth,
                Street = command.Street,
                City = command.City,
                PostalCode = command.PostalCode
            };
            _repository.SaveEmployee(employee);
        }
    }
}
