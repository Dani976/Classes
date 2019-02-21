using System;

namespace Class
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public Person(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Leopold", 6, 121);
            Console.WriteLine("person1 Name = {0} Age = {1} Height = {2}", person1.Name, person1.Age, person1.Height);

            Person person2 = person1;

            person2.Name = "Molly";
            person2.Age = 16;
            person2.Height = 168;

            Person person3 = new Person("Mark", 24, 182);

            Console.WriteLine("person1 Name = {0} Age = {1} Height = {2}", person1.Name, person1.Age, person1.Height);
            Console.WriteLine("person2 Name = {0} Age = {1} Height = {2}", person2.Name, person2.Age, person2.Height);
            Console.WriteLine("person3 Name = {0} Age = {1} Height = {2}", person3.Name, person3.Age, person3.Height);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}

