using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {

        static void OrderPizzaSET_Piccoli(int account, string customer, params string[] pizzas)
        {
            if (pizzas.Length != 3) {
                throw new ArgumentOutOfRangeException("The count of pizzas is not 3");
                return;
            }
            Invoice invoice = new Invoice(account, customer, "Piccoli");
            float priceWithShareWithoutVAT = 0;
            float priceWithShareWithVAT = 0;
            for (int i = 0; i < 3; i++)
            {
                invoice.Add(pizzas[i], 1);
                if (i+1 == 2) {
                    priceWithShareWithoutVAT = invoice.GetPrice(false);
                    priceWithShareWithVAT = invoice.GetPrice(true);
                }
         
            }
            float priceWithoutShareWithoutVAT = invoice.GetPrice(false);
            float priceWithoutShareWithVAT = invoice.GetPrice(true);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Набор из 3 пицц, ТРЕТЬЯ ПИЦЦА В ПОДАРОК // ЦЕНЫ: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Цена без акции, без ПДВ - {priceWithoutShareWithoutVAT}");
            Console.WriteLine($"Цена без акции, c ПДВ - {priceWithoutShareWithVAT}");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Цена c акцией, без ПДВ - {priceWithShareWithoutVAT}");
            Console.WriteLine($"Цена c акцией, c ПДВ - {priceWithShareWithVAT}");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            double side1 = 3453.45, side2 = 645.5;
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Прямокутник зі сторонами {side1} та {side2}: ");
            Console.WriteLine($"Площа - {rectangle.CalculateArea()}");
            Console.WriteLine($"Периметр - {rectangle.CalculatePerimeter()}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[---------------------------------------]");
            Console.ResetColor();

            Book book = new Book("Дорога без возврата", "Сапковский Анджей", "'Дорога без возврата' – сборник малой прозы от Анджея Сапковского. В нем мы снова перенесемся в мир Геральта и Йеннифер, Лютика и Цири.Узнаем неожиданные подробности о приключениях Алисы в Стране чудес и по - новому взглянем на историю о бременских музыкантах.Страницы 'Бестиария' познакомят нас с монстрами и волшебными существами – как знакомых Геральту, так и тех, с кем ему встретиться не довелось.А блистательное эссе 'Вареник, или Нет золота в Серых горах' преподнесет несколько уроков начинающим писателям, увлеченным жанром фэнтези.");
            book.title.Show();
            book.author.Show();
            book.content.Show();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[---------------------------------------]");
            Console.ResetColor();

            Figure figure = new Figure(new Point[] { new Point(0, 10), new Point(15, 5), new Point(0,0) });
            Console.WriteLine($"Назва фігури: {figure.Name}");
            Console.WriteLine($"Периметр: {figure.CalculatePerimeter()}");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[---------------------------------------]");
            Console.ResetColor();


            Database.InitializeDatabase();
            OrderPizzaSET_Piccoli(23523, "Alex Brown", new string[] { "PICCOLI", "PICCOLI", "MARGARITA" });

            Console.ReadKey();
        }
    }
}
