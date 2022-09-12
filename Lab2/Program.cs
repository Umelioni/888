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
            address.Index = 28009;
            address.Country = "Spain";
            address.City = "Madrid";
            address.Street = "Goya";
            address.House = "3A";
            address.Apartment = 5;
            address.Print();

            Console.WriteLine("==== 2th ====");
            Converter converter = new Converter(36.92, 36.94, 0.61);
            Console.WriteLine($"23 USD to UAH: " + converter.Convert(Converter.Сurrency.USD, Converter.Сurrency.UAH, 23));
            Console.WriteLine($"3457.54 UAH to EUR: " + converter.Convert(Converter.Сurrency.UAH, Converter.Сurrency.EUR, 3457.54));

            Console.WriteLine("==== 3th ====");
            Employee tom = new Employee("Tom", "Brown");
            tom.Experience = 3;
            tom.Position = Employee.PositionType.Middle;
            tom.Print();

            Console.WriteLine("==== 4th ====");
            User user = new User("bob", "Tom", "Brown", 24);
            user.PrintInfo();

        }
    }
    class Address
    {
        private int _index, _apartment;
        private string _country, _city, _street, _house;

        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value > 0)
                    _index = value;
                else throw new ArgumentException("Value < or == 0");
            }
        }
        public int Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                _apartment = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        public string House
        {
            get
            {
                return _house;
            }
            set
            {
                _house = value;
            }
        }

        public void Print() => Console.WriteLine($"{_index} {_country}, {_city}, Cl. {_street} {_house}, {_apartment}");
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
        const float startSalary = 10354.45f;

        private string _name;
        private string _surname;
        private int _experience = 0;
        private PositionType _position = PositionType.Null;
        private float _salary = startSalary;
        private bool w_UpdateSalary = true;
        public enum PositionType
        {
            Null,
            Junior,
            Middle,
            Senior
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public PositionType Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
                if (w_UpdateSalary)
                UpdateSalary();
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value > 0)
                    _experience = value;
                else throw new ArgumentException("Experience < or == 0");
                if (w_UpdateSalary)
                    UpdateSalary();
            }
        }
        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
                w_UpdateSalary = false;
            }
        }

        void UpdateSalary()
        {
            this._salary = startSalary * (float)_position * (1.0f + (float)_experience / 10.0f);
        }
        public Employee(string name, string surname)    
        {
            this._name = name;
            this._surname = surname;
        }

        public void Print()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Position: " + Enum.GetName(typeof(PositionType), _position));
            Console.WriteLine("Experience: " + _experience);
            Console.WriteLine("Salary: " + _salary);
            Console.WriteLine("=======================");
        }
    }
    class User
    {
        public string login, name, surname;
        public int age;
        DateTime creationDate;

        public DateTime CreationDate {
            get => creationDate;
        }

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.creationDate = DateTime.Now;
        }

        public void PrintInfo() {
            Console.WriteLine("=======================");
            Console.WriteLine("Login: " + login);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Creation Date: " + creationDate.ToString());
            Console.WriteLine("=======================");
        }
    }
}
