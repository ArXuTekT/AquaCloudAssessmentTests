namespace AquaCloudTestApp2.Classes
{
    public struct BoolMatrix
    {
        public readonly bool[][] Cells;
        public readonly int RowCount;
        public readonly int ColumCount;
        internal BoolMatrix(bool[][] matrixValues)
        {
            Cells = matrixValues;
            RowCount = matrixValues.Length;
            ColumCount = matrixValues[0].Length;
        }
    }
}
