using System;
using System.Collections.Generic;
using System.Text;

namespace PlayShops
{
    public class Play : IDisposable
    {
        public string Title
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public string Genre
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }

        private bool disposed = false;

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"П'єса: \"{Title}\" | Автор: {Author} | Жанр: {Genre} | Рік: {Year}");
        }

        
        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"[Dispose] Ресурси п'єси \"{Title}\" звільнено .");
                disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        ~Play()
        {
            Console.WriteLine($"[Деструктор] Об'єкт п'єси \"{Title}\" видалено з пам'яті.");
        }
    }
}
