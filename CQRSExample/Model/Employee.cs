using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string PostalCode { get; private set; }
        public Employee(string firstName, string lastName, DateTime dateOfBirth, 
                        string street, string city, string postalCode)
        {
            StringValidator(firstName,nameof(this.FirstName));
            StringValidator(lastName,nameof(this.LastName));
            StringValidator(street, nameof(this.Street));
            StringValidator(city,nameof(this.City));
            StringValidator(postalCode,nameof(this.PostalCode));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Street = street;
            this.City = city;
            this.PostalCode = postalCode;
        }
        private void StringValidator(string campo, string fieldName)
        {
            bool validar = !string.IsNullOrEmpty(campo);
            if (!validar)
                throw new Exception($"O campo {fieldName} não pode ser nulo ou vazio");
        }
    }
}
