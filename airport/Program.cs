using System;

class Program
{
    static void Main(string[] args)
    {
        int daysInDecember = DateTime.DaysInMonth(DateTime.Now.Year, 11);
        DateTime[] decemberDates = new DateTime[daysInDecember];
        int Dateday = 0;
        
        CreateFillArr(decemberDates);
        Console.WriteLine("Привет в Какой день в Ноября хотите политеть в СТАНБУЛ?");
        Dateday = PrinimatDate(Dateday);
        Cravneniya(Dateday, decemberDates);

        DateTime currentDate = DateTime.Now;
        int dayOfMonth = currentDate.Day;

        Console.WriteLine("Текущий день месяца: " + dayOfMonth);
        Console.WriteLine("Ближайший вылет:" + decemberDates[dayOfMonth]);
    }
    //Заполнение массива
    static void CreateFillArr(DateTime[] dateTimes)
    {

        Random random = new();
        for (int i = 0; i < 30; i++)
        {
            int hour = random.Next(24); // Случайный час от 0 до 23
            int minute = random.Next(60); // Случайная минута от 0 до 59 
            int second = random.Next(60); // Случайная секунда от 0 до 59
            dateTimes[i] = new DateTime(DateTime.Now.Year, 12, i + 1, hour, minute, second);
        }
    }
    //Вывод Массива для проверки 
    static void VvodArr(DateTime[] dateTimes)
    {
        foreach (var date in dateTimes)
        {
            Console.WriteLine(date);
        }
    }

    static int PrinimatDate(int num)
    {
        Console.WriteLine("Введите какого число хотите свалить из страны?");

        num += int.Parse(Console.ReadLine());
        return num;
    }

    static void Cravneniya(int num, DateTime[] Datearr)
    {
        num -= 1;
        //DateTime currentDate = DateTime.Now;
        Console.WriteLine($"В Станбул в Этот день вылет {Datearr[num]} и Посодка {Datearr[num].AddHours(6)}"); ;
    }
}