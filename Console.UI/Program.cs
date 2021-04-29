using System;
using System.Diagnostics;
using System.Numerics;
using Criptology.Afine.Algorithm;
using Cryptology.Algorithm.DiffieHellman.Algorithm;
using Cryptology.Caesar.Algorithm;
using Cryptology.Cardano;
using Cryptology.Core;
using Cryptology.Core.Algorithm;
using Cryptology.Rail.Algorithm;
using Cryptology.Rsa.Algorithm;
using Cryptology.Vijender.Algorithm;
using Unity;

namespace Cryptology.ConsoleUI
{
    public class Program
    {
        private static IUnityContainer container;

        private static void ConfigureContainer()
        {
            container = new UnityContainer();
            container.RegisterFactory<IAlgorithm>(GlobalConstants.Algorithms.Affine, (c) => new AffineAlgorithm(3, 5));
            container.RegisterFactory<IAlgorithm>(GlobalConstants.Algorithms.Caesar, (c) => new CaesarAlgorithm(3));
            container.RegisterFactory<IAlgorithm>(GlobalConstants.Algorithms.Cardano, (c) => new CardanoAlgorithm("2508"));
            container.RegisterFactory<IAlgorithm>(GlobalConstants.Algorithms.Rail, (c) => new RailAlgorithm(3));
            container.RegisterFactory<IAlgorithm>(GlobalConstants.Algorithms.Rsa, (c) => new RsaAlgorithm(11, 7));
            container.RegisterFactory<IAlgorithm>(GlobalConstants.Algorithms.Vijender, (c) => new VijenderAlgorithm("ab"));
            container.RegisterFactory<IAlgorithm>(GlobalConstants.Algorithms.ElGamal, (c) => new ElGamalAlgorithm());
        }

        private static void Main(string[] args)
        {
            DiffieHellmanAlgorithm();
            return;
            ConfigureContainer();
            IAlgorithm alg;
            try
            {
                alg = container.Resolve<IAlgorithm>(GlobalConstants.Algorithms.Rsa);
                var code = alg.Encode("hello how are you");

                Console.WriteLine(code);

                var text = alg.Decode(code);

                Console.WriteLine(text);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void DiffieHellmanAlgorithm()
        {
            var prime = BigInteger.Parse("23");
            var algorithm = new DiffieHellmanAlgorithm(prime);
            var random = new Random();

            var aliceSecret = random.Next(1, 100);
            var aliceMessage = algorithm.ModPow(aliceSecret, prime);
            var bobSecret = random.Next(1, 100);
            var bobMessage = algorithm.ModPow(bobSecret, prime);
            var aliceCheck = BigInteger.ModPow(bobMessage, aliceSecret, prime);
            var bobCheck = BigInteger.ModPow(aliceMessage, bobSecret, prime);
            Console.WriteLine(aliceCheck);
            Console.WriteLine(bobCheck);

        }

        private static void RailAlgorithmTimeTest()
        {
            var text = new string('a', 10000);
            var sw = Stopwatch.StartNew();
            var alg = new RailAlgorithm(3);
            Console.WriteLine("Encode");
            for (var i = 0; i < 500; i++)
            {
                alg.Encode(text);
            }
            sw.Stop();
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000f} s");
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds * 10e6f} ns");
            Console.WriteLine("Decode");
            sw = Stopwatch.StartNew();
            for (var i = 0; i < 500; i++)
            {
                alg.Decode(text);
            }
            sw.Stop();
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000f} s");
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds * 10e6f} ns");


            var h = alg.Encode("hello");
            Console.WriteLine(h);

            var hh = alg.Decode(h);

            Console.WriteLine(hh);
        }
    }
}
