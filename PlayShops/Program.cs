using System.Text;

namespace PlayShops
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("П'ЄСА");
            using (Play play1 = new Play("Наталка Полтавка", "Іван Котляревський", "Соціально-побутова драма", 1819))
            {
                play1.ShowInfo();
            }
            TestPlayDestructor();

            Console.WriteLine("МАГАЗИН");
            Shop shop1 = new Shop("Сільпо", "вул. Дерибасівська, 10", "продовольчий");
            shop1.ShowInfo();
            shop1.Dispose();
            TestShopDestructor();
            Console.WriteLine("(GC)");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\nПрограма завершила роботу.");
        }

        static void TestPlayDestructor()
        {
            Play play2 = new Play("Лісова пісня", "Леся Українка", "Драма-феєрія", 1911);
            play2.ShowInfo();
        }

        static void TestShopDestructor()
        {
            Shop shop2 = new Shop("Інтертоп", "пр. Шевченка, 5", "взуття");
            shop2.ShowInfo();
        }
    }
}
