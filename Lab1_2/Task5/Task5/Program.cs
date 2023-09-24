public class Program {
    public static int FileSearch(string inputPath, string inputFileName) {
        string[] allFoundFiles = Directory.GetFiles(inputPath, inputFileName, SearchOption.AllDirectories);

        if (allFoundFiles.Length == 0) {
            Console.WriteLine("No files found");
        }

        Console.WriteLine();
        Console.WriteLine("Search result: ");

        foreach (string item in allFoundFiles) {
            Console.WriteLine(item);
        }

        return allFoundFiles.Length;
    }

    public static void CheckInput(string? inputPath, string? inputFileName) {
        if (inputPath is null || inputPath?.Length == 0) {
            throw new ArgumentException("Wrong input path!");
        }

        if (inputFileName is null || inputFileName?.Length == 0) {
            throw new ArgumentException("Wrong input filename!");
        }


        return;
    }
    public static void Main(string[] args) {
        Console.WriteLine("Enter path (where to search): ");
        string? inputPath = Console.ReadLine();

        Console.WriteLine("Enter filename: ");
        string? inputFileName = Console.ReadLine();

        CheckInput(inputPath, inputFileName);
        FileSearch(inputPath, inputFileName);

        return;
    }

}


