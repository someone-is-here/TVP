namespace Task2 {
    public class Person {
        public Person(string name, string surname, int age) {
            Age = age;
            Name = name;
            Surname = surname;
        }
        public int Age { get; }
        public string Name { get; }
        public string Surname { get; }

        public static int GetMinAge(List<Person> people) {
            int minAge = people.Min(person => person.Age);
            return minAge;
        }
        public static int GetMaxAge(List<Person> people) {
            int maxAge = people.Max(person => person.Age);
            return maxAge;
        }
        public static double GetAverageAge(List<Person> people) {
            double averageAge = ((double) people.Sum(person => person.Age)) / people.Count;
           
            return Math.Round(averageAge, 2);
        }
        public static void ShowPersonArray(List<Person> people) {
            Console.WriteLine($"Name\t\t Surname\t\t Age");

            foreach (Person person in people) {
                Console.WriteLine($"{person.Name}\t\t {person.Surname}\t\t {person.Age}");
            }
        }
    }
}
