using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SubstitutionCracker
{
    public class Individual
    {
        public const double FITNESS_LOGARITHM_BASE = 2.0;
               
        public Individual(NGramFrequencies nGramFrequencies, string encryptedText, string chromosone)
        {
            this.chromosone = chromosone;
            this.fitness = CalculateFitness(nGramFrequencies, encryptedText, chromosone);
        }              

        private double CalculateFitness(NGramFrequencies nGramFrequencies, string encryptedText, string chromosone)
        {
            double currentFitness = 0;
            string decryptedText = SubstitutionCipher.DecryptText(encryptedText, chromosone);
            MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(decryptedText));
            NGramFrequencies decryptedTextFrequencies = NGramFrequencies.Analyse(new StreamReader(stream), nGramFrequencies.Length);
            foreach (string ngram in decryptedTextFrequencies)
            {
                double trainedFrequency = nGramFrequencies.FrequencyOf(ngram);
                if (trainedFrequency != 0)
                {
                    currentFitness += decryptedTextFrequencies.FrequencyOf(ngram) * Math.Log(trainedFrequency, FITNESS_LOGARITHM_BASE);
                }
            }
            return currentFitness;
        }

        public string Chromosone
        {
            get
            {
                return chromosone;
            }            
        }
        private string chromosone;

        public double Fitness
        {
            get
            {
                return fitness;
            }
        }
        private double fitness;

        public override string ToString()
        {
            return Chromosone + ": " + Fitness.ToString();
        }
    }
}
