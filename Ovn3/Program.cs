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
                var person = ph.CreatePerson(30, "Peter", "Karlsson", 172.3, 75.6);
                //ph.SetAge(person, 14);

                Console.WriteLine(person.Age);
                Console.WriteLine(person.FName);
                Console.WriteLine(person.LName);
                Console.WriteLine(person.Height);
                Console.WriteLine(person.Weight);
            }

            catch (ArgumentException errorCatch)
            {
                Console.WriteLine(errorCatch.Message);
            }


            }
    }
}