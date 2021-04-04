using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı giriniz:");
            string ad = Console.ReadLine();
            Console.Write("soyadınızı giriniz:");
            string soyad = Console.ReadLine();
            
            bool aramaAd = rakamAra(ad);
            bool aramaSoyad = rakamAra(soyad);
            if (aramaAd == true)
                Console.WriteLine("Ad rakam içermemeli.");
            if (aramaSoyad == true)
                Console.WriteLine("Soyad rakam içermemeli.");
            Console.ReadLine();
        }
        public static bool rakamAra(string aranacakmetin)
        {
            if (aranacakmetin.Contains('1'))
                return true;
            else if (aranacakmetin.Contains('2'))
                return true; 
            else if (aranacakmetin.Contains('3'))
                return true;
            else if(aranacakmetin.Contains('4'))
                return true;
            else if(aranacakmetin.Contains('5'))
                return true;
            else if(aranacakmetin.Contains('6'))
                return true;
            else if(aranacakmetin.Contains('7'))
                return true;
            else if(aranacakmetin.Contains('8'))
                return true;
            else if(aranacakmetin.Contains('9'))
                return true;
            else if(aranacakmetin.Contains('0'))
                return true;
            else return false;






        }
    }
}
