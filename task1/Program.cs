using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task1
{

    public class Logic
    {
        public static int CompareDigit(int threeDigitNumber)
        {
            int firstDigit = threeDigitNumber / 100;
            int secondDigit = (threeDigitNumber - firstDigit * 100) / 10;
            int thirdDigit = (threeDigitNumber - firstDigit * 100 - secondDigit * 10);
            
            if (firstDigit > secondDigit && firstDigit > thirdDigit)
            {
                return firstDigit;
            }
            else if (secondDigit > thirdDigit && secondDigit > firstDigit)
            {
                return secondDigit;
            }
            else
            {
                return thirdDigit;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трех значное число");
            var threeDigitNumber = int.Parse(Console.ReadLine());

            int answer = Logic.CompareDigit(threeDigitNumber);

            Console.WriteLine(answer);
            
        }
    }
}