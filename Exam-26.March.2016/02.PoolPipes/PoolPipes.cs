using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var PoolVal = double.Parse(Console.ReadLine());
            var FirstPipeOutput = double.Parse(Console.ReadLine());
            var SecondPipeOutPut = double.Parse(Console.ReadLine());
            var WorkerOutHours = double.Parse(Console.ReadLine());

            var PoolIsFull = (FirstPipeOutput + SecondPipeOutPut)
                           * WorkerOutHours;

            if (PoolIsFull > PoolVal)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                   WorkerOutHours, PoolIsFull - PoolVal);
            }
            else
            {
                var PercentPoolIsFull = Math.Floor((PoolIsFull / PoolVal) * 100);
                var PercentFirstPipe =Math.Floor(FirstPipeOutput / 
                    (FirstPipeOutput + SecondPipeOutPut) * 100);
                var PercentSecondPipe = Math.Floor(SecondPipeOutPut /
                    (FirstPipeOutput + SecondPipeOutPut) * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    PercentPoolIsFull, PercentFirstPipe, PercentSecondPipe);
            }
        }
    }
}
