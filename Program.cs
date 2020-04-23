using System;

namespace Tugas_Modul4_kel59
{
    class Program
    {
        static void id_kel(String a, String b, String c, String d)
        {
            Console.WriteLine("Kelompok {0} - Shift {1} Praktikum DKP 2020 \n {2} \n {3}", a, b, c, d);
            Console.WriteLine("=====================================================================\n");
        }
        static String welcome()
        {
            return "********Selamat Datang di ATM Bank Kita*********";
        }

        static void Main(string[] args)
        {
            id_kel("59", "2", "Putri Rohmawati - 21120118120026", "Fadzil Ferdiawan - 21120119130056");
            Console.WriteLine(welcome());
            Method objek = new Method();
            objek.ATM();
        }
    }
}