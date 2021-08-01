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
        public void Handle(EmployeeCreate command)
        {
            Employee employee = new Employee(command.FirstName,command.LastName,command.DateOfBirth,command.Street,command.City,command.PostalCode);            
            _repository.SaveEmployee(employee);
        }
    }
}
