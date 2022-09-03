// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (a > 0 && a < 8) {
    Console.WriteLine(weekDays[a-1]);
    if ( a - 1 ==7 || a - 1 ==6)
    {
        Console.WriteLine("Это выходной");
    }
}
else {
    Console.WriteLine("Не путай меня");
}

