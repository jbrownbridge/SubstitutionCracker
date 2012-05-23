using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SubstitutionCracker
{
    public class SubstitutionCipher
    {
        public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 

        public static string GenerateRandomKey()
        {
            Random rand = new Random();
            char [] key = ALPHABET.ToCharArray();
            for (int i = 0; i < key.Length; i++)
            {
                char c = key[i];
                int shuffleIndex = rand.Next(key.Length - i) + i;
                key[i] = key[shuffleIndex];
                key[shuffleIndex] = c;
            }
            return new String(key);
        }
        
        public static string EncryptText(string text, string key)
        {
            string normalizedText = text.Trim().ToUpper();
            string encryptedText = "";
            foreach (char c in normalizedText)
            {
                if (Char.IsLetter(c))
                {
                    encryptedText += key[(int)(c - 'A')];
                }
                else
                {
                    encryptedText += c;
                }
            }
            return encryptedText;
        }

        public static string DecryptText(string text, string key)
        {
            string normalizedText = text.Trim().ToUpper();
            string decryptedText = "";
            Dictionary<char, int> indexInKey = new Dictionary<char, int>();
            for (int i = 0; i < key.Length; i++)
            {
                indexInKey[key[i]] = i;
            }
            foreach (char c in normalizedText)
            {
                if (Char.IsLetter(c))
                {
                    decryptedText += (char)('A' + indexInKey[c]);
                }
                else
                {
                    decryptedText += c;
                }
            }
            return decryptedText;
        }

        public static void DisplayText(string s)
        {
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (i != 0 && i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(words[i] + " ");
            }
        }

        //public static void Main()
        //{
        //    string encryptionKey = GenerateRandomKey();
        //    string plainText = @"Silence in the court! Charles Darnay had yesterday pleaded Not Guilty to an indictment denouncing him (with infinite jingle and jangle) for that he was a false traitor to our serene, illustrious, excellent, and so forth, prince, our Lord the King, by reason of his having, on divers occasions, and by divers means and ways, assisted Lewis, the French King, in his wars against our said serene, illustrious, excellent, and so forth; that was to say, by coming and going, between the dominions of our said serene, illustrious, excellent, and so forth, and those of the said French Lewis, and wickedly, falsely, traitorously, and otherwise evil-adverbiously, revealing to the said French Lewis what forces our said serene, illustrious, excellent, and so forth, had in preparation to send to Canada and North America. This much, Jerry, with his head becoming more and more spiky as the law terms bristled it, made out with huge satisfaction, and so arrived circuitously at the understanding that the aforesaid, and over and over again aforesaid, Charles Darnay, stood there before him upon his trial; that the jury were swearing in; and that Mr. Attorney-General was making ready to speak.".Trim().ToUpper();
        //    Console.WriteLine("Plain Text: ");
        //    DisplayText(plainText);
        //    string encryptedText = EncryptText(plainText, encryptionKey);
        //    Console.WriteLine();
        //    Console.WriteLine("Encrypted Text: ");
        //    DisplayText(encryptedText);
        //    Console.WriteLine();
        //    //Environment environment = new Environment(@"C:\training_text.txt", plainText, encryptedText, 1000, 500, 5, 10, 0.75, 0.70, 5, 0.1);
        //    //Environment environment = new Environment(@"C:\training_text.txt", plainText, encryptedText, 2000, 500, 5, 10, 0.75, 0.70, 5, 0.1);
        //    Environment environment = new Environment(@"C:\training_text.txt", plainText, encryptedText, 1000, 500, 15, 20, 0.75, 0.65, 5, 0.20);
        //    //Environment environment = new Environment(@"C:\training_text.txt", plainText, encryptedText, 1000, 250, 5, 20, 0.75, 0.70, 6, 0.1);
        //    for (int i = 0; i <= environment.NumberOfGenerations; i++)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("Generation: " + i);
        //        Individual best = environment.Population[0];
        //        Console.WriteLine("Best Individual: " + best);
        //        Console.WriteLine("Decrypted Text by Best Individual:");
        //        string decryptedText = DecryptText(encryptedText, environment.Population[0].Chromosone);
        //        DisplayText(decryptedText);
        //        Console.WriteLine();
        //        if (decryptedText == plainText)
        //        {
        //            break;
        //        }
        //        environment.CreateNewGeneration();
        //    }
        //}
    }
}
