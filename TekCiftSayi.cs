using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14_IfElseYapisi
{
    class TekCiftSayi
    {
        static void Main(string[] args)
        {
        //if yapısı eğer anlamaına gelir koşul sağlar, evetse şunu yap, hayırsa şunu gibi örneklendirilebilir.
            
        Console.WriteLine("Bir sayi giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine()); 
        //Bir sayının belirtilen dize temsilini eşdeğer
        //bir 32 bit işaretli tamsayıya dönüştürür. Belirtilen 16 bit işaretsiz tamsayının değerini,
        //eşdeğer 32 bitlik işaretli tamsayıya dönüştürür. Belirtilen 32 bitlik işaretsiz tamsayının 
        //değerini, eşdeğer bir 32 bit işaretli tamsayıya dönüştürür.
        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayidir.");
        }
        //if (sayi % 2 == 1)
        //{
        //    Console.WriteLine($"{sayi} tek bir sayidir.");
        //}
        //if neden kulanılmıyor araştır videoda else kullanıyor
        
        else
        {
            Console.WriteLine($"{sayi} tek bir sayidir.");
        }
            Console.ReadKey();
        }
    }
}
