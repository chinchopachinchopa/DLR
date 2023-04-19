using System;
using System.Dynamic;
class Oborudovanie
{
    public static void Main()
    {
        dynamic equipment = new ExpandoObject();
        Console.Write("Введите название оборудования: ");
        string? name = Console.ReadLine();
        equipment.Name = name;

        Console.Write("Введите стоимость оборудования(в рублях): ");
        double cost = Convert.ToDouble(Console.ReadLine());
        equipment.Cost = cost;

        Console.Write("Введите дату постановки на баланс (в формате дд.мм.гггг): ");
        string? dateStr = Console.ReadLine();

        DateTime date;

        if (DateTime.TryParse(dateStr, out date))
        {
            equipment.Date = date;
        }
        else
        {
            equipment.Date = DateTime.Today;
        }

        Console.WriteLine("Название: " + equipment.Name);
        Console.WriteLine("Стоимость: " + equipment.Cost);
        Console.WriteLine("Дата постановки на баланс: " + equipment.Date.ToString("dd.MM.yyyy"));
    }
    public static void Main1()
    {
        dynamic nazvanie = new ExpandoObject();
        Console.WriteLine("Введите название темы:");
        string? name = Console.ReadLine();
        nazvanie.Name = name;
        Console.WriteLine($"Название темы:{nazvanie.Name}");
    }
}