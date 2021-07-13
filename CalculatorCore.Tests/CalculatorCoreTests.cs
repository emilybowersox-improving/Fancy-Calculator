using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalculatorCore.Tests
{
    [TestClass]
    public class CalculatorCoreTests
    {
        private Calculator _calc;
   
        [TestInitialize]

        public void SetupOrInitilize()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            // Arrange
            // var calc = new Calculator();

            // Act
            EvaluationResult result = _calc.Evaluate("6 + 8");

            // Assert
            Assert.AreEqual(14m, result.Result);
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            EvaluationResult result = _calc.Evaluate("6 - 2");
            Assert.AreEqual(4m, result.Result);
        }

        [TestMethod]
        public void MultipleTwoNumbers()
        { 
            EvaluationResult result = _calc.Evaluate("5 * 100");
            Assert.AreEqual(500m, result.Result);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            EvaluationResult result = _calc.Evaluate("5 / 2");
            Assert.AreEqual(2.5m, result.Result);
        }

        [TestMethod]
        public void CheckErrorMessage()
        {
            EvaluationResult result = _calc.Evaluate("6 + asd");
            Assert.AreEqual("6 + asd is not a valid expression", result.ErrorMessage);
        }

/*        [TestMethod]
        public void CheckOperatorErrorMessage()
        {
            EvaluationResult result = _calc.Evaluate("6 plus 7");
            Assert.AreEqual("plus is not a valid operator", result.ErrorMessage);
        }*/
    }
}
