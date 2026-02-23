namespace FirstApp
{

    public class Logic
    {
        public static int Compare(int num)
        {
            int x = num / 100;
            int y = (num - x * 100) / 10;
            int z = (num - x * 100 - y * 10);
            
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > z && y > x)
            {
                return y;
            }
            else
            {
                return z;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трех значное число");
            var num = int.Parse(Console.ReadLine());

            int answer = Logic.Compare(num);

            Console.WriteLine(answer);
            
        }
    }
}