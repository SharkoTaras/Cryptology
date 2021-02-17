using System.Runtime.CompilerServices;
using Cryptology.Caesar.Algorithm;
using Cryptology.Core.Extensions;

namespace Cryptology.UI
{
    internal class CaesarViewModel : ViewModelBase
    {
        private int shift;
        private string inputText;
        private string outputText;
        private bool isEncode;
        private string actionText;

        #region Constructor
        public CaesarViewModel()
        {
            this.Algorithm = new CaesarAlgorithm();
            this.IsEncode = true;
            this.Shift = default;
        }
        #endregion

        #region Properties
        public CaesarAlgorithm Algorithm { get; }

        public string ActionText
        {
            get
            {
                return this.actionText;
            }

            set
            {
                if (this.actionText != value)
                {
                    this.actionText = value;
                    this.OnProtertyChanged();
                }
            }
        }

        public bool IsEncode
        {
            get
            {
                return this.isEncode;
            }

            set
            {
                if (this.isEncode != value)
                {
                    this.isEncode = value;
                    this.OnProtertyChanged();
                    if (this.isEncode)
                    {
                        this.ActionText = "Encode";
                    }
                    else
                    {
                        this.ActionText = "Decode";
                    }
                }
            }
        }

        public int Shift
        {
            get
            {
                return this.shift;
            }
            set
            {
                if (this.shift != value)
                {
                    this.shift = value;
                    this.Algorithm.Shift = value;
                    this.OnProtertyChanged();
                }
            }
        }

        public string InputText
        {
            get
            {
                return this.inputText;
            }
            set
            {
                if (this.inputText != value)
                {
                    this.inputText = value;
                    this.OnProtertyChanged();
                }
            }
        }

        public string OutputText
        {
            get
            {
                return this.outputText;
            }
            set
            {
                if (this.outputText != value)
                {
                    this.outputText = value;
                    this.OnProtertyChanged();
                }
            }
        }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Process()
        {
            if (this.IsEncode)
            {
                this.OutputText = this.Algorithm.Encode(this.InputText).FromBytes();
            }
            else
            {
                this.OutputText = this.Algorithm.Decode(this.InputText.ToBytes());
            }
        }
    }
}
