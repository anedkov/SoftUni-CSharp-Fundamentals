using System;

namespace _08.Scholarships
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohodInleva = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minimalnaZaplata = double.Parse(Console.ReadLine());
            double socialScholarship = minimalnaZaplata * 0.35;
            double gradeScholarship = sredenUspeh * 25;


            if (sredenUspeh > 4.5 && sredenUspeh < 5.5)
            {
                if (dohodInleva < minimalnaZaplata)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");

                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }


            else if (sredenUspeh > 5.5)
            {
                if (dohodInleva < minimalnaZaplata)
                {
                    if (socialScholarship > gradeScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(gradeScholarship)} BGN");
                    }
                }

            }
            else
            {

                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");

            }


            if (sredenUspeh <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
