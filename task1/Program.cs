Console.WriteLine("Введите трех значное число");
var num = int.Parse(Console.ReadLine());

int x = num / 100;
int y = (num - x * 100) / 10;
int z = (num - x * 100 - y * 10);

if (x > y && x > z)
{
    Console.WriteLine(x);
}
else if (y > z && y > x)
{
    Console.WriteLine(y);
}
else
{
    Console.WriteLine(z);
}