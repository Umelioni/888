using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== 1th ====");
            Address address = new Address();
            address.index = 28009;
            address.country = "Spain";
            address.city = "Madrid";
            address.street = "Goya";
            address.house = "3A";
            address.apartment = 5;
            address.Print();

            Console.WriteLine("==== 2th ====");
            Converter converter = new Converter(36.92, 36.94, 0.61);
            Console.WriteLine($"23 USD to UAH: " + converter.Convert(Converter.Сurrency.USD, Converter.Сurrency.UAH, 23));
            Console.WriteLine($"3457.54 UAH to EUR: " + converter.Convert(Converter.Сurrency.UAH, Converter.Сurrency.EUR, 3457.54));

            Console.WriteLine("==== 3th ====");
            Employee tom = new Employee("Tom", "Brown");
            tom.Print();

            Console.WriteLine("==== 4th ====");
            User user = new User("bob", "Tom", "Brown", 24);
            user.PrintInfo();

        }
    }
    class Address
    {
        public int index, apartment;
        public string country, city, street, house;

        public void Print() => Console.WriteLine($"{index} {country}, {city}, Cl. {street} {house}, {apartment}");
    }
    class Converter
    {
        Dictionary<Сurrency, double> rates = new Dictionary<Сurrency, double>{ { Сurrency.UAH, 1 } };
        public Converter(double usd, double eur, double rub)
        {
            rates[Сurrency.USD] = usd;
            rates[Сurrency.EUR] = eur;
            rates[Сurrency.RUB] = rub;
        }
        public enum Сurrency {
            UAH,
            USD,
            EUR,
            RUB
        }

        public double Convert(Сurrency from, Сurrency to, double val) => (val * rates[from]) / rates[to];

    }

    class Employee
    {

        private string name;
        private string surname;
        private int experience;
        private Position position;
        private float salary = 10354.45f;
        enum Position
        {
            Junior = 1,
            Middle,
            Senior
        }
        public Employee(string name, string surname)    
        {
            this.name = name;
            this.surname = surname;
            Random random = new Random();
            this.position = (Position)random.Next(1, 3);
            this.experience = random.Next((int)position-1, (int)position * 5); 
            this.salary = salary * (float)position * (1.0f + (float)experience / 10.0f);
        }

        public void Print()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Position: " + Enum.GetName(typeof(Position), position));
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("=======================");
        }
    }
    class User
    {
        string login, name, surname;
        int age;
        DateTime date;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = DateTime.Now;
        }
         
        public void PrintInfo() {
            Console.WriteLine("=======================");
            Console.WriteLine("Login: " + login);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Creation Date: " + date.ToString());
            Console.WriteLine("=======================");
        }
    }
}
