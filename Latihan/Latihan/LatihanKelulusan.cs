using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    internal class LatihanKelulusan
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkkan nilai anda: ");
            int nilai = int.Parse(Console.ReadLine());

            String grade = "";
            String ket = "";

            if (nilai >= 0 && nilai <= 100)
            {
                if (nilai >= 55)
                {
                    ket = "Lulus";

                    if (nilai >= 81)
                    {
                        grade = "A";
                    }
                    else if (nilai >= 78)
                    {
                        grade = "AB";
                    }
                    else if (nilai >= 66)
                    {
                        grade = "B";
                    }
                    else
                    {
                        grade = "C";
                    }
                }
                else
                {
                    ket = "Tidak Lulus";
                    grade = "F";
                }
                Console.WriteLine("Nilai anda " + nilai +
                  "\nAnda mendapatkan " + grade + " dan dinyatakan \"" + ket + "\".");
            }
            else
            {
                Console.WriteLine("Nilai tidak ditemukan!");
            }
            Console.ReadLine();
        }
    }
}
