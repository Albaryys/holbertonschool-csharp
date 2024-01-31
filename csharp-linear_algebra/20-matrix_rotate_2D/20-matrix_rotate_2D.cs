using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Vérifier si la matrice est carrée
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        if (matrix.Length != 4)
            return new double[,] { { -1 } };

        double[,] rotatedMatrix = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            rotatedMatrix[i, 0] = Math.Round(matrix[i, 0] * Math.Cos(angle) - matrix[i, 1] * Math.Sin(angle), 2);
            rotatedMatrix[i, 1] = Math.Round(matrix[i, 0] * Math.Sin(angle) + matrix[i, 1] * Math.Cos(angle), 2);
        }

        return rotatedMatrix;
    }
}