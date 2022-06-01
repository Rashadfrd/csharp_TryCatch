using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
   //2.Göndərilmiş string dəyərin aşğıdaki şərtləri ödəyib ödəmədiyini(bool) qaytaran metod
   // -İçində ən az 1 rəqəm olmalıdır
   // -İçində ən az 1 böyük hərf olmalıdır
   //- İçində ən az 1 kiçik hərf olmalıdır

            string input = "Salam, menim adim Akifdir. Men gece 3-de tapsiriq eliyirem";
            bool result = TripleMethod(input);
            Console.WriteLine(result);

            static bool TripleMethod(string input)
            {
                int counter1 = 0;
                int counter2 = 0;
                int counter3 = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLower(input[i]) == true)
                    {
                        counter1++;
                    }
                    else if (char.IsDigit(input[i]) == true)
                    {
                        counter2++;
                    }
                    else if (char.IsUpper(input[i]) == true)
                    {
                        counter3++;
                    }
                }

                if (counter1 > 0 && counter2 > 0 &&counter3 > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
