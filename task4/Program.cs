using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Parameter olaraq integer array variable-ı(reference) və bir integer value
            //qəbul edən və həmin integer value-nu integer array-ə yəni element kimi əlavə edən metod.


            string input = "Salam menim adim Zakirdir.";
            var wordArr = input.Split(' ');
            bool result = Mtd(input, wordArr);
            Console.WriteLine(result);
            

             static bool Mtd(string input, string[] wordArr)
            {


                int count = 0;
                if (wordArr.Length > 1)
                {
                    for (int i = 0; i < wordArr.Length; i++)
                    {
                        for (int j = 0; j < wordArr[i].Length; j++)
                        {
                            if (char.IsUpper(wordArr[i][j]) == true)
                            {
                                count++;
                                break;
                            }
                        }
                    }
                    if (count > 1)
                        return true;
                }
                return false;
            }
        }
    }
}
