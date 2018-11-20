namespace OCR.Core
{
    public class Helper
    {
        public static T[][] CreateJaggedArray<T>(int rows, int cols)
        {
            var matrix = new T[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new T[cols];
            }
            return matrix;
        }
    }
}
