using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;// doğru cevap sayısı
        // birinci soru
        Console.WriteLine("1-> Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a) Lama b)Deve");
        string FirstQuestion = Console.ReadLine().ToLower();

        if (FirstQuestion == "a")
        {
            Console.WriteLine("Doğru cevap");
            count++;
        }
        else if (FirstQuestion == "b")
        {
            Console.WriteLine("Yanlış cevap");
        }

        // 2. soru

        Console.WriteLine("2-> Dünya'ya en yakın gezegen hangisidir?");
        Console.WriteLine("a) Venüs b) Mars");
        string SecondQuestion = Console.ReadLine().ToLower();

        if (SecondQuestion == "a")
        {
            Console.WriteLine("Doğru cevap");
            count++;
        }
        else if (SecondQuestion == "b")
        {
            Console.WriteLine("Yanlış cevap");
        }

        // Eğer ilk iki soruya doğru cevap verilmişse direkt 1 milyon TL kazanılır
        if (count == 2)
        {
            Console.WriteLine("Tebrikler! 1 milyon TL kazandınız!");
        }
        // Eğer ilk iki soruya yanlış cevap verilmişse kazanma şansı kalmamştır.
        else if (count == 0)
        {
            Console.WriteLine("Üzgünüm, kazanmaya yeterli doğru cevabı veremediniz.");
        }
        else
        {
            // 3. soru sadece önceki  sorulardan biri doğruysa sorulacak
            Console.WriteLine("3-> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
            Console.WriteLine("a) 7 b) 12");
            string ThirdQuestion = Console.ReadLine().ToLower();

            if (ThirdQuestion == "a")
            {
                Console.WriteLine("Yanlış cevap");
            }
            else if (ThirdQuestion == "b")
            {
                Console.WriteLine("Doğru cevap");
                count++;
            }

            // Eğer toplamda 2 doğru cevap varsa, burada kazandığı yazdırılır
            if (count == 2)
            {
                Console.WriteLine("Tebrikler! 1 milyon TL kazandınız!");
            }
            else
            {
                Console.WriteLine("Üzgünüm, kazanmaya yeterli doğru cevabı veremediniz.");
            }
        }
    }
}
