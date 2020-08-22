using System;

namespace HomeworkWithoutMet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                try
                {
                    string number1 = "первого";
                    string number2 = "второго";
                    string Name1 = AskNames(number1);
                    string Name2 = AskNames(number2);
                    int age1 = AskAge(number1);
                    int age2 = AskAge(number2);
                    Console.WriteLine("Введите имя старшего.");
                    string Name3 = Console.ReadLine();
                    string res = CompareAge(age1, age2, Name1, Name2, Name3);
                    Console.WriteLine(res);
                    if (res == "Введено неверное имя!")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введено неверное значение.");
                    continue;
                }
            }
            while (i > 0);
            Console.ReadKey();

        }
        static string AskNames(string number)
        {
            Console.WriteLine($"Введите имя {number} человека.");
            string name = Console.ReadLine();
            return name;
        }
        static int AskAge(string number)
        {
            Console.WriteLine($"Введите возраст {number} человека.");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        static string CompareAge(int age1, int age2, string Name1, string Name2, string Name3)
        {
            if (age1 > age2)
            {
                if (Name3 == Name1)
                {
                    return $"Все верно! : {Name1} старше {Name2} на {age1 - age2} лет (год).";
                }
                if (Name3 == Name2)
                {
                    return $"Не верно! : {Name1} старше {Name2} на {age1 - age2} лет (год) .";
                }
                if (Name3 != Name1 && Name3 != Name2)
                {
                    return "Введено неверное имя!";
                }
            }
            if (age2 > age1)
            {
                if (Name3 == Name2)
                {
                    return $"Все верно! : {Name2} старше {Name1} на {age2 - age1} лет (год).";
                }
                if (Name3 == Name1)
                {
                    return $"Не верно! : {Name2} старше {Name1} на {age2 - age1} лет (год).";
                }
                if (Name3 != Name1 && Name3 != Name2)
                {
                    return "Введено неверное имя!";
                }
            }
            return "Введены неверные данные!";
        }
    }
}
