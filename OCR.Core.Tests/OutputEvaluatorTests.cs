using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCR.Common;
using OCR.DigitConversion.Core;
using OCR.DigitConversion.Evaluators;

namespace OCR.DigitConversion.Tests
{
    [TestClass]
    public class OutputEvaluatorTests
    {
            [TestMethod]
            public void Test_Evaluator_Verify_Incorrect()
            {
                var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
                digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' ';
                digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = ' ';
                digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = ' ';

                IOutputEvaluator outputEvaluator = new OutputEvaluator();
                bool isVerified = outputEvaluator.VerifyInput(digitLine);
                Assert.IsFalse(isVerified);
            }

            [TestMethod]
            public void Test_Evaluator_Verify_Correct()
            {
                var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
                digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
                digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = ' ';
                digitLine[2][0] = ' '; digitLine[2][1] = '_'; digitLine[2][2] = 'I';

                IOutputEvaluator outputEvaluator = new OutputEvaluator();
                bool isVerified = outputEvaluator.VerifyInput(digitLine);
                Assert.IsTrue(isVerified);
            }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Five()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = ' ';
            digitLine[2][0] = ' '; digitLine[2][1] = '_'; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('5',output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Two()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = '_'; digitLine[1][2] = 'I';
            digitLine[2][0] = 'I'; digitLine[2][1] = '_'; digitLine[2][2] = ' ';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('2', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Eight()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = 'I';
            digitLine[2][0] = 'I'; digitLine[2][1] = '_'; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('8', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Six()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = ' ';
            digitLine[2][0] = 'I'; digitLine[2][1] = '_'; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('6', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Nine()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = '_'; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('9', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Zero()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = 'I'; digitLine[1][1] = ' '; digitLine[1][2] = 'I';
            digitLine[2][0] = 'I'; digitLine[2][1] = '_'; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('0', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Three()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = '_'; digitLine[1][2] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = '_'; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('3', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_One()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('1', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Four()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' ';
            digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('4', output);
        }
        [TestMethod]
        public void Test_Evaluator_Evaluate_Seven()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I';

            IOutputEvaluator outputEvaluator = new OutputEvaluator();
            char output = outputEvaluator.Evaluate(digitLine);
            Assert.AreEqual('7', output);
        }
    }
}
