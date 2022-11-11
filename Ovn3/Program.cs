namespace Ovn3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fråga1.Ja jag kommer direkt åt variablerna.



            //Person person1 = new Person();
            //person1.Age = 25;
            //person1.FName = "Anders";
            //person1.LName = "Jansson";
            //person1.Height = 172.3;
            //person1.Weight = 72;

            //Console.WriteLine($"{person1.FName} {person1.LName}, age {person1.Age}, height {person1.Height}, weight {person1.Weight}");



            var ph = new PersonHandler();

            try
            {
                var person2 = ph.CreatePerson(30, "Peter", "Karlsson", 172.3, 75.6);
                ph.SetAge(person2, 14);

                Console.WriteLine(person2.Age);
                Console.WriteLine(person2.FName);
                Console.WriteLine(person2.LName);
                Console.WriteLine(person2.Height);
                Console.WriteLine(person2.Weight);
        }

            catch (ArgumentException errorCatch)
            {
                Console.WriteLine(errorCatch.Message);
            }

            try
            {
                var person3 = ph.CreatePerson(30, "Jonas", "Svensson", 152, 48);

                Console.WriteLine("");
                Console.WriteLine(person3.Age);
                Console.WriteLine(person3.FName);
                Console.WriteLine(person3.LName);
                Console.WriteLine(person3.Height);
                Console.WriteLine(person3.Weight);
            }

            catch (ArgumentException errorCatch)
            {
                Console.WriteLine(errorCatch.Message);
            }



        }
    }
}