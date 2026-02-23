namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трех значное число");
            var num = int.Parse(Console.ReadLine());

            int x = num / 100;
            int y = (num - x * 100) / 10;
            int z = (num - x * 100 - y * 10);

            int answer;

            if (x > y && x > z)
            {
                answer = x;
            }
            else if (y > z && y > x)
            {
                answer = y;
            }
            else
            {
                answer = z;
            }

            Console.WriteLine(answer);
            
        }
    }
}