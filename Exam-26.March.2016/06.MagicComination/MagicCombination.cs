using System;

namespace _06.MagicComination
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit <= 9; secondDigit++)
                {
                    for (int thirdDigit = 1; thirdDigit <= 9; thirdDigit++)
                    {
                        for (int forthDigit = 1; forthDigit <= 9; forthDigit++)
                        {
                            for (int fifthDigit = 1; fifthDigit <= 9; fifthDigit++)
                            {
                                for (int sixthDigit = 1; sixthDigit <= 9; sixthDigit++)
                                {
                                    if (firstDigit * secondDigit * thirdDigit * forthDigit * fifthDigit * sixthDigit == number)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ",
                                            firstDigit, secondDigit, thirdDigit,
                                            forthDigit, fifthDigit, sixthDigit);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
