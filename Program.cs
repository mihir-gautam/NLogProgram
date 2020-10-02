using System;

namespace NLogProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition problem, enter two numbers to add");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            AddNumbers add = new AddNumbers();
            Console.WriteLine("Result is : " + add.Sum(FirstNum,SecondNum));
        }
    }
}
