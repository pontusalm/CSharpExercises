namespace Ovn2
{
    public class PersonHandler
    {
        public Person CreatePerson(int age)
        {
            var newPerson = new Person();
            newPerson.Age = age;


            return newPerson;
        }


        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }


    }
}