using System;

namespace CodeChallenge2_InsertShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            int[] ray = { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ShiftIn(ray, 100);
        }
        static int[] ShiftIn(int[] array, int num)
        {
            //int i;
            int n = array.Length + 1;
            int[] Shifted = new int[n];
            int pos = 5;
            for (int i = 0; i < n; i++)
            {
                if (i < pos)
                {
                    Shifted[i] = array[i];
                }
                else if (i == pos-1)
                {
                    Shifted[i] = num;
                }
                else
                {
                    Shifted[i] = array[i - 1];
                }
            }
            foreach (int number in Shifted)
            {
                Console.WriteLine(number);
            }
            return Shifted;
        }
    }
}
