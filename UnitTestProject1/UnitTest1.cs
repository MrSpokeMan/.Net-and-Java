using Lab1;
using System.Text;
namespace UnitTestsProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Backpack problem;

        [TestInitialize]
        public void Setup()
        {
            problem = new Backpack(5, 12345);
        }

        [TestMethod]
        public void AtLeastOneItemFits()
        {
            Assert.IsTrue(problem.Solve(15).items.Count > 0);
        }

        [TestMethod]
        public void NoItemFits()
        {
            Backpack emptyProblem = new Backpack(5, 54321);

            Assert.AreEqual(0, emptyProblem.Solve(1).items.Count);
            Assert.AreEqual(0, emptyProblem.Solve(1).value);
            Assert.AreEqual(0, emptyProblem.Solve(1).weight);
        }

        [TestMethod]
        public void ItemOrderDoesNotAffectSolution()
        {
            Backpack problem1 = new Backpack(5, 12345);
            Backpack problem2 = new Backpack(5, 12345);

            CollectionAssert.AreEqual(problem1.Solve(15).items, problem2.Solve(15).items);
            Assert.AreEqual(problem1.Solve(15).value, problem2.Solve(15).value);
            Assert.AreEqual(problem1.Solve(15).weight, problem2.Solve(15).weight);
        }

        [TestMethod]
        public void SolutionIsCorrectForSpecificInstance()
        {
            Backpack specificProblem = new Backpack(3, 54321, true);
            specificProblem.AddItem(5, 10); 
            specificProblem.AddItem(7, 12); 
            specificProblem.AddItem(3, 6);  

            specificProblem.Solve(10);

            CollectionAssert.AreEqual(new List<int> { 1, 3 }, specificProblem.Solve(10).items);
            Assert.AreEqual(16, specificProblem.Solve(10).value);
            Assert.AreEqual(8, specificProblem.Solve(10).weight);
        }

        //My own methods
        [TestMethod]
        public void AddItemWorkProperly()
        {
            Backpack specifiedItem = new Backpack(1, 12343, true);
            specifiedItem.AddItem(5, 10);

            CollectionAssert.AreEqual(new List<int> { 1 }, specifiedItem.Solve(10).items);
            Assert.AreEqual(5, specifiedItem.Solve(10).weight);
            Assert.AreEqual(10, specifiedItem.Solve(10).value);
        }

        [TestMethod]
        public void CheckToStringMethod()
        {
            Backpack specifiedItem = new Backpack(1, 12343, true);
            specifiedItem.AddItem(5, 10);

            string result = specifiedItem.ToString();
            byte[] byteArray = Encoding.UTF8.GetBytes(result);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number of items: " + 1);
            sb.AppendLine("Items: ");
            sb.AppendLine("Item " + 1 + ": weight = " + 5 + ", value = " + 10);
            string expected = sb.ToString();

            byte[] byteArrayExpected = Encoding.UTF8.GetBytes(expected);

            Assert.IsTrue(byteArrayExpected.SequenceEqual(byteArray));
        }

        [TestMethod]
        public void CheckResultToStringMethod()
        {
            Backpack specifiedItem = new Backpack(1, 12343, true);
            specifiedItem.AddItem(5, 10);

            Result result = specifiedItem.Solve(10);

            string resultString = result.ToString();
            byte[] byteArray = Encoding.UTF8.GetBytes(resultString);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Items: ");
            sb.AppendLine("Item " + 1);
            sb.AppendLine("Total value: " + 10);
            sb.AppendLine("Total weight: " + 5);
            string expected = sb.ToString();

            byte[] byteArrayExpected = Encoding.UTF8.GetBytes(expected);

            Assert.IsTrue(byteArrayExpected.SequenceEqual(byteArray));
        }

        [TestMethod]
        public void TestResultConstructor()
        {
            Result result = new Result(new List<int> { 1, 2, 3 }, 10, 5);
            Assert.AreEqual(10, result.value);
            Assert.AreEqual(5, result.weight);
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result.items);
        }
    }
}