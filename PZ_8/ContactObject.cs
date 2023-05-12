using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_8
{
    internal abstract class ContactObject
    {
        public string Name { get; set; } // имя контакта
        public string Phone { get; set; } // телефон контакта

        public ContactObject(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public abstract void DisplayInfo(); // абстрактный метод для отображения информации о контакте
    }

   
}
