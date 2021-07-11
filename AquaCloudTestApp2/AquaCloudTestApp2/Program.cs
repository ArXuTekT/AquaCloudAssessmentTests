using AquaCloudTestApp2.Classes;

using System;

namespace AquaCloudTestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStringMatrix = args[0];
                //"1,0,0,1,1,0,1;" +
                //"1,0,1,0,1,0,1;" +
                //"1,1,0,0,1,0,1;" +
                //"0,1,1,0,1,1,0;" +
                //"1,1,0,0,1,0,1;" +
                //"1,1,1,1,1,0,1";
            var matrix = MatrixHelper.BuildMatrix(inputStringMatrix);
            Console.WriteLine(matrix.CalculateAreas());
        }
    }
}
