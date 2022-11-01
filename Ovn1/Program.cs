using System;

namespace Ovn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Skulle ha använt dictionary för att samla ID, Förnamn, Efternamn, lön.
            // 2. En metod för att lägga till ny anställd. En metod för att uppdatera anställd.




            string[] namn = new string[] { "Olle Karlsson 10 000kr", "Anna Jansson 15 000kr", "Kalle Svenson 20 000kr" };
            

            bool admin = true;
            Console.WriteLine(admin);

            while (admin == true)
            {
                Console.WriteLine("---- Register ---- ");
                Console.WriteLine(" Välj tjänst ");
                Console.WriteLine(" 1. Lägg till anställd och lön");
                Console.WriteLine(" 2. skriv ut anställda ");
                Console.WriteLine(" 3. Avsluta");

                int val = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(val);

                if (val == 1)
                {
                    Console.WriteLine("Lägg till anställd och lön");
                    string appendEmployee = Console.ReadLine(); 
                    string[] result = namn.Append(addEmployee);
                 
                }
                else if (val == 2)
                {
                    Console.WriteLine("\nLista över anställda");
                    for (int i = 0; i < namn.Length; i++)
                        Console.WriteLine(namn[i]);
                    Console.WriteLine("");
                }
                else if (val == 3)
                {
                    Console.WriteLine("Välkommen åter");
                    admin = false;
                }
                else
                    Console.WriteLine("Du har inte angett giltigt tal");





            }


        }
    }
}