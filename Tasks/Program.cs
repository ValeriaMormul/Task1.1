using System;

class Program
{
    static void Main()
    {
        // Виводить числа з консолі
        Console.Write("12"); //Надала random значення "12"
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("56"); //Надала рандомне значення "56"
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Перевіряє чи є числа днем та місяцем
        bool isValidDate = IsValidDate(number1, number2);

        // Виведе необхідний результат
        if (isValidDate)
        {
            Console.WriteLine("Ці числа можуть бути днем та місяцем.");
        }
        else
        {
            Console.WriteLine("Ці числа не можуть бути днем та місяцем.");
            Console.ReadKey();
        }
    }
    static bool IsValidDate(int day, int month)
    {
        return (day >= 1 && day <= 31) && (month >= 1 && month <= 12);
    }
}