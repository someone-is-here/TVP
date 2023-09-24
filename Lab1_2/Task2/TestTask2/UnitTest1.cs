using Task2;

namespace TestTask2 {
    [TestClass]
    public class UnitTest1 {
        private List<Person> people = new List<Person> { new Person("Name", "Surname", 13),
                                                         new Person("Name", "Surname", 103),
                                                         new Person("Name", "Surname", 51)
                                                        };
        private int minAge = 13;
        private int maxAge = 103;
        private double averageAge = 55.67d;

        [TestMethod]
        public void ValidateInputName() {
            int age = 0;
            bool checkInput = Program.ValidateInput(null, "Surname", "13", out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("", "Surname", "13", out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("Name", "Surname", "13", out age);
            Assert.IsTrue(checkInput == true);
        }

        [TestMethod]
        public void ValidateInputSurname() {
            int age = 0;

            bool checkInput = Program.ValidateInput("Name", null, "13", out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("Name", "", "13", out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("Name", "Surname", "13", out age);
            Assert.IsTrue(checkInput == true);
        }

        [TestMethod]
        public void ValidateInputAge() {
            int age = 0;

            bool checkInput = Program.ValidateInput("Name", "Surname", null, out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("Name", "Surname", "", out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("Name", "Surname", "-1", out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("Name", "Surname", "200", out age);
            Assert.IsTrue(checkInput == false);

            checkInput = Program.ValidateInput("Name", "Surname", "13", out age);
            Assert.IsTrue(checkInput == true);
        }
        [TestMethod]
        public void CheckGetMinAge() {
            int minAge = Person.GetMinAge(people);
            Assert.IsTrue(minAge == this.minAge);        
        }
        [TestMethod]
        public void CheckGetMaxAge() {
            int maxAge = Person.GetMaxAge(people);
            Assert.IsTrue(maxAge == this.maxAge);
        }
        [TestMethod]
        public void CheckGetAverageAge() {
            double averageAge = Person.GetAverageAge(people);
            Assert.IsTrue(averageAge == this.averageAge);
        }
    }
}