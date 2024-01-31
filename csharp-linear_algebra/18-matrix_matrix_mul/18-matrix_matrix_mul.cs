using System;

public class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if matrices can be multiplied
        if (cols1 != rows2)
        {
            Console.WriteLine("Matrices cannot be multiplied.");
            return new double[,] { { -1 } }; // Return a matrix containing -1
        }

        // Create the result matrix
        double[,] result = new double[rows1, cols2];

        // Perform matrix multiplication
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }
}
