namespace Ovn2
{
    public class Person
    {
        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be a positive integer. ");
                }
                age = value;
            }
        }
        public Person()
        {


        }
    }
}