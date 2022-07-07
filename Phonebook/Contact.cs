using System;
namespace Phonebook
{
    class Contact
    {
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;


        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
    }
}
