using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge2_InsertShift
{
    class InsertShift
    {
        public static int[] ShiftIn(int[] array, int num)
        {
            int n = array.Length+1;
            int[] Shifted = new int[n];
            //int counter = 0;
            int pos = 5;
            for (int i = 0; i<n; i++)
            {
                if (i < pos)
                {
                    Shifted[i] = array[i];
                }
                else if (i == pos)
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
