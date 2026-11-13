using System;
using System.Collections.Generic;
using System.Text;

namespace PlayShops
{

    public class Shop : IDisposable
    {
        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }

        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "продовольчий" || value == "господарський" || value == "одяг" || value == "взуття")
                {
                    type = value;
                }
                else
                {
                    type = "не вказано";
                }
            }
        }

        private bool disposed = false;

        public Shop(string name, string address, string type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Магазин: \"{Name}\" | Адреса: {Address} | Тип: {Type}");
        }
        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"[Dispose] Магазин \"{Name}\" закрито, ресурси звільнено.");
                disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        ~Shop()
        {
            Console.WriteLine($"[Деструктор] Об'єкт магазину \"{Name}\" видалено з пам'яті.");
        }
    }
}
