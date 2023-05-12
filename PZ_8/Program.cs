using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван Иванов", "123-45-67", "ул. Пушкина, д. 10");
            School school = new School("Школа №1", "234-56-78", "ул. Лермонтова, д. 5", "Петров П.П.");

            // создаем телефонную книгу и добавляем в нее контакты
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddContact(person);
            phoneBook.AddContact(school);

            // отображаем все контакты в телефонной книге
            phoneBook.DisplayContacts();
            Console.ReadLine();
        }
    }
}
