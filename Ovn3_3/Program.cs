namespace Ovn3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse horse2 = new Horse();
            Horse horse1 = horse2;
            Horse horse = horse1;
            horse.DoSound();

            Console.ReadLine();
        }
    }
}