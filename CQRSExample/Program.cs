using CQRSExample.Commands;
using CQRSExample.DependencyInjection;
using CQRSExample.Repositories;
using System;

namespace CQRSExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Initialize.Injection();
            command.Handle(new EmployeeCommands()
            {
                Id = 200,
                FirstName = "jerry",
                LastName = "TOM",
                Street = "Rua XV",
                City = "Blumenau",
                PostalCode = "23489023",
                DateOfBirth = new DateTime(1992,02,23)
            });
            Console.WriteLine("Command was been stored");
            var query = Initialize.InjectionQuerys();
            var emp = query.Handle(new EmployeeQueries() {EmployeeId = 100 });
            Console.WriteLine($"Employee ID:{emp.Id}, Name:{emp.FullName}, Address:{emp.Adress}, Age:{emp.Age}");
            Console.ReadKey();
        }
    }
}
