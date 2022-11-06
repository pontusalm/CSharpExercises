using System;
using System.Linq;

namespace Ovn2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool stopExecution = false;

            while (stopExecution == false)
            {
                Console.WriteLine("\nHuvudmeny  ");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Upprepa 10 gånger");
                Console.WriteLine("3. Det tredje ordet");
                Console.WriteLine("4. Exit");

                string choiceMenu1 = Console.ReadLine();

                switch (choiceMenu1)
                {
                    case "1":
                        Console.WriteLine("\nMeny köp biljett:");
                        Console.WriteLine("Ange 1 eller 2:");
                        Console.WriteLine("1. Enkelbiljett");
                        Console.WriteLine("2. Gruppbiljett");
                        string singelOrGroupTicket = Console.ReadLine();
                        if (singelOrGroupTicket == "1")
                        {   
                            Console.WriteLine("Du vill köpa enkelbiljett");
                            Console.WriteLine("Ange din ålder");
                            int age = Convert.ToInt32(Console.ReadLine());

                            if (age < 20)
                                Console.WriteLine("Ungdomspris: 80kr"); 
                            else if (age > 65)
                                Console.WriteLine("Pensionärspris 90kr");
                            else if (age >= 20 && age <= 65)
                                Console.WriteLine("Standardpris 120kr");

                            else
                                Console.WriteLine("Ogiltigt val");
                        }
                        else if (singelOrGroupTicket == "2")
                        {
                            Console.WriteLine("Du önskar köpa gruppbiljett.");
                            Console.WriteLine("Ange hur många personer ni är.");
                            int nrOfTickets = Convert.ToInt32(Console.ReadLine());
                            int priceGroupTicket = 0;

                            for (int i = 1; i < nrOfTickets + 1; i++)
                            {

                                Console.WriteLine($"Ange ålder för person nr {i}:");
                                int age = Convert.ToInt32(Console.ReadLine());
                                int ticketPrice = CalculatePriceForTicket(age);
                                priceGroupTicket = priceGroupTicket + ticketPrice;
                                Console.WriteLine($"Biljett nr{i} kostar {ticketPrice}kr");
                                Console.WriteLine($"Gruppbiljetten kostar {priceGroupTicket}kr");
                            }
                            Console.WriteLine("\n***********************************");
                            Console.WriteLine("Tack för din beställning");
                            Console.WriteLine($"Antal personer: {nrOfTickets} stycken");
                            Console.WriteLine($"Totalkostnad för hela sällskapet: {priceGroupTicket}kr");

                        }
                        else
                            Console.WriteLine("Ogiltigt val");
                        break;
                    case "2":
                        Console.WriteLine("Mata in en text och den skrivs ut tio gånger");
                        string printOut=Console.ReadLine();
                        for (int nrOfTimes = 1; nrOfTimes < 11; nrOfTimes++)
                            Console.Write($"{nrOfTimes}.{printOut}, ");
                        

                        break;
                    case "3":
                        Console.WriteLine("Skriv in en mening så hämtas tredje ordet ut:");
                        string wholeString = Console.ReadLine();
                        var wordInString = wholeString.Split(' ')[2];
                        Console.WriteLine(wordInString);

                        break;
                    case "4":
                        stopExecution = true;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val");
                        break;
;                }

               

            }




        }

        private static int CalculatePriceForTicket(int age)
        {
            //int age = Convert.ToInt32(Console.ReadLine());
            int ticketPrice = 0;
            if (age < 20)
                ticketPrice = 80;
            else if (age > 65)
                ticketPrice = 90;
            else if (age >= 20 && age <= 65)
                ticketPrice = 120;
            else
                Console.WriteLine("Ogiltigt val");
            return ticketPrice;
        }
    }
}