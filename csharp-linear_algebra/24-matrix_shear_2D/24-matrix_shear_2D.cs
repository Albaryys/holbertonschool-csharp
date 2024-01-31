using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] shearMat = { { 1, 0 }, { 0, 1 } };
        double[,] shearedMat = new double[2, 2];
        int numLines = matrix.GetLength(0);

        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        if (matrix.Length != 4 || matrix.GetLength(0) != 2)
            return new double[,] { { -1 } };

        if (direction == 'x')
            shearMat[0, 1] = factor;
        else
            shearMat[1, 0] = factor;

        for (int i = 0; i < numLines; i++)
        {
            shearedMat[i, 0] = shearMat[0, 0] * matrix[i, 0] + shearMat[0, 1] * matrix[i, 1];
            shearedMat[i, 1] = shearMat[1, 0] * matrix[i, 0] + shearMat[1, 1] * matrix[i, 1];
        }

        return shearedMat;
    }
}