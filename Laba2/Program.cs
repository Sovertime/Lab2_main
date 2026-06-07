using Laba2;
using Laba2.MatrixLibrary;

int[,] matrix = Matrix.InputMatrix();

Console.WriteLine("\nВведенная матрица:");
Matrix.PrintMatrix(matrix);

int mainSum = MatrixHelper.GetMainDiagonalSum(matrix);
int secondarySum = MatrixHelper.GetSecondaryDiagonalSum(matrix);

Console.WriteLine($"\nСумма главной диагонали: {mainSum}");
Console.WriteLine($"Сумма побочной диагонали: {secondarySum}");

Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();