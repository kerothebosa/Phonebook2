using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Book
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();


        private void DisplayDetails(Contact contact)
        {

            Console.WriteLine($"Bulunan kayıt: İsim:{contact.Name}, Soyisim:{contact.Surname}, Numara:{contact.Number}");
        }


        private void DisplayDetails(List<Contact> contacts)
        {

            foreach (var contact in contacts)
            {
                DisplayDetails(contact);
            }
        }
     
        public void AlphaName()
        {
            var contact = _contacts.OrderBy(x => x.Name).ToList();
            DisplayDetails(contact);
        }
        public void AlphaSurname()
        {
            var contact = _contacts.OrderBy(x => x.Surname).ToList();
            DisplayDetails(contact);
        }

        public void AlphaNumber()
        {
            var contact = _contacts.OrderBy(x => x.Number).ToList();
            DisplayDetails(contact);
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public bool Already(string name, string surname)
        {
            return _contacts.Any(x => x.Name.ToLower() == name.Trim().ToLower() && x.Surname.ToLower() == surname.Trim().ToLower());
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Kayıt bulunamadı");

            }
            else
            {

                DisplayDetails(contact);
            }

        }



        public void DisplayAll()
        {
            if (_contacts.Count == 0)
            {
                Console.WriteLine("Kayıt bulunamadı");
            }
            else
            {
                DisplayDetails(_contacts);
            }


        }
        public void DisplayMatched(string search)
        {

            var matching = _contacts.Where(c => c.Name.ToLower().Contains(search.ToLower())).ToList();

            if (matching.Count == 0)
            {
                Console.WriteLine("Kayıt bulunamadı");
            }
            else
            {

                DisplayDetails(matching);
            }
        }

        public void DisplayMatchedS(string search)
        {

            var matchingS = _contacts.Where(c => c.Surname.ToLower().Contains(search.ToLower())).ToList();

            if (matchingS.Count == 0)
            {
                Console.WriteLine("Kayıt bulunamadı");
            }
            else
            {

                DisplayDetails(matchingS);
            }
        }

        public void DeleteContact(string name, string surname, string number)
        {

            var personToBeDeleted = _contacts.FirstOrDefault(x => x.Name.ToLower() == name.Trim().ToLower() && x.Surname.ToLower() == surname.Trim().ToLower());

            _contacts.Remove(personToBeDeleted);
            Contact _contact = new Contact(name, surname, number);
            _contacts.Add(_contact);


        }




    }
}
