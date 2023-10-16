using System;

namespace MiftahulHuda_3SIC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
             

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name ");

            string FirstName;
            string myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name? ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName+" "+ myLastName);
            Console.ReadLine();
            */

            // Biodata


            /*
            Console.Write("Masukkan Nama: ");
            string Myname = Console.ReadLine();

            Console.Write("Masukkan Umur: ");
            int myAge =int.Parse( Console.ReadLine());

            Console.Write("Masukkan Prodi: ");
            string myProdi = Console.ReadLine();


            Console.Write("Masukkan Nomor Hp: ");
            string myNoHp = Console.ReadLine();

            Console.Write("Alasan masuk PCR: ");
            string myreason = Console.ReadLine();

            Console.WriteLine("Nama: " + Myname + "\n" + "umur: " + myAge + "\n" + "Prodi: " + myProdi + "\n" + "No Hp: " + myNoHp + "\n" + "Alasan Msuk Pcr: " + myreason);
            Console.ReadLine();

            */
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door : 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "You won a new car";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "You won a new boat";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                string message = "You won a new cat";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry we didnt understan";
                Console.WriteLine(message);
            }
            

            
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door : 1, 2, or 3: ");
            string userValue = Console.ReadLine();
            string message = " ";

            if (userValue == "1")
            {
                message = "You won a new car";
            
            }
            else if (userValue == "2")
            {
                message = "You won a new boat";
                
            }
            else if (userValue == "3")
            {
                message = "You won a new cat";
                
            }
            else
            {
                message = "Sorry we didnt understan ";
                message = message+  "You Lost";

            }
            Console.WriteLine(message);
            Console.ReadLine();
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            */
            Console.Write("Masukkan Angka: ");
            int num = int.Parse(Console.ReadLine());
            string ket = " ";
            if (num < 0)
            {
                ket = "Negatif";

            }
            else if (num %2 == 0)
            {
                ket = "the number is even";

            }
            else if (num % 2 != 0)
            {
                ket = "the number is odd";

            }
            else
            {
                ket = "inputan salah";
            }

            Console.WriteLine(ket);
            Console.ReadLine();


        }
    }
}
