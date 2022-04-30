using System;

namespace Extension_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ters Çevirmek istediğiniz kelimeyi giriniz : ");
            string metin = Console.ReadLine();
            Console.WriteLine("Ters dönmüş metin = " + metin.Reverse());
            Console.ReadLine();
        }
    }

    static class Extension
    {
        public static string Reverse(this string metin)
        {
            string yeniMetin = "";
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                yeniMetin += metin[i];
            }
            return yeniMetin;
        }
    }
}
