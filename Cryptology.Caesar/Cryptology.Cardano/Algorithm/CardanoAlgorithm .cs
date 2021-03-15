using Cryptology.Core.Algorithm;

namespace Cryptology.Cardano
{
    public class CardanoAlgorithm : IAlgorithm
    {
        #region Constructors
        public CardanoAlgorithm()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region IAlgorithm
        public string Decode(byte[] bytes)
        {
            throw new System.NotImplementedException();
        }

        public byte[] Encode(string str)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
