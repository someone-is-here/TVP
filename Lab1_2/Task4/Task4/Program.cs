using System.IO.Enumeration;

public class Program {
    public static string FileName = "HTML_GENERATED.html";

    public static void GenerateHTMLTable(StreamWriter sw) {
        sw.WriteLine("<table style=\"height:100%;width:100%;border-collapse:collapse;\">");

        for (int i = 255; i >= 0; i--) {
            sw.WriteLine($"<tr style=\"background: rgb({i},{i},{i}); height:0.4%;width:100%;\">");
            sw.WriteLine($"<td style=\"background: rgb({i},{i},{i}); height:0.4%;width:100%;\"></td>");
            sw.WriteLine("</tr>");
        }
        sw.WriteLine("</table>");

        return;
    }

    public static void GenerateHTMLFile(StreamWriter sw) {
        sw.WriteLine("<!DOCTYPE html>");
        sw.WriteLine("<html><head><meta charset='utf-8'/>");
        sw.WriteLine("<style> * { padding: 0; margin: 0; border: none; height:100%; }</style>");
        sw.WriteLine("</head>");

        sw.WriteLine("<body>");

        GenerateHTMLTable(sw);

        sw.WriteLine("</body> ");
        sw.WriteLine("</html>");

        return;
    }

    public static void Main(string[] args) {
        using (StreamWriter sw = File.CreateText(FileName)) {
            GenerateHTMLFile(sw);
        }

        Console.WriteLine("Successfully generated!");
    }
}

