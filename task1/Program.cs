Console.WriteLine("Введите трех значное число");
var num = int.Parse(Console.ReadLine());

int x = num / 100;
int y = (num - x * 100) / 10;
int z = (num - x * 100 - y * 10);
