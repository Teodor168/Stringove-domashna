using System.Buffers.Text;

namespace Preobrazuvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int baseNumber = int.Parse(Console.ReadLine()); 
            int num = int.Parse(Console.ReadLine());

            //Action
            string result = "";
            while (num > 0)
            {
                int remainder = num % baseNumber;
                result = remainder.ToString() + result;
                num /= baseNumber;
            }

            //Print
            Console.WriteLine(result);
        }
    }
}