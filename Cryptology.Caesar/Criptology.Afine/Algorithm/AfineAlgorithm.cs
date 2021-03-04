using Cryptology.Core.Algorithm;

namespace Criptology.Afine.Algorithm
{
    public class AfineAlgorithm : IAlgorithm
    {
        #region Constructors
        public AfineAlgorithm()
        {
        }
        #endregion

        #region Properties

        #endregion

        public string Decode(byte[] bytes) => throw new System.NotImplementedException();
        public byte[] Encode(string str) => throw new System.NotImplementedException();

        #region Overrides
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
