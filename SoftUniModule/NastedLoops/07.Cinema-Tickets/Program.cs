using System;

namespace _07.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            int totalTickets = 0;
            int countStandard = 0;
            int countStudent = 0;
            int countKids = 0;


            while (title != "Finish")

            {
                int volume = int.Parse(Console.ReadLine());

                string typeTicket = Console.ReadLine();
                int currentTickets = 0;
                while (typeTicket != "End")
                {
                    switch (typeTicket)
                    {
                        case "standard":
                            countStandard++;
                            break;
                        case "kid":
                            countKids++;
                            break;
                        case "student":
                            countStudent++;
                            break;
                        default:
                            break;
                    }
                    currentTickets++;
                    
                    typeTicket = Console.ReadLine();
                }
                totalTickets += currentTickets;

                double seatsTaken = currentTickets * 1.0 / volume * 100;
                Console.WriteLine($"{title} - {seatsTaken:f2} % full.");
                title = Console.ReadLine();
            }
            double standardTicketsPercent = countStandard * 1.0 / totalTickets * 100;
            double kidTicketsPercent = countKids * 1.0 / totalTickets * 100;
            double studentTicketsPercent = countStudent * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPercent:f2} % student tickets");
            Console.WriteLine($"{kidTicketsPercent:f2} % kids tickets");
            Console.WriteLine($"{standardTicketsPercent:f2} % standard tickets");
        }
    }
}
