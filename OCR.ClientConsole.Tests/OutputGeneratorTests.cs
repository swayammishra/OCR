using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCR.Common;

namespace OCR.ClientConsole.Tests
{
    [TestClass]
    public class OutputGeneratorTests
    {
        [TestMethod]
        public void Test_GeneratedOutput_AsExpected()
        {
            var digitLines = new List<char[][]>();
            digitLines.Add(InitializeDigitLine18());
            digitLines.Add(InitializeDigitLine13());
            digitLines.Add(InitializeDigitLine75());
            OutputGenerator outputGenerator = new OutputGenerator();
            IList<string> digitOutputs = outputGenerator.GenerateOutput(digitLines);
            Assert.AreEqual("18", digitOutputs[0]);
            Assert.AreEqual("13", digitOutputs[1]);
            Assert.AreEqual("75", digitOutputs[2]);
        }
        private char[][] InitializeDigitLine18()
        {
            char[][] digitLine = CommonHelper.CreateJaggedArray<char>(3, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = 'I'; digitLine[1][5] = '_'; digitLine[1][6] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; digitLine[2][3] = ' '; digitLine[2][4] = 'I'; digitLine[2][5] = '_'; digitLine[2][6] = 'I';
            return digitLine;
        }
        private char[][] InitializeDigitLine13()
        {
            char[][] digitLine = CommonHelper.CreateJaggedArray<char>(3, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = ' '; digitLine[1][5] = '_'; digitLine[1][6] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; digitLine[2][3] = ' '; digitLine[2][4] = ' '; digitLine[2][5] = '_'; digitLine[2][6] = 'I';
            return digitLine;
        }
        private char[][] InitializeDigitLine75()
        {
            char[][] digitLine = CommonHelper.CreateJaggedArray<char>(3, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = '_'; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = 'I'; digitLine[1][5] = '_'; digitLine[1][6] = ' ';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; digitLine[2][3] = ' '; digitLine[2][4] = ' '; digitLine[2][5] = '_'; digitLine[2][6] = 'I';
            return digitLine;
        }
    }
}
