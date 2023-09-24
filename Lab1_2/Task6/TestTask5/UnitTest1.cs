namespace TestTask5 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "������� ���������� ���������� �������� �� 2")]
        public void TestCheckAmountArgumentExceptionFew() {
            string[] args = new string[] { "arg1" };
            Program.Main(args);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "������� ���������� ���������� �������� �� 2")]
        public void TestCheckAmountArgumentExceptionMany() {
            string[] args = new string[] { "arg1", "arg1", "arg1" };
            Program.Main(args);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "�������� �������� ������")]
        public void TestCheckUrlInputNull() {            
            Program.CheckInput(null,"pathForSaving");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "�������� �������� ������")]
        public void TestCheckUrlInputEmpty() {
            Program.CheckInput("", "pathForSaving");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "�������� �������� ����")]
        public void TestCheckPathForSavingInputNull() {
            Program.CheckInput("URL", null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "�������� �������� ����")]
        public void TestCheckPathForSavingInputEmpty() {
            Program.CheckInput("URL", "");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Filepath is wrong. Or you forget to enter filename")]
        public void TestIncorrectSavingPath() {
            string data = Program.GetDocumentFromURL(@"https://habr.com/ru/articles/656919/");
            Program.SaveDataFromURL("D:/University/", data);
        }
        [TestMethod]
        public void TestCorrectSavingPath() {
            string data = Program.GetDocumentFromURL(@"https://habr.com/ru/articles/656919/");
            Program.SaveDataFromURL("D:/University/info.html", data);
        }
    }
}