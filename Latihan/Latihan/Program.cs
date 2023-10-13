class program
{
    static void Main(String[] args)
    {
        Console.Write("Tuliskan nilai anda: ");
        int score = int.Parse(Console.ReadLine());

        String grade = "";
        String desc = "";

        if (score >= 0 && score <= 100)
        {
            if (score >= 55)
            {
                desc = "Lulus";

                if (score >= 81)
                {
                    grade = "A";
                }
                else if (score >= 78)
                {
                    grade = "AB";
                }
                else if (score >= 66)
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
                desc = "Tidak Lulus";
                grade = "F";
            }
            Console.WriteLine("Nilai anda " + score +
              "\nAnda mendapatkan " + grade + " dan dinyatakan \"" + desc + "\".");
        }
        else
        {
            Console.WriteLine("Nilai tidak valid!");
        }
        Console.ReadLine();
    }
}