using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.People
{
    public class Person
    {
        private string _firstName; // Backing fields
        private string _lastName;

        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Name
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                bool isEmpty = string.IsNullOrWhiteSpace(fullName);
                return isEmpty ? "Unnamed" : fullName;
            }
        }

        public void SetFirstName(string name)
        {
            _firstName = name;
        }

        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
