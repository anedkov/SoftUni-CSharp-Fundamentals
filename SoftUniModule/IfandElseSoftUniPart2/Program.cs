using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfandElseSoftUniPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sumirane na sekundi
            //int firstTime = int.Parse(Console.ReadLine());
            //int secondTime = int.Parse(Console.ReadLine());
            //int thirdTime = int.Parse(Console.ReadLine());

            //int totalTime = firstTime + secondTime + thirdTime;

            //int minutes = totalTime / 60;
            //int seconds = totalTime % 60;


            //if (seconds < 10)
            //{
            //    Console.WriteLine($"{minutes}:0{seconds}");
            //}

            //else
            //{
            //    Console.WriteLine($"{minutes}:{seconds}");
            //}

            //zad 2 bonus tochki 

            // int points = int.Parse(Console.ReadLine());
            // double bonusPoints = 0;
            // if (points <= 100)
            // {
            //     bonusPoints = 5;
            // }
            // else if (points > 1000)
            // {
            //     bonusPoints = points * 0.1;
            // }
            // else if (points > 100)
            // {
            //     bonusPoints = points * 0.2;
            // }

            //// do tuk pravihme proverka za negovata golemina, zatova trqbva da napravim nov if za drugite usloviq
            // if (points % 2 == 0)
            // {
            //     bonusPoints += 1;
            // }

            // else if (points % 10 == 5)
            // {
            //     bonusPoints += 2;
            // }
            // double total = points + bonusPoints;
            // Console.WriteLine(bonusPoints);
            // Console.WriteLine(total);


            //zad3.SpeedTest

            //double speed = double.Parse(Console.ReadLine());

            //if (speed < 10)
            //{
            //    Console.WriteLine("slow");
            //}
            //else if (speed > 10 && speed <= 50)
            //{
            //    Console.WriteLine("average");
            //}
            //else if (speed > 50 && speed <= 150)
            //{
            //    Console.WriteLine("fast");
            //}
            //else if (speed > 150 && speed <= 1000)
            //{
            //    Console.WriteLine("ultra fast");
            //}
            //else
            //{
            //    Console.WriteLine("extremely fast");
            //}

            //double sumToConvert = double.Parse(Console.ReadLine());
            //string inputMeasure = Console.ReadLine();
            //string outputMeasure = Console.ReadLine();

            ////пример: на колко инча са равни 2мм? - (2мм / 1000) * 39.37

            //switch (inputMeasure) // тук превръщаме всичко към метри
            //{
            //    case "m": sumToConvert /= 1; break;
            //    case "mm": sumToConvert /= 1000; break;
            //    case "cm": sumToConvert /= 100; break;
            //    case "inch": sumToConvert /= 39.37; break;
            //    default:
            //        break;
            //}

            //switch (outputMeasure) // а тук получените метри ги превръщаме към търсената мярка
            //{
            //    case "m": sumToConvert *= 1; break;
            //    case "mm": sumToConvert *= 1000; break;
            //    case "cm": sumToConvert *= 100; break;
            //    case "inch": sumToConvert *= 39.37; break;
            //    default:
            //        break;
            //}

            //Console.WriteLine($"{sumToConvert:f3}");

            //int hourinput = int.Parse(Console.ReadLine());
            //int minutesInput = int.Parse(Console.ReadLine());
            ////convert time to minutes 
            //int timeToMinutes = hourinput * 60 + minutesInput;
            ////convert time to minutes after 15 
            //int timeToMinutesAfter = timeToMinutes + 15;
            ////back to hours
            //int hoursAfter = timeToMinutesAfter / 60;
            //int minutesAfter = timeToMinutesAfter % 60;

            //Console.WriteLine($"{hoursAfter}: 0{timeToMinutesAfter}");

            //zad6. godzilla.vs.kong
            //•	Декорът за филма е на стойност 10% от бюджета. -> бюджет * 0.2;
            //При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.


            //double budget = double.Parse(Console.ReadLine());
            //int countStatists = int.Parse(Console.ReadLine());
            //double pricePerStatists = double.Parse(Console.ReadLine());

            //double priceDecor = budget * 0.1;
            //double priceClothes = countStatists * pricePerStatists;

            //if (countStatists > 150)
            //{
            //   priceClothes = priceClothes - 0.10 * priceClothes;
            //}

            //double total = priceDecor + priceClothes;

            //if (total > budget)

            //{
            //    Console.WriteLine("Not enough money");
            //    double needMoney = total - budget;
            //    Console.WriteLine($"Wingards needs {needMoney:F2} leva more.");
            //}
            //else 
            //{
            //    Console.WriteLine("Action!");
            //    double leftMoney = budget - total;
            //    Console.WriteLine($"Wingards needs {leftMoney:F2} leva left.");
            //}

            //zad7.svetoven rekod po pluvane

            //double recordInSeconds = double.Parse(Console.ReadLine());
            //double distanceInMetters = double.Parse(Console.ReadLine());
            //double timeInSecondsForMetter = double.Parse(Console.ReadLine());

            //double prepluvaniInSeconds = distanceInMetters * timeInSecondsForMetter; // prepluvani v sekundi

            //double delaySec = Math.Floor(distanceInMetters / (double)15); // zabavqneto 
            //delaySec *= 12.5;
            //double total = prepluvaniInSeconds + delaySec;

            //if (total < recordInSeconds)
            //{
            //    double timeMissing = total - recordInSeconds;

            //    Console.WriteLine($"No, he failed! He was {total:F2} seconds slower");
            //}

            //else
            //{
            //    double newRecord = recordInSeconds - total;
            //    Console.WriteLine($"Yes, he succeeded! The new world record is: {total - recordInSeconds:F2} seconds.");
            //}
            // 8 zad Stipendii*

            //double dohodInleva = double.Parse(Console.ReadLine());
            //double sredenUspeh = double.Parse(Console.ReadLine());
            //double minimalnaZaplata = double.Parse(Console.ReadLine());
            //double socialScholarship = minimalnaZaplata * 0.35;
            //double gradeScholarship = sredenUspeh * 25;
           

            //if (sredenUspeh > 4.5 && sredenUspeh < 5.5)
            //{
            //    if (dohodInleva < minimalnaZaplata)
            //    {
            //        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");

            //    }
            //    else
            //    {
            //        Console.WriteLine("You cannot get a scholarship!");
            //    }
            //}


            //else if (sredenUspeh > 5.5)
            //{
            //    if (dohodInleva < minimalnaZaplata)
            //    {
            //        if (socialScholarship > gradeScholarship)
            //        {
            //            Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"You get a Social scholarship {Math.Floor(gradeScholarship)} BGN");
            //        }
            //    }



            //}
            //else
            //{

            //    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");

            //}



           
            

            //if (sredenUspeh <= 4.5)
            //{
            //    Console.WriteLine("You cannot get a scholarship!");
            //}


        }
    }
}

