using Cryptology.Cardano.Extensions;
using Extreme.Mathematics;
using Extreme.Mathematics.LinearAlgebra;

namespace Cryptology.Cardano.Models
{
    public class CardanoMatrix
    {
        private DenseMatrix<uint> matrix;

        public CardanoMatrix(uint rows, uint columns)
        {
            matrix = Matrix.Create<uint>((int)rows, (int)columns);
        }

        public uint this[uint row, uint column]
        {
            get => matrix[(int)row, (int)column];
            set => matrix[(int)row, (int)column] = value;
        }

        public void Rotate()
        {
            matrix.Rotate();
        }
    }
}
