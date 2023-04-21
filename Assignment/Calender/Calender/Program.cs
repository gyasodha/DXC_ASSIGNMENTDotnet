using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter the day of the week for the first date of the month (1-7): ");
        int dayOfWeek = int.Parse(Console.ReadLine());
        Console.WriteLine("Mo Tu We Th Fr Sa Su");
        int daysInMonth = DateTime.DaysInMonth(year, month);
        for (int i = 1; i < dayOfWeek; i++)
        {
            Console.Write("   ");
        }
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write("{0,2} ", day);
            if ((dayOfWeek + day - 1) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        if ((dayOfWeek + daysInMonth - 1) % 7 != 0)
        {
            Console.WriteLine();
        }
    }
}