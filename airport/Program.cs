using System;

class Program
{
    static void Main(string[] args)
    {
        int daysInDecember = DateTime.DaysInMonth(DateTime.Now.Year, 12);
        DateTime[] decemberDates = new DateTime[daysInDecember];
        int Dateday = 0;


        CreateFillArr(decemberDates);
        VvodArr(decemberDates);
    }
    //Заполнение массива
    static void CreateFillArr(DateTime[] dateTimes)
    {

        Random random = new();
        for (int i = 0; i < 31; i++)
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

    static void PrinimatDate()
    {

    }
}