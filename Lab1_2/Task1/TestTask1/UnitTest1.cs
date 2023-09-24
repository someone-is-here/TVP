namespace TestTask1 {
    [TestClass]
    public class UnitTest1 {
        private const int min = 5;
        private const int max = 50;

        [TestMethod]
        public void TestGenerateExclamationPointsStringRange() {            
            string result = Program.GenerateExclamationPointsString(min, max);

            Assert.IsTrue(result.Length >= min);
            Assert.IsTrue(result.Length <= max);
        }

        [TestMethod]
        public void TestGenerateExclamationPointsStringDistinctess() {
            string result = Program.GenerateExclamationPointsString(min, max);
            Assert.IsTrue(result.Distinct().Count() == 1);
        }

        [TestMethod]
        public void TestGenerateExclamationPointsStringValue() {
            string result = Program.GenerateExclamationPointsString(min, max);
            Assert.IsTrue(result.Distinct().First() == '!');
        }
    }
}