using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCR.Common;
using OCR.InputValidation.Strategies;

namespace OCR.InputValidation.Tests
{
    [TestClass]
    public class InputValidationTests
    {

        [TestMethod]
        public void Test_Validation_Correct_Test1()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 3);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; 
            digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = 'I'; 
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; 

            IValidationStrategy characterSpacingValidation = new CharacterSpacingValidation();
            bool isFirstLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[0]);
            bool isSecondLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[1]);
            bool isThirdLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[2]);

            Assert.IsTrue(isFirstLineValidateInput);
            Assert.IsTrue(isSecondLineValidateInput);
            Assert.IsTrue(isThirdLineValidateInput);
        }
        [TestMethod]
        public void Test_Validation_Incorrect_Test1()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = 'I'; digitLine[1][5] = '_'; digitLine[1][6] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; digitLine[2][3] = 'I'; digitLine[2][4] = 'I'; digitLine[2][5] = '_'; digitLine[2][6] = 'I';
            
            IValidationStrategy characterSpacingValidation = new CharacterSpacingValidation();
            bool isFirstLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[0]);
            bool isSecondLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[1]);
            bool isThirdLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[2]);

            Assert.IsTrue(isFirstLineValidateInput);
            Assert.IsTrue(isSecondLineValidateInput);
            Assert.IsFalse(isThirdLineValidateInput);
        }

        [TestMethod]
        public void Test_Validation_Incorrect_Test3()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 4);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; 
            digitLine[1][0] = 'I'; digitLine[1][1] = '_'; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; 
            digitLine[2][0] = ' '; digitLine[2][1] = ' '; digitLine[2][2] = 'I'; digitLine[2][3] = ' '; 

            IValidationStrategy characterSpacingValidation = new CharacterSpacingValidation();
            bool isFirstLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[0]);
            bool isSecondLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[1]);
            bool isThirdLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[2]);

            Assert.IsTrue(isFirstLineValidateInput);
            Assert.IsTrue(isSecondLineValidateInput);
            Assert.IsTrue( isThirdLineValidateInput);
        }

        [TestMethod]
        public void Test_Validation_Incorrect_Test2()
        {
            var digitLine = CommonHelper.CreateJaggedArray<char>(3, 7);
            digitLine[0][0] = ' '; digitLine[0][1] = ' '; digitLine[0][2] = ' '; digitLine[0][3] = ' '; digitLine[0][4] = ' '; digitLine[0][5] = '_'; digitLine[0][6] = ' ';
            digitLine[1][0] = ' '; digitLine[1][1] = ' '; digitLine[1][2] = 'I'; digitLine[1][3] = ' '; digitLine[1][4] = 'I'; digitLine[1][5] = '_'; digitLine[1][6] = 'I';
            digitLine[2][0] = ' '; digitLine[2][1] = 's'; digitLine[2][2] = 'I'; digitLine[2][3] = ' '; digitLine[2][4] = 'I'; digitLine[2][5] = '_'; digitLine[2][6] = 'I';
         
            IValidationStrategy characterSpacingValidation = new CharacterSpacingValidation();
            bool isFirstLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[0]);
            bool isSecondLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[1]);
            bool isThirdLineValidateInput = characterSpacingValidation.ValidateInput(digitLine[2]);

            Assert.IsTrue(isFirstLineValidateInput);
            Assert.IsTrue(isSecondLineValidateInput);
            Assert.IsFalse(isThirdLineValidateInput);
        }
    }
}
