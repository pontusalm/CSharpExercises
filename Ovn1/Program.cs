using System;

namespace Ovn1
{
    internal class Program
    {
        static void Main(string[] args)
        {


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
                    namn[].Append("Sten stensson 30 000kr");
                 
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


                //char[] characterArray = message.ToCharArray();
                //Array.Reverse(characterArray);
                //return String.Concat(characterArray);



            }


        }
    }
}