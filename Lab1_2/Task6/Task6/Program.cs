using System.Net;


public class Program {
    public static void CheckInput(string? url, string? pathForSaving) {

        if (url is null || url.Length == 0) {
            throw new ArgumentException("Неверный параметр ссылка");
        }

        if (pathForSaving is null || pathForSaving.Length == 0) {
            throw new ArgumentException("Неверный параметр путь");
        }

        return;
    }

    public static string GetDocumentFromURL(string url) {

        var webRequest = WebRequest.Create(url);
        string strContent;

        using (var response = webRequest.GetResponse())
        using (var content = response.GetResponseStream())
        using (var reader = new StreamReader(content)) {

            strContent = reader.ReadToEnd();

        }

        return strContent;
    }

    public static void SaveDataFromURL(string path, string data) {
        if (path.EndsWith("\\") || path.EndsWith("//")) {
            path += "/";
        }
        try {
            using (FileStream fs = new FileStream(path, FileMode.Create)) {
                using (StreamWriter sw = new StreamWriter(fs)) {
                    sw.WriteLine(data);
                }
            }
        } catch (Exception ex) {
            throw new ArgumentException("Filepath is wrong. Or you forget to enter filename");
        }

        return;
    }
    public static void Main(string[] args) {
        if (Environment.GetCommandLineArgs().Length != 3) {
            throw new ArgumentException("Введено количество аргументов отличное от 2");
        }

        string? uri = Environment.GetCommandLineArgs()[1];
        string path = Environment.GetCommandLineArgs()[2];

        CheckInput(uri, path);

        string dataFromURI = GetDocumentFromURL(uri);

        SaveDataFromURL(path, dataFromURI);
    }
}