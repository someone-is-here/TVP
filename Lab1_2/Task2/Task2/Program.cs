using Task2;

public class Program {
    public static bool ValidateInput(string? inputName, string? inputSurname, string? inputAge, out int age) {
        bool isInputCorrect = false;
        age = 0;

        try {
            if (inputName is null || inputName?.Length == 0) {
                throw new Exception("Name can't be empty.");
            }
            if (inputSurname is null || inputSurname?.Length == 0) {
                throw new Exception("Surname can't be empty.");
            }
            if (inputAge is null || inputAge?.Length == 0) {
                throw new Exception("Age can't be empty.");
            }
            age = Convert.ToUInt16(inputAge);

            if (age < 0 || age > 130) {
                throw new FormatException();
            }

            isInputCorrect = true;

        } catch (FormatException) {
            Console.WriteLine("Age input isn't correct");
            isInputCorrect = false;
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
            isInputCorrect = false;
        }

        return isInputCorrect;
    }

    public static void Main(string[] args) {
        bool isExit = false;

        List<Person> people = new List<Person>();

        while (!isExit) {
            Console.WriteLine("Enter name: ");
            string? inputName = Console.ReadLine();

            Console.WriteLine("Enter surname: ");
            string? inputSurname = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            string? inputAge = Console.ReadLine();

            ValidateInput(inputName, inputSurname, inputAge, out int age);
            people.Add(new Person(inputName, inputSurname, age));

            Console.WriteLine("Do you want to enter another person? Press enter...");
            var inputKey = Console.ReadKey();

            if (inputKey.Key != ConsoleKey.Enter) {
                isExit = true;
            }
        }

        Console.Clear();
        Person.ShowPersonArray(people);
        Console.WriteLine($"Min age: {Person.GetMinAge(people)};\tMax age: {Person.GetMaxAge(people)}\t Average: {Person.GetAverageAge(people)} ");
    }
}
