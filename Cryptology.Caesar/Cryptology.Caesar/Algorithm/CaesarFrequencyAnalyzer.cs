using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cryptology.Caesar.Algorithm
{
    public class CaesarFrequencyAnalyzer
    {
        #region Constructors
        public CaesarFrequencyAnalyzer()
        {
            this.TextLettersFrequency = new Dictionary<char, uint>();
            this.CryptoTextLettersFrequency = new Dictionary<char, uint>();
        }
        #endregion

        #region Properties
        public Dictionary<char, uint> TextLettersFrequency { get; set; }
        public Dictionary<char, uint> CryptoTextLettersFrequency { get; set; }
        #endregion

        //public string TryEncode(string text)
        //{
        //    var cryptoCountList = this.CryptoTextLettersFrequency.Select(kvp => kvp).OrderByDescending(kvp => kvp.Value).ToList();
        //    var textCountList = this.TextLettersFrequency.Select(kvp => kvp).OrderByDescending(kvp => kvp.Value).ToList();
        //    var sb = new StringBuilder(text);

        //    for (var i = 0; i < Math.Min(cryptoCountList.Count, textCountList.Count); i++)
        //    {
        //        sb = sb.Replace(cryptoCountList[i].Key, textCountList[i].Key);
        //    }
        //    return sb.ToString();
        //}

        public string TryEncode(string text)
        {
            var cryptoCountList = this.CryptoTextLettersFrequency.Select(kvp => kvp).OrderByDescending(kvp => kvp.Value).ToList();
            var textCountList = this.TextLettersFrequency.Select(kvp => kvp).OrderByDescending(kvp => kvp.Value).ToList();
            var sb = new StringBuilder(text.Length);

            foreach (var letter in text)
            {
                if (char.IsLetter(letter) == false)
                {
                    sb.Append(letter);
                    continue;
                }

                var kvp = cryptoCountList.FirstOrDefault(kvp => kvp.Key == letter);
                var l = textCountList[cryptoCountList.IndexOf(kvp)];

                sb.Append(l.Key);
            }

            return sb.ToString();
        }

        public void AnalyzeText(string text)
        {
            this.AnalyzeText(text, TextType.Normal);
        }

        public void AnalyzeCryptoText(string text)
        {
            this.AnalyzeText(text, TextType.Crypto);
        }

        #region Helper Methods
        private void AnalyzeText(string text, TextType textType)
        {
            Dictionary<char, uint> letterFrequency;
            if (textType == TextType.Normal)
            {
                letterFrequency = this.TextLettersFrequency;
            }
            else
            {
                letterFrequency = this.CryptoTextLettersFrequency;
            }

            foreach (var item in text)
            {
                if (char.IsLetter(item) == false)
                {
                    continue;
                }

                if (letterFrequency.ContainsKey(char.ToLower(item)))
                {
                    letterFrequency[char.ToLower(item)]++;
                }
                else
                {
                    letterFrequency[char.ToLower(item)] = 1;
                }
            }
        }
        #endregion

        private enum TextType
        {
            Normal,
            Crypto
        }
    }
}
