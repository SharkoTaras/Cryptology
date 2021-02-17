using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using Cryptology.Caesar.Algorithm;
using Cryptology.Core;
using Cryptology.Core.Extensions;

namespace Cryptology.UI
{
    internal class CaesarViewModel : ViewModelBase
    {
        private int shift;
        private string inputText;
        private string outputText;
        private string actionText;
        private bool isEncode;
        private bool isAnalyzingCompleted;
        private Visibility analyzeButtonVisibility;
        private Visibility detailsButtonVisibility;

        #region Constructor
        public CaesarViewModel()
        {
            this.Algorithm = new CaesarAlgorithm();
            this.Analyzer = new CaesarFrequencyAnalyzer();
            this.IsEncode = true;
            this.Shift = default;
            this.TextAnalyzingPerformed = false;
            this.IsAnalyzingCompleted = false;
            this.DetailsButtonVisibility = Visibility.Collapsed;
        }
        #endregion

        #region Properties
        public CaesarAlgorithm Algorithm { get; }

        public CaesarFrequencyAnalyzer Analyzer { get; set; }

        public bool TextAnalyzingPerformed { get; set; }

        public bool IsAnalyzingCompleted
        {
            get
            {
                return this.isAnalyzingCompleted;
            }
            set
            {
                if (this.isAnalyzingCompleted != value)
                {
                    this.isAnalyzingCompleted = value;
                    this.OnProtertyChanged();

                    if (this.isAnalyzingCompleted)
                    {
                        this.DetailsButtonVisibility = Visibility.Visible;
                    }
                    else
                    {
                        this.DetailsButtonVisibility = Visibility.Collapsed;
                    }
                }
            }
        }

        public Visibility DetailsButtonVisibility
        {
            get
            {
                return this.detailsButtonVisibility;
            }
            set
            {
                if (this.detailsButtonVisibility != value)
                {
                    this.detailsButtonVisibility = value;
                    this.OnProtertyChanged();
                }
            }
        }

        public Visibility AnalyzeButtonVisibility
        {
            get
            {
                return this.analyzeButtonVisibility;
            }
            set
            {
                if (this.analyzeButtonVisibility != value)
                {
                    this.analyzeButtonVisibility = value;
                    this.OnProtertyChanged();
                }
            }
        }

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
                        this.AnalyzeButtonVisibility = Visibility.Collapsed;
                    }
                    else
                    {
                        this.ActionText = "Decode";
                        this.AnalyzeButtonVisibility = Visibility.Visible;
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Analyze()
        {
            try
            {
                if (this.TextAnalyzingPerformed == false)
                {
                    using (var reader = new StreamReader(GlobalConstants.TextFilePath, this.Algorithm.Encoding))
                    {
                        var text = reader.ReadToEnd();
                        this.Analyzer.AnalyzeText(text);
                    }

                    this.TextAnalyzingPerformed = true;
                }

                this.Analyzer.AnalyzeCryptoText(this.InputText);
                this.IsAnalyzingCompleted = true;

                this.OutputText = this.Analyzer.TryEncode(this.InputText);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
