using EncryptionAndDecrption.RSARepository;
using System;

namespace EncryptionAndDecrption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RSAEncrytion rsa = new RSAEncrytion();
            string cypher = string.Empty;

            Console.WriteLine($"Public Key = {rsa.GetPublicKey()} \n");

            Console.WriteLine("Enter your text to encrypt");
            var text = Console.ReadLine();
            if(!string.IsNullOrEmpty(text))
            {
                cypher = rsa.Encrypt(text);
                Console.WriteLine($"Encrypted Text = {cypher}");
            }

            Console.WriteLine("Press any key to decrypt text");
            Console.ReadLine();

            var plainText = rsa.Decrypt(cypher);
            Console.WriteLine($"Decrypted Text = {plainText}");
        }
    }
}
