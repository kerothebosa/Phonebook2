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

       /*
        * Deneme
        * 
        * 
        * private void DisplayAlpha(Contact alpha)
        {

            Console.WriteLine($"Bulunan kayıt: İsim:{alpha.Name}, Soyisim:{alpha.Surname}, Numara:{alpha.Number}");
        }
        private void DisplayAlpha(List<Contact> contacts)
        {
            contacts = contacts.OrderBy(x => x.Name).ToList();

            foreach (var alpha in contacts)
            {
                DisplayAlpha(alpha);

            }


        }
    */
        public void AlphaName()
        {

            var contact= _contacts.OrderBy(x => x.Name).ToList();
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

        public void Already(string name, string surname)
        {
            var already = _contacts.Any(x => x.Name == name && x.Surname == surname);
            
            if(already== true) 
            { 
                Console.WriteLine("Aynı İsim ve Soyisimli bir kayıt var.");
                Console.WriteLine("Kayıdın üzerine yeni numara yazmak için 1 yazınız");
                Console.WriteLine("Ana menüye dönmek için 2 yazınız ");
                var UserInput4 = Console.ReadLine();
                if (UserInput4 == "1")
                {
                    
                }
               
            }
            else
            {
                
            }
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


        

    }
}
