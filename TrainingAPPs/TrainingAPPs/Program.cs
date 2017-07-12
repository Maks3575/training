using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAPPs
{
    class Program
    {
        static void Main(string[] args)
        {
            //SummBetweenZeros();
            IndexForMinAndMax();
        }
        public static void IndexForMinAndMax()
        {
            int N = Int32.Parse(Console.ReadLine());

            //List<int> mass = new List<int>();

            int[] mass = new int[N];

            mass = (Console.ReadLine().Split(' ').Select(i => Int32.Parse(i))).ToArray();
            int minInd = 0;
            int maxInd = N-1;

            for(int i = 0; i < N; i++)
            {
                if (mass[i] < mass[minInd]) minInd = i;
                if (mass[N - i - 1] > mass[maxInd]) maxInd = N - i;                
            }
            Console.WriteLine($"{minInd + 1} {maxInd + 1}");
            Console.ReadKey();
        }

        public static void SummBetweenZeros()
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] mass = new int[N];

            for (int i = 0; i < N; i++)
            {
                mass[i] = Int32.Parse(Console.ReadLine());
            }

            bool flStart = false;
            bool flEnd = false;
            int summ = 0;
            int j = 1;

            while (!flEnd)
            {
                if (flStart)
                {
                    summ += mass[N - j];
                    if (mass[N - j] == 0) flEnd = true;
                }
                else
                {
                    if (mass[N - j] == 0)
                    {
                        flStart = true;
                    }
                };
                j++;
            }
            Console.WriteLine(summ);
            Console.ReadKey();
        }
    }
}
