using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikNoDogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kimlik No: ");
            string kimlikNo = Console.ReadLine();
            bool sonuc = KimlikNoKontrolEt(kimlikNo);
            if (sonuc)
            {
                Console.WriteLine("Kimlik No Doğru");
            }
            else
            {
                Console.WriteLine("Kimlik No Yanlış");
            }
            Console.ReadLine();
        }

        static bool KimlikNoKontrolEt(string kimlikNo)
        {
            #region yanlıs
            //bool sonuc = true;
            //if (kimlikNo.Length != 11)
            //{
            //    sonuc = false;
            //}
            //else
            //{
            //    if (kimlikNo.Substring(0,1) == "0")
            //    {
            //        sonuc = false;
            //    }
            //    else
            //    {
            //        // ....
            //    }
            //}
            #endregion

            if (kimlikNo.Length != 11)
            {
                return false;
            }
            if (kimlikNo.StartsWith("0"))
            {
                return false;
            }

            double[] haneler = new double[kimlikNo.Length];
            for (int h = 0; h < haneler.Length; h++)
            {
                haneler[h] = Convert.ToDouble(kimlikNo[h].ToString());
            }

            double tektoplam = (haneler[0] + haneler[2] + haneler[4] + haneler[6] + haneler[8]);
            double ciftToplam = haneler[1] + haneler[3] + haneler[5] + haneler[7];
            if ((tektoplam * 7 - ciftToplam) % 10 != haneler[9])
                return false;

            double tumToplam = 0;
            for (int h = 0; h < 10; h++)
            {
                tumToplam += haneler[h];
            }
            if (tumToplam % 10 != haneler[10])
            {
                return false;
            }

            return true;
        }

    }
}
