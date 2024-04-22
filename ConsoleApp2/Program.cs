using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
        //    #region out int console
        //    Console.WriteLine("Введите ваше имя: ");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Введите ваш возраст: ");
        //    int age = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Введите ваш город: ");
        //    string city = Console.ReadLine();

        //    Console.WriteLine("Введите ваш рост: ");
        //    double height = double.Parse(Console.ReadLine());

        //    // Конкатенация 
        //    Console.WriteLine("Ваше имя: " + name);
        //    Console.WriteLine("Ваш возраст: " + age);
        //    Console.WriteLine("Ваш город: " + city);
        //    Console.WriteLine("Ваш рост: " + height);

        //    // Плейсхолдеры (placeholder)
        //    Console.WriteLine("Ваше имя: {0}, ваш возраст: {1}, ваш город: {2}, ваш рост: {3}",name, age, city, height);

        //    // Интерполяция строк
        //    Console.WriteLine($"Ваше имя: {name}, ваш возраст: {age}, ваш город: {city}, ваш рост: {height}");

        //    #endregion

        //    #region MyMethod
        //    Print("Это метод Print");
        //    #endregion

        //    #region MyMethod2
        //    int a = Addition(4, 20);
        //    #endregion

        //    #region object of Client
        //    Client client = new Client();
        //    client.Name = "Maksim";
        //    client.OrderNumber = 51451351;
        //    client.ID = 1;

        //    Console.WriteLine(client);
        //    #endregion

            #region Fraction
            Fraction fraction1 = new Fraction(1,2);
            Fraction fraction2 = new Fraction(2,3);
            Console.WriteLine($"Первая дробь {fraction1}");
            Console.WriteLine($"Вторая дробь {fraction2}");

            fraction1.Multiplication(fraction2);
            #endregion
        }


        public static void Print (string str)
        {
            Console.WriteLine(str);
        }



        public static int Addition (int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
            int sum = firstNum + secondNum;
            return sum;
        }

        
    }

    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Клиент: {Name}, Номер заказа: {OrderNumber}";
        }
    }

    public class Fraction
    {
        // Числитель
        public int Numerator { get; set; }
        // Знаменатель
        public int Denumerator { get; set; }

        public Fraction(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public Fraction()
        {

        }

        public void Multiplication(Fraction fraction) 
        {
            Fraction result = new Fraction();  
            result.Numerator = Numerator * fraction.Numerator;
            result.Denumerator = Denumerator * fraction.Denumerator;
            Console.WriteLine(result);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}";
        }
    }

    
}
