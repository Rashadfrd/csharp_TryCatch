using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.
            //  Verilmiş string dəyərin içərisində 2 söz olmasını və hər bir sözün böyük hərflə başlamasını yoxlayan metod

            int[] arr = { 1, 2, 3, 4, 55, 6, 7, };
            int num = 2873;
            NumberAdder(ref arr, ref num);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            static void NumberAdder(ref int[]arr, ref int num)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = num;
            }

        }
    }
}
