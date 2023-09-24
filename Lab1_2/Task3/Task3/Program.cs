using System;

public class Program {
    public static double CalculateSquare(List<double> numberArgs) {
        double square = 1;

        foreach (double num in numberArgs) {
            square *= num;
        }

        return square;
    }
    public static void CheckArgsAmount(string[] args) {
        if (args.Length != 2) {
            throw new ArgumentException("Введено количество аргументов отличное от 2");
        }

    }

    public static List<double> CheckConvertionArgsToDigit(string[] args) {
        List<double> numberArgs = new List<double>();
        foreach (string arg in args) {
            try {
                string number = arg.Replace(".", ",");
                numberArgs.Add(Convert.ToDouble(number));
            } catch (FormatException) {
                throw new FormatException("Вводимые параметры не могут быть преобразованы к исчисляемому типу");
            }
        }

        return numberArgs;
    }

    public static void Main(string[] args) {
        CheckArgsAmount(args);
        List<double> array = CheckConvertionArgsToDigit(args);
        
        double square = CalculateSquare(array);

        Console.WriteLine($"Square: {square}");
    }
}
