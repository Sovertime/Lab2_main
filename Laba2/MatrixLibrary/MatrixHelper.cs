namespace Laba2.MatrixLibrary;

public static class MatrixHelper
{
    public static int GetMainDiagonalSum(int[,] matrix)
    {
        int sum = 0;

        int limit = Math.Min(
            matrix.GetLength(0),
            matrix.GetLength(1));

        for (int i = 0; i < limit; i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }

    public static int GetSecondaryDiagonalSum(int[,] matrix)
    {
        int sum = 0;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int limit = Math.Min(rows, cols);

        for (int i = 0; i < limit; i++)
        {
            sum += matrix[i, cols - 1 - i];
        }

        return sum;
    }
}