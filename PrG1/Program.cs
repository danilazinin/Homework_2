// See https://aka.ms/new-console-template for more information


Console.WriteLine("введите трехзначное число");
int a = int.Parse(Console.ReadLine());

if (a > 1000)
{
    Console.WriteLine("введите трехзначное число");
}
else 
{
    int a1 = a / 10;
    int a2 = a1 % 10;
     Console.WriteLine($"Второе число = {a2}");
}