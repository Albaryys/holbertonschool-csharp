using System;

/// <summary>
/// Provides methods for performing 2D matrix operations.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a 2D matrix by a specified angle.
    /// </summary>
    /// <param name="matrix">The 2D matrix to be rotated.</param>
    /// <param name="angle">The angle of rotation in radians.</param>
    /// <returns>A new 2D matrix representing the result of the rotation.</returns>
    /// <remarks>
    /// The input matrix must be square (number of rows equal to number of columns)
    /// and must have a length of 4 (2x2 matrix) for proper 2D rotation.
    /// If the input matrix does not meet these criteria, a new matrix with a single
    /// element (-1) is returned to indicate an error.
    /// </remarks>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check for the Matrix
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
