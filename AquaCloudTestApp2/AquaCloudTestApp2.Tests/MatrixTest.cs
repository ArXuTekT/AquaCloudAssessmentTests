using Microsoft.VisualStudio.TestTools.UnitTesting;
using AquaCloudTestApp2.Classes;
using System;

namespace AquaCloudTestApp2.Tests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TEST_01__BuildMatrix_Is_Not_Throwing_Exceptions_When_Input_Valid()
        {
            "0".BuildMatrix();
            "1".BuildMatrix();
            "0;0".BuildMatrix();
            "0;1".BuildMatrix();
            "1;0".BuildMatrix();
            "1;1".BuildMatrix();
            "0,0".BuildMatrix();
            "0,1".BuildMatrix();
            "1,0".BuildMatrix();
            "1,1".BuildMatrix();
            "0,0;0,0".BuildMatrix();
            "0,0;0,1".BuildMatrix();
            "0,0;1,0".BuildMatrix();
            "0,0;1,1".BuildMatrix();
            "0,1;0,0".BuildMatrix();
            "0,1;0,1".BuildMatrix();
            "0,1;1,0".BuildMatrix();
            "0,1;1,1".BuildMatrix();
            "1,0;0,0".BuildMatrix();
            "1,0;0,1".BuildMatrix();
            "1,0;1,0".BuildMatrix();
            "1,0;1,1".BuildMatrix();
            "1,1;0,0".BuildMatrix();
            "1,1;0,1".BuildMatrix();
            "1,1;1,0".BuildMatrix();
            "1,1;1,1".BuildMatrix();
            "0;0;0".BuildMatrix();
            "0;0;1".BuildMatrix();
            "0;1;0".BuildMatrix();
            "0;1;1".BuildMatrix();
            "1;0;0".BuildMatrix();
            "1;0;1".BuildMatrix();
            "1;1;0".BuildMatrix();
            "1;1;1".BuildMatrix();

            _ = "1,1,1;" +
                "1,1,1;" +
                "0,1,0"
                .BuildMatrix();

            _ = "1,1,1;" +
                "1,0,1;" +
                "1,1,1"
                .BuildMatrix();

            _ = "1,1,1;" +
                "1,0,1;" +
                "1,1,1"
                .BuildMatrix();




            //     1
            _ = "1,1,1,0;" +
                "0,1,0,0"
                .BuildMatrix();


            //      2
            _ = "1,0,1;" +
                "1,1,0"
                .BuildMatrix();


            //      3
            _ = "1,0,1;" +
                "0,1,0"
                .BuildMatrix();




            _ = "1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "0,0,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1;" +
                "1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1"
                .BuildMatrix();

            var matrixString100x100 = "";
        }

        [TestMethod]
        public void TEST_02__BuildMatrix_Is_Throwing_Exception_When_Input_Invalid()
        {

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ",;".BuildMatrix();
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                "0,0,2;".BuildMatrix();
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                "0,0,2;;".BuildMatrix();
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                "0,0,1;1,0;1,1,1".BuildMatrix();
            });
        }

        [TestMethod]
        public void TEST_03__CalculateAreas_Is_Returning_Correct_Values()
        {

            //     1
            var area1 = "1,1,1,0;0,1,0,0"
                .BuildMatrix()
                .CalculateAreas();
            Assert.AreEqual(area1, 1);

            //      2
            var area2 = "1,0,1;1,1,0"
                .BuildMatrix()
                .CalculateAreas();
            Assert.AreEqual(area2, 2);

            //      3
            var area3 = "1,0,1;0,1,0"
                .BuildMatrix()
                .CalculateAreas();
            Assert.AreEqual(area3, 3);

            var stringX =
                "1,0,0,1,1,0,1;" +
                "1,0,1,0,1,0,1;" +
                "1,1,0,0,1,0,1;" +
                "0,1,1,0,1,1,0;" +
                "1,1,0,0,1,0,1;" +
                "1,1,1,1,1,0,1;";
            
        }

        [TestMethod]
        public void TEST_04__END_TO_END_Random_100x100()
        {
            var rnd = new Random();
            var inputMatrixString = "";
            for(var r = 0; r < 99; r++)
            {
                for(var c = 0; c < 99; c++)
                {
                    inputMatrixString += $"{rnd.Next(2)},";
                }
                inputMatrixString += $"{rnd.Next(2)};";
            }
            for (var c = 0; c < 99; c++)
            {
                inputMatrixString += $"{rnd.Next(2)},";
            }
            inputMatrixString += $"{rnd.Next(2)}";

            var boolMatrix = inputMatrixString.BuildMatrix();
            var areaCount = boolMatrix.CalculateAreas();
        }

        //[TestMethod]
        //public void TEST_05__END_TO_END_Only1_100x100()
        //{
        //    var inputMatrixString = "";
        //    for (var r = 0; r < 99; r++)
        //    {
        //        for (var c = 0; c < 99; c++)
        //        {
        //            inputMatrixString += "1,";
        //        }
        //        inputMatrixString += "1;";
        //    }
        //    for (var c = 0; c < 99; c++)
        //    {
        //        inputMatrixString += "1,";
        //    }
        //    inputMatrixString += "1";

        //    var boolMatrix = inputMatrixString.BuildMatrix();
        //    var areaCount = boolMatrix.CalculateAreas();
        //}
    }
}
