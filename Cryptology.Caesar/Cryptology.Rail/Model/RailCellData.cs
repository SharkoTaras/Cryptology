namespace Cryptology.Rail.Model
{
    public class RailCellData
    {
        #region Constructors
        public RailCellData()
        {
        }
        #endregion

        #region Properties
        public char Letter { get; set; }

        public uint RailNumber { get; set; }

        public uint NumberInText { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
