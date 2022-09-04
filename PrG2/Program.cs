// See https://aka.ms/new-console-template for more information

Console.WriteLine("введите трехзначное число");
int a = int.Parse(Console.ReadLine());

if (a < 100 && a >= 10)
{
     Console.WriteLine("нет третьей цифры");
}
else 
{
    if ( a > 1000)
    {
     Console.WriteLine("введите трехзначное число");
    }
    else 
    {
        if (a < 10)
        {
            Console.WriteLine("Введите трехзначное число");
        }
        else 
        {
            int a3 = a % 10;
            Console.WriteLine($"третья цифра - {a3}");
        }
    }
}
        

  