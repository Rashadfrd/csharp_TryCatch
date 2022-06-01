using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Verilmiş string deyerinin icərisindəki ilk sözü tapıq qaytaran metod

            string word = "Salam, menim adim Akifdir.";
            FirstWordFinder(ref word);
            Console.WriteLine(word);

            static void FirstWordFinder( ref string word)
            {
                int index = word.IndexOf(' ');
                word = word.Substring(0, index);
            }

        }
    }
}
