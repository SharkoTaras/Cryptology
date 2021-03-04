using System;
using System.IO;
using System.Linq;
using Cryptology.Caesar.Algorithm;
using Cryptology.Core.Extensions;

namespace Cryptology.ConsoleUI
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var str = "Hello world";
            Console.WriteLine(str.Replace("Hello", string.Empty));
            //Algorithm();
            //FrequencyAnalysis();
        }

        private static void Algorithm()
        {
            Console.Write("Enter shift> ");
            var shift = Convert.ToInt32(Console.ReadLine());
            var alg = new CaesarAlgorithm(shift);
            Console.Write("Enter text> ");
            var text = Console.ReadLine();
            var code = alg.Encode(text);
            Console.WriteLine("Encoded text:");
            Console.WriteLine(code.FromBytes());
            Console.ReadLine();
        }

        private static void FrequencyAnalysis()
        {
            var text = "The pigs were insulted that they were named hamburgers.He drank life before spitting it out.Having no hair made him look even hairier.Swim at your own risk was taken as a challenge for the group of Kansas City college students.The sun had set and so had his dreams.She was disgusted he couldn’t tell the difference between lemonade and limeade.Traveling became almost extinct during the pandemic.It caught him off guard that space smelled of seared steak.He had a hidden stash underneath the floorboards in the back room of the house.One small action would change her life, but whether it would be for better or for worse was yet to be determined.He decided that the time had come to be stronger than any of the excuses he'd used until then.People generally approve of dogs eating cat food but not cats eating dog food.";
            var toCrypto = "He watched the dancing piglets with panda bear tummies in the swimming pool.";
            //var toCrypto = "hello how are you";
            var fileText = File.ReadAllText("text.txt");

            var analyzer = new CaesarFrequencyAnalyzer();
            var alg = new CaesarAlgorithm(3);

            var code = alg.Encode(text).FromBytes();
            analyzer.AnalyzeText(fileText);
            analyzer.AnalyzeCryptoText(code);

            var result = analyzer.TryEncode(code);
            using (var dict = new StreamWriter("dict.txt"))
            {
                foreach (var item in analyzer.TextLettersFrequency.OrderByDescending(kvp => kvp.Value))
                {
                    dict.WriteLine($"{item.Key} - {item.Value}");
                    System.Console.WriteLine($"{item.Key} - {item.Value}");
                }
                System.Console.WriteLine(new string('-', 30));
                dict.WriteLine(new string('-', 30));
                foreach (var item in analyzer.CryptoTextLettersFrequency.OrderByDescending(kvp => kvp.Value))
                {
                    dict.WriteLine($"{item.Key} - {item.Value}");
                    System.Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }

            File.WriteAllText("result.txt", result);
            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }
    }
}
