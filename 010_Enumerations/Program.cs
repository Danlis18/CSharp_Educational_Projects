//Перечислення (перелічення) - це набір іменнованих констант

/*Console.Write("Day number: ");
int day = Convert.ToInt32(Console.ReadLine());

DayOfWeek dayOfWeek = (DayOfWeek)day;

switch (dayOfWeek)
{
    case 0:
        break;
    case DayOfWeek.Monday:
        Console.WriteLine("Понеділок");
        break;
    case DayOfWeek.Tuesday:
        Console.WriteLine("Вівторок");
        break;
    case DayOfWeek.Wednesday:
        Console.WriteLine("Середа");
        break;
}*/


using _010_Enumerations;

double res = Product.CalculatTotalPrice(700, Discount.vip);
Console.WriteLine(res);
