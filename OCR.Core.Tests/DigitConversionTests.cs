using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCR.Common;
using OCR.DigitConversion.Core;
using OCR.DigitConversion.Core.Helpers;
using OCR.DigitConversion.Evaluators;
using OCR.InputValidation;
using OCR.InputValidation.Strategies;

namespace OCR.DigitConversion.Tests
{
    [TestClass]
    public class DigitConversionTests
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
        public void Test_GetDigitCount_CorrectFormat_Test1()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = 'I'; digitLine[1][5] = '_'; digitLine[1][6] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; digitLine[2][3] = ' '; digitLine[2][4] = 'I'; digitLine[2][5] = '_'; digitLine[2][6] = 'I';
            int digitCount = DigitConversionHelper.GetDigitCount(digitLine);
            Assert.AreEqual(2, digitCount);
        }
        [TestMethod]
        public void Test_GetDigitCount_CorrectFormat_Test2()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = 'I'; digitLine[1][5] = '_'; digitLine[1][6] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; digitLine[2][3] = 'I'; digitLine[2][4] = 'I'; digitLine[2][5] = '_'; digitLine[2][6] = 'I';
            int digitCount = DigitConversionHelper.GetDigitCount(digitLine);
            Assert.AreEqual(2, digitCount);
        }
        
        [TestMethod]
        public void Test_GetDigitCount_InCorrectFormat_Test1()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(2, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = 'I'; digitLine[1][5] = '_'; digitLine[1][6] = 'I';
            Assert.ThrowsException<IndexOutOfRangeException>(() => DigitConversionHelper.GetDigitCount(digitLine));
        }

       
    }
}
