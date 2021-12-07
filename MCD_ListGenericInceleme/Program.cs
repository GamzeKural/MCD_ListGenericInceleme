using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            //1.yol ama uzun bir yol
            for (int i = 0; i < eklenecekData1.Length; i++)
            {
                sayilarim.Add(eklenecekData1[i]);
            }

            //2.yol
            sayilarim.AddRange(eklenecekData1);


            foreach (var item in sayilarim)
            {
                Console.WriteLine(item);
            }

            sayilarim.TrimExcess(); //count ve capacity değerlerini eşitler.

            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;

           
            Console.WriteLine(capacity);
            Console.WriteLine(count);
            sayilarim.Insert(3, 100);
            sayilarim.ForEach(i => Console.WriteLine(i));
            // =>ilgili koleksiyon şçerşsşnde arama yap.
            // =>linq konusu list<T> içerisinde 

            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> koleksiyonu içinde 3. indexte bulunan değer: {0}",bulunanDeger);

            bool kontrol1 = sayilarim.Any();
            bool kontrol2 = sayilarim.Any(i=>i>5);
            bool kontrol3 = sayilarim.Any(i=>i>138);

            Console.WriteLine(kontrol2);
            Console.WriteLine(kontrol3);

            sayilarim.Sort();
            sayilarim.Reverse();

            int enYuksekDeger = sayilarim.Max();
            int enDusukDeger = sayilarim.Min();
            int toplamDeger = sayilarim.Sum();

            Console.WriteLine(enYuksekDeger);
            Console.WriteLine(enDusukDeger);
            Console.WriteLine(toplamDeger);

            //Uygulama Alanı => Bölüm
            //List<T> Uygulama - Windows Form

            bool silmeIslemiSonuc = sayilarim.Remove(100);
            int silinenAdet = sayilarim.RemoveAll(i => i > 3);
            sayilarim.RemoveAt(2);

            sayilarim.Clear();


            Console.ReadKey();
        }
    }
}
