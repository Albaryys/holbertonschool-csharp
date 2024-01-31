using System;

class MartrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int len1 = matrix.GetLength(1);
        double[,] mat = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        if (len1 == 2 || len1 == 3) {
            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    mat[i,j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1)) {
                        mat[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
                }
            }
            return mat;
        }
        return -1;
    }
}
