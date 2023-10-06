using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = " Bu bir string örneğidir.  ";
            string y = " String değeri. ";
            string z = "String";
            string s = "Bu ,bir ,string ,örneğidir.";


            Console.WriteLine(x);
            Console.WriteLine(x.Length);  // lenght string değişkeninin uzunluğunu belirtir.

            string concat = string.Concat(x, y);  // concat string değişkenlerini birleştirir.
            Console.WriteLine(concat);

            string büyük = x.ToUpper(); //ToUpper string değişkeninin tüm karakterlerini büyük harf yapar.
            Console.WriteLine(büyük);

            string küçük = y.ToLower(); //ToUpper string değişkeninin tüm karakterlerini küçük harf yapar.
            Console.WriteLine(küçük);

            string subString = x.Substring(2,4);  //Substring string değerinin istediğimiz bir bölümünü alması.
            Console.WriteLine(subString);

            int bulma = x.IndexOf(z);  // IndexOf değişkenlerin içerisinde arama yapmaya yardımcı olur ve ındexof bir int değerdir. 
            Console.WriteLine(bulma);

            int bulmak = x.IndexOf(z, StringComparison.InvariantCultureIgnoreCase);  // IndexOf değişkenlerin içerisinde arama yapmaya yardımcı olur. aynı keime var fakat büyük harften dolayı kabul etmiyorsa bu şekide yazarız. 
            Console.WriteLine(bulmak);

            int last = x.LastIndexOf("r", StringComparison.InvariantCultureIgnoreCase);  //LastIndexOf değişkenin içerisinde belirlediğimiz harfin en son kaçıncı karakter olduğunu söyler. 
            Console.WriteLine(last);      // StringComparison.InvariantCultureIgnoreCase  ise bize büyük küçük harfleri göz ardı ederek hepsini kabul et der.

            bool booll = y.Contains(z); // bool bize tru, false çıktısı verir.
            Console.WriteLine(booll);   // Contains ise değişkenimizin içindeki string değerinim olup olmadığına bakar.

            //startwish
            if (x.StartsWith(z))  //startwish değişkenin başında aradığımız kelimenin olup olmadığına bakar.
            {
                Console.WriteLine("Değerin başında " + z + " bulundu.");
            }
            else
            {
                Console.WriteLine("Değerin sonunda " + z + " bulunamadı.");
            }

            //endswish
            if (x.EndsWith(z))  //endswish değişkenin sonunda aradığımız kelimenin olup olmadığına bakar.
            {
                Console.WriteLine("Değerin başında " + z + " bulundu.");
            }
            else
            {
                Console.WriteLine("Değerin sonunda " + z + " bulunamadı.");
            }

            string değişiklik = x.Replace(".", string.Empty).Replace(" ", ".").Replace("ü", "u");  // Replace değerdeki belirli tüm karakterleri değiştirmek.
            Console.WriteLine(değişiklik);

            string[] split = s.Split(','); // istediğimiz değişkenden sonra değerimizi listelemeye yardımcı olur.
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }

            string trims = x.TrimStart(); // değerin başındaki boşlukları siler.
            string trim = y.Trim(); //   değerin hem başındaki hem de sonundaki boşlukları siler.
            string trime = x.TrimEnd(); //   değerin sonundaki boşlukları siler.
            Console.WriteLine(trims);
            Console.WriteLine(trim);
            Console.WriteLine(trime);

            string[] stringDizi = { "Ben", "bir", "öğrenciyim" }; // string dizideki değerler arasına başka bir sabit değer ekler.
            string.Join(",",stringDizi);
            foreach (string itemm in stringDizi)
            {
                Console.WriteLine(itemm);
            }


            Console.WriteLine("C : " + String.Format("{0:C}", 10.50)); // C : Değeri bilgisayarda seçili olan para formatında görüntülemek için kullanılır.
            Console.WriteLine("D : " + String.Format("{0:D3}", 15)); // D : Değeri decimal olarak görüntülemek için kullanılır.
            Console.WriteLine("D : " + String.Format("{0:D5}", 15)); 
            Console.WriteLine("E : " + String.Format("{0:E}", 15000)); // E: Değeri bilimsel (scientific) formatta görüntülemek için kullanılır.
            Console.WriteLine("F : " + String.Format("{0:F1}", 15.5)); // F:Değeri ondalık olarak görüntülemek için kullanılır.
            Console.WriteLine("F : " + String.Format("{0:F2}", 15.5)); 
            Console.WriteLine("F : " + String.Format("{0:F3}", 15.5));
            Console.WriteLine("N : " + String.Format("{0:N}", 1500000)); // N : Değeri parasal görünümde (0.000.000,00 vb) görüntülemek için kullanılır.
            Console.WriteLine("X : " + String.Format("{0:X}", 450)); // X : Değeri hexadecimal olarak görüntülemek için kullanılır.
            Console.WriteLine("0 : " + String.Format("{0:000000.00}", 15.5)); // 0 : Değeri sıfır sayısı kadar karakterde görüntülemek için kullanılır. Değerin basamak sayısı formattan az ise kalan basamakları 0 olarak görüntüler.


            Console.ReadLine();

        }
    }
}
