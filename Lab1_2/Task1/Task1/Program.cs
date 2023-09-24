public class Program {
    public static string GenerateExclamationPointsString(int min, int max) {
        int amountOfExclamationPoints = new Random().Next(min, max + 1);

        return new string('!', amountOfExclamationPoints);
    }

    public static void Main(string[] args) {    
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Andhiagain!");
        Console.WriteLine(GenerateExclamationPointsString(5, 50));
    }
}