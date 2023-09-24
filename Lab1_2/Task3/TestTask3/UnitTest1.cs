using System.Collections.Generic;

namespace TestTask3 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Введено количество аргументов отличное от 2")]
        public void TestAmountOfINputParameters() {
            string[] args = { "13" };
            Program.CheckArgsAmount(args);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Введено количество аргументов отличное от 2")]
        public void TestAmountOfINputParameters2() {
            string[] args = { "13", "14", "15" };
            Program.CheckArgsAmount(args);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Вводимые параметры не могут быть преобразованы к исчисляемому типу")]
        public void TestConvertionArgsToDigit() {
            string[] args = { "13dbhsvfs", "4sv" };
            Program.CheckConvertionArgsToDigit(args);
        }
        [TestMethod]
        public void TestConvertionArgsToDigitDot() {
            string[] args = { "13.5", "24.3" };
            List<double> numbers = Program.CheckConvertionArgsToDigit(args);
            Assert.IsTrue(numbers.Count == args.Length);
        }
        [TestMethod]
        public void TestConvertionArgsToDigitComma() {
            string[] args = { "13,5", "24,3" };
            List<double> numbers = Program.CheckConvertionArgsToDigit(args);
            Assert.IsTrue(numbers.Count == args.Length);
        }
        [TestMethod]
        public void TestSquareCalculationComma() {
            string[] args = { "0,5", "4" };
            List<double> numbers = Program.CheckConvertionArgsToDigit(args);
            Assert.IsTrue(numbers.Count == args.Length);

            double square = Program.CalculateSquare(numbers);
            Assert.IsTrue(square == 2d);
        }
        [TestMethod]
        public void TestSquareCalculationDot() {
            string[] args = { "0.5", "4" };
            List<double> numbers = Program.CheckConvertionArgsToDigit(args);
            Assert.IsTrue(numbers.Count == args.Length);

            double square = Program.CalculateSquare(numbers);
            Assert.IsTrue(square == 2d);
        }
        [TestMethod]
        public void TestSquareCalculationInt() {
            string[] args = { "3", "4" };
            List<double> numbers = Program.CheckConvertionArgsToDigit(args);
            Assert.IsTrue(numbers.Count == args.Length);

            double square = Program.CalculateSquare(numbers);
            Assert.IsTrue(square == 12);
        }
    }
}