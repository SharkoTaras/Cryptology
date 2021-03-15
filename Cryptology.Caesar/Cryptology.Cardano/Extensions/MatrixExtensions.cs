using Extreme.Mathematics.LinearAlgebra;

namespace Cryptology.Cardano.Extensions
{
    internal static class MatrixExtensions
    {
        public static void Rotate<T>(this DenseMatrix<T> matrix)
        {
            var n = matrix.ColumnCount;
            for (var x = 0; x < n / 2; x++)
            {
                for (var y = x; y < n - x - 1; y++)
                {
                    var temp = matrix[x, y];

                    matrix[x, y] = matrix[y, n - 1 - x];

                    matrix[y, n - 1 - x] = matrix[n - 1 - x, n - 1 - y];

                    matrix[n - 1 - x, n - 1 - y] = matrix[n - 1 - y, x];

                    matrix[n - 1 - y, x] = temp;
                }
            }
        }
    }
}