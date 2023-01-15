using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string korisnik;
            korisnik = Console.ReadLine();
            string sVelika = korisnik.ToUpper();
            string sMala = korisnik.ToLower();
            string sPrvaTri = korisnik.Remove(3);
            string sZadnjihPet = korisnik.Substring(korisnik.Length-5);
            string s8_11 = korisnik.Substring(8, 11);

            Console.WriteLine(sVelika+sMala+sPrvaTri+sZadnjihPet+s8_11);

            Console.ReadKey();
        }
    }
}
