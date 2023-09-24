namespace TestTask5 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input path!")]
        public void TestValidateInputPath() {
            Program.CheckInput(null, ".gitignore");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input path!")]
        public void TestValidateInputPathq() {
            Program.CheckInput("", ".gitignore");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input filename!")]
        public void TestValidateInputFileName() {
            Program.CheckInput("D:/University/", null );
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Wrong input filename!")]
        public void TestValidateInputFileName2() {
            Program.CheckInput("D:/University/", "");
        }
        [TestMethod]
        public void TestSearch() {
            int amount = Program.FileSearch("D:/Downloads/", ".gitignore");
            Assert.IsTrue(amount == 1);

        }
    }
}