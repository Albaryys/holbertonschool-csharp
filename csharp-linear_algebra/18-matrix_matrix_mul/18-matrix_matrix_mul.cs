using System;

///<summary>Defines matrix calculation methods.</summary>
class MatrixMath
{
    ///<summary>Multiplies two matrices.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        //Check if matrices can be multiplied
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };
        
        double[,] resultMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;

                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return resultMatrix;
    }
}