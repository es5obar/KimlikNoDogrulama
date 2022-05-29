using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif tam sayı giriniz (0 : çıkış) : ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc;
            while (sayi != 0)
            {
                if (sayi > 0)
                {
                    sonuc = FaktoriyelHesapla(sayi);
                    Console.WriteLine($"{sayi} 'nın faktoriyeli : {sonuc} ");
                }
                else
                {
                    Console.WriteLine("Pozitif tam sayı girin !!! ");
                }
                Console.Write("Pozitif tam sayı giriniz (0 : çıkış) : ");
                sayi = int.Parse(Console.ReadLine());
            }
        }

        static int FaktoriyelHesapla(int sayi)
        {
            int sonuc = sayi;
            for (int i = sayi-1 ; i >= 2; i--)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }
    }
}
