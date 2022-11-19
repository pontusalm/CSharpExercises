namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////single space(or)
            //string line = "Hello world";
            ////double space(or)
            //string line = "Hello  world";
            ////multiple space(or)
            //string line = "Hello     world";
            ////multiple Strings
            //string line = "Hello world this is a test";

            Object myObject = new Object();
            myObject.Equals(null);

            Console.WriteLine("Ange hur många biljetter du önskar köpa");
            int nrOfTickets = Convert.ToInt32(Console.ReadLine());
            int priceGroupTicket = 0;

            for (int i = 1; i < nrOfTickets +1; i++)
            {
               
                Console.WriteLine($"Ange ålder för person nr {i}:");
                int age = Convert.ToInt32(Console.ReadLine());
                int ticketPrice = CalculatePriceForTicket(age);
                priceGroupTicket =priceGroupTicket + ticketPrice;
                Console.WriteLine($"Biljett nr{i} kostar {ticketPrice}kr");
                Console.WriteLine($"Gruppbiljetten kostar {priceGroupTicket}kr");
            }
            Console.WriteLine("\n***********************************");
            Console.WriteLine("Tack för din beställning");
            Console.WriteLine($"Antal personer: {nrOfTickets} stycken");
            Console.WriteLine($"Totalkostnad för hela sällskapet: {priceGroupTicket}kr"); 

            //int biljettnr1 = CalculatePriceForTicket(15);
            //int biljettnr2 = CalculatePriceForTicket(40);
            //int biljettnr3 = CalculatePriceForTicket(67);

            //Console.WriteLine($"nr 1: {biljettnr1}kr");
            //Console.WriteLine($"nr 2: {biljettnr2}kr");
            //Console.WriteLine($"nr 3: {biljettnr3}kr");


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