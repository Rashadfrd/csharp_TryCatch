using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
 //           1.Verilmiş string variable-ın dəyərini içərisində hər söz arasında bir boşluq gələcək vəzyətə
 //           salan metod.Misalçün bu metoda dəyəri " salam,      Dunya" olan
 //           string variable göndərsək həmin metod bu variable - ın dəyərini dəyişib "salam, Dunya" vəziyyətinə salmalıdır.
 //           Yəni, göndərilən string-də sözlər arasında birdən çox boşluq ola bilər, onu hər söz
 //           arasında bir boşluq olan vəziyyətə  salan metod yazırsınız.Metod geriyə dəyər qaytarmır!
 //           (Bu tapsiriq bugun kecdyimizi yeni movzu ile elaqeder deyil)


            string input = "        Salam          menim    adim                   Ramildir.";
            CumleDuzelden(ref input);
            Console.WriteLine(input);

            static void CumleDuzelden(ref string input)
            {
                int count = 0;
                string input2 = "";

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ')
                    {
                        input2 += input[i];
                        count = 0;

                    }
                    else
                    {
                        while (count < 1)
                        {
                            count++;
                            input2 += input[i];
                        }
                    }
                }
                input = input2;
            }
            
        }
    }
}
