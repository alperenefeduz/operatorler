using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmatiksel Operatörler
            // Toplama + 
            // Çıkarma -
            //Çarpma *
            //Bölme /
            //Atama =
            //Özel operatörler
            //+=, -=, *=, /=, ++, --

            // Tanımlanan değişkene veri atmak için kullanılır


            // int sayi1 = 13;
            // int sayi2 = 5;
            // int toplam = sayi1 + sayi2;
            // Console.Write("toplam = ");
            // Console.WriteLine(toplam);

            // Sayi1 den Sayı 2 yi çıkart fark ismindeki değişkene at
            // int fark = sayi1 - sayi2;
            // Console.Write("fark = ");
            // Console.WriteLine(fark);

            // int carpim = sayi1 * sayi2;
            // Console.Write("çaprım = ");
            // Console.WriteLine(carpim);

            // int bolum = sayi1 / sayi2;
            // Console.Write("bölüm = ");
            // Console.WriteLine(bolum);

            // Bölme işleminin ondalık sonuç vermesini istiyorsak
            // bölme işleminde kullanılan değişkenlerin
            // double, float veya decimal olması gerekir

            // double sayi3 = 13;
            // double sayi4 = 5;

            // double bolum2 = sayi3 / sayi4;
            // Console.Write("bölüm = ");
            // Console.WriteLine(bolum2);

            // Mod = iki sayının birbirine bölümünden kalan
            // int mod = sayi1 % sayi2;
            // Console.Write("mod = ");
            // Console.WriteLine(mod);


            // Console.WriteLine(sayi1);
            // sayi1 += 10;
            // sayıl değişkeninin üzerine 10 ekle
            // Console.WriteLine(sayi1);

            // sayi1++;//sayi1 in değerini 1 ekle
            // Console.WriteLine(sayi1);







            #endregion

            #region Karşılaştırma Operatöleri

            ////Karşılaştırma operatörleri her zaman boolean veri döndürür.
            //int sayi = 22;


            //Console.Write("sayı 10 dan büyük mü = ");
            //Console.WriteLine(sayi > 10);
            //Console.Write("sayı 10 dan küçük mü = ");
            //Console.WriteLine(sayi < 10);
            //Console.Write("sayı 10 a eşit mi = ");
            //Console.WriteLine(sayi == 10);
            //Console.Write("sayı 10 a büyük eşit mi = ");
            //Console.WriteLine(sayi >= 10);
            //Console.Write("sayı 10 a küçük eşit mi = ");
            //Console.WriteLine(sayi <= 10);
            //Console.Write("sayı 10 a eşit değil mi = ");
            //Console.WriteLine(sayi != 10); //Eşit değil ise true getirir

            ////! her zaman başa yazılır
            //Console.WriteLine(!true);
            //Console.Write("sayı 10 dqn büyük değil mi");
            //Console.WriteLine(!(sayi > 10));

            #endregion

            #region Mantıksal Operatörler

            // manrıksal operatörler ve veya komutlarına ihtiyaç duyduğumuzda kullanılır 
            //genellikle karşılaştırma operatörleri ile birlikte kullanılır. 
            //boolean veri türleri ile koşulları çoğaltmak veya aynı koşula birden çok değişken eklemek için tercih edilir 
            //mantıksal operatörlerin sağında ve solunda boolean veri olmalıdır
            //&& vea anlamında kullanılan mantıksal işelemler

            //true  && true  = true 
            //true  && false = false 
            //false && true  = false
            //false && false = false

            // || veya anlamında kullaılan 
            //true  || true  = true 
            //true  || false = true 
            //false || true  = true
            //false || false = false

            int sayi = 15;

            //sayı değişkeni içindeki veri 10 ile 20 arasında mı?
            Console.Write("sayı = ");
            Console.WriteLine(sayi);
            Console.Write("10 dan büyük mü = ");
            Console.WriteLine(sayi > 10);
            Console.Write("20 dan küçük mü = ");
            Console.WriteLine(sayi < 20);

            Console.Write("satı 10 ile 20 arasında mı = ");
            Console.WriteLine(sayi > 10 );
            #endregion


        }


    }
}
