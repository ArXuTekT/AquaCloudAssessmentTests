using System;
using System.Linq;

namespace AquaCloudTestApp2.Classes
{
    public static class MatrixHelper
    {
        /// <summary>
        ///     Builds <see cref='BoolMatrix'/> from input <paramref name="matrixString"/>.
        ///     The matrix is presented as a string value where ‘,’ is used as a separator for columns,
        ///     ‘;’ is used as a separator for rows.
        ///     <example>For example:
        ///         “1,0,1;0,1,0” string value will be converted to the matrix [[1,0,1], [0,1,0]].
        ///     </example>
        /// </summary>
        /// <param name="matrixString" cref="string">
        ///     <see cref="string"/> of <see cref="bool"/> values, representing a <see cref="BoolMatrix"/>.
        /// </param>
        /// <returns>
        ///     <see cref="BoolMatrix"/> created from <paramref name="matrixString"/>.
        /// </returns>
        public static BoolMatrix BuildMatrix(this string matrixString)
        {
            var rowStringArray = matrixString.Split(';', System.StringSplitOptions.None);
            var rowCount = rowStringArray.Length;
            // We suppose that matrix input format is correct, so colums count in every row is the same
            var columnCount = rowStringArray[0].Length;

            // Validate input string
            for(var rowIndex=1; rowIndex< rowStringArray.Length; rowIndex++)
            {
                // Check if every input row contains the same column values count
                if (rowStringArray[rowIndex].Length != columnCount)
                    throw new ArgumentException("Input string is not representing a valid matrix or is in invalid format.");
            }

            // Convert to bool values and fill bool array buffer
            var cellArray = new bool[rowCount][];
            for (var rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                cellArray[rowIndex] = rowStringArray[rowIndex].Split(',', StringSplitOptions.None)
                    .Select(ch =>
                    {
                        switch (ch)
                        {
                            case "0":
                                return false;
                            case "1":
                                return true;
                            default:
                                throw new ArgumentException("Input string contains cell value that differ from `0` or `1`");
                        }

                    }).ToArray();
            }

            // Construct BoolMatrix
            var resultMatrix = new BoolMatrix(cellArray);

            return resultMatrix;
        }

        public static int CalculateAreas(this BoolMatrix matrix)
        {
            // Create matrix that indicates cell fill status
            // same size with BoolMatrix
            var fillMatrix = new bool[matrix.RowCount][];
            for (var rowIndex = 0; rowIndex < matrix.RowCount; rowIndex++)
                fillMatrix[rowIndex] = new bool[matrix.ColumCount];

            // go through all cells and drop filling points
            // if cell is not 0 and is not already filled
            // result count of drops will be equal to area count
            var areaCount = 0;
            for(var rowIndex=0; rowIndex < matrix.RowCount; rowIndex++)
            {
                for(var cellIndex=0; cellIndex < matrix.ColumCount; cellIndex++)
                {
                    if(matrix.Cells[rowIndex][cellIndex] && !fillMatrix[rowIndex][cellIndex])
                    {
                        FillSolidArea(matrix, fillMatrix, rowIndex, cellIndex);
                        areaCount++;
                    }
                }
            }

            return areaCount;
        }

        private static void FillSolidArea(in BoolMatrix matrix, bool[][] fillMatrix, int rowIndex, int columnIndex)
        {
            var connectedCells = GetConnectedCellDirections(matrix, rowIndex, columnIndex);
            fillMatrix[rowIndex][columnIndex] = true;

            if (connectedCells.HasFlag(EDirections.Top) && !fillMatrix[rowIndex - 1][columnIndex])
                FillSolidArea(matrix, fillMatrix, rowIndex - 1, columnIndex);

            if (connectedCells.HasFlag(EDirections.Bottom) && !fillMatrix[rowIndex + 1][columnIndex])
                FillSolidArea(matrix, fillMatrix, rowIndex + 1, columnIndex);

            if (connectedCells.HasFlag(EDirections.Right) && !fillMatrix[rowIndex][columnIndex+1])
                FillSolidArea(matrix, fillMatrix, rowIndex, columnIndex + 1);

            if (connectedCells.HasFlag(EDirections.Left) && !fillMatrix[rowIndex][columnIndex-1])
                FillSolidArea(matrix, fillMatrix, rowIndex, columnIndex - 1);
        }

        private static EDirections GetConnectedCellDirections(this BoolMatrix matrix, int rowIndex, int columnIndex)
        {
            var dirConnected = EDirections.Top | EDirections.Bottom | EDirections.Left | EDirections.Right;
            
            // check top
            if (rowIndex == 0 || !matrix.Cells[rowIndex - 1][columnIndex])
                dirConnected &= ~EDirections.Top;

            // check bottom
            if (rowIndex == matrix.RowCount - 1 || !matrix.Cells[rowIndex + 1][columnIndex])
                dirConnected &= ~EDirections.Bottom;

            // check left
            if (columnIndex == 0 || !matrix.Cells[rowIndex][columnIndex - 1])
                dirConnected &= ~EDirections.Left;

            //check right
            if (columnIndex == matrix.ColumCount - 1 || !matrix.Cells[rowIndex][columnIndex + 1])
                dirConnected &= ~EDirections.Right;

            return dirConnected;
        }
    }
}
