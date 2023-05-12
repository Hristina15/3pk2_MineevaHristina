using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_8
{
    internal class PhoneBook
    {
        private List<ContactObject> Contacts; // список контактов

        public PhoneBook()
        {
            Contacts = new List<ContactObject>();
        }

        // метод для добавления контакта в телефонную книгу
        public void AddContact(ContactObject contact)
        {
            Contacts.Add(contact);
        }

        // метод для отображения всех контактов в телефонной книге
        public void DisplayContacts()
        {
            Console.WriteLine("Контакты:");
            foreach (ContactObject contact in Contacts)
            {
                contact.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
