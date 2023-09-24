using System.IO;

namespace TestTask4 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestTableGeneration() {
            string dllPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string path = dllPath.Substring(0, dllPath.LastIndexOf("\\"));
            path += ("\\" + Program.FileName);

            Program.Main(null);
            Assert.IsTrue(File.Exists(dllPath) == true);
        }
    }
}