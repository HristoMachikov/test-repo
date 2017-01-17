using System;

namespace _04.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var Numbers = int.Parse(Console.ReadLine());

            var DivisionByTwo = 0.0;
            var DivisionByThree = 0.0;
            var DivisionByFour = 0.0;

            for (int rows = 0; rows < Numbers; rows++)
            {
                var curentNum = int.Parse(Console.ReadLine());
                if (curentNum % 2 == 0)
                {
                    DivisionByTwo++;
                }
                if (curentNum % 3 == 0)
                {
                    DivisionByThree++;
                }
                if (curentNum % 4 == 0)
                {
                    DivisionByFour++;
                }
            }
            var PercentDiffByTwo = DivisionByTwo/Numbers *100 ;
            var PercentDiffByThree = DivisionByThree/Numbers *100 ;
            var PercentDiffByFour = DivisionByFour / Numbers * 100;

            Console.WriteLine("{0:f2}%", PercentDiffByTwo);
            Console.WriteLine("{0:f2}%", PercentDiffByThree);
            Console.WriteLine("{0:f2}%", PercentDiffByFour);

        }
    }
}
