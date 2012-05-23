using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.IO;

namespace SubstitutionCracker
{
    public class Environment
    {
        public const int NGRAM_LENGTH = 3;
        public const bool SEED_POPULATION = true;

        public Environment(string trainingFilePath, string plainText, string encryptedText,
            int numberOfGenerations, int populationSize,            
            double percentageOfElitism, int tournamentSize,
            double tournamentWinnerProbability, double probabilityOfCrossover,
            int numberOfCrossoverPoints, double probabilityOfMutation)
        {
            this.nGramFrequencies = NGramFrequencies.Analyse(new StreamReader(trainingFilePath), NGRAM_LENGTH);
            this.trainedLetterFrequencies = LetterFrequencies.Analyse(new StreamReader(trainingFilePath));
            this.cipherLetterFrequencies = LetterFrequencies.Analyse(new StreamReader(new MemoryStream(ASCIIEncoding.Default.GetBytes(encryptedText))));
            this.randomNumberGenerator = new Random(1337);
            this.decryptedText = plainText.Trim().ToUpper();
            this.encryptedText = encryptedText.Trim().ToUpper();
            this.numberOfGenerations = numberOfGenerations;
            this.populationSize = populationSize;
            this.percentageOfElitism = percentageOfElitism;
            this.tournamentSize = tournamentSize;
            this.tournamentWinnerProbability = tournamentWinnerProbability;
            this.probabilityOfCrossover = probabilityOfCrossover;
            this.numberOfCrossoverPoints = numberOfCrossoverPoints;
            this.probabilityOfMutation = probabilityOfMutation;
            this.population = new List<Individual>();
            this.currentGeneration = 0;
            CreateInitialPopulation();
        }

        #region Genetic Algorithm Parameters

        public int NumberOfGenerations
        {
            get { return numberOfGenerations; }
        }
        private int numberOfGenerations;

        public int PopulationSize
        {
            get { return populationSize; }
        }
        private int populationSize;
                
        public double PercentageOfElitism
        {
            get { return percentageOfElitism; }
        }
        private double percentageOfElitism;
        
        public int TournamentSize
        {
            get { return tournamentSize; }
        }
        private int tournamentSize;

        public double TournamentWinnerProbability
        {
            get { return tournamentWinnerProbability;  }
        }
        private double tournamentWinnerProbability;

        public double ProbabilityOfCrossover
        {
            get { return probabilityOfCrossover; }
        }
        private double probabilityOfCrossover;

        public int NumberOfCrossoverPoints
        {
            get { return this.numberOfCrossoverPoints; }
        }
        private int numberOfCrossoverPoints;

        public double ProbabilityOfMutation
        {
            get { return probabilityOfMutation; }
        }
        private double probabilityOfMutation;

        #endregion

        #region Cryptographic Parameters
        public NGramFrequencies NGramFrequencies
        {
            get { return nGramFrequencies; }
        }
        private NGramFrequencies nGramFrequencies;

        public LetterFrequencies TrainedLetterFrequencies
        {
            get { return trainedLetterFrequencies; }
        }
        private LetterFrequencies trainedLetterFrequencies;

        public LetterFrequencies CipherLetterFrequencies
        {
            get { return cipherLetterFrequencies; }
        }
        private LetterFrequencies cipherLetterFrequencies;

        public string EncryptedText
        {
            get { return encryptedText; }
            set { encryptedText = value; }
        }
        private string encryptedText;

        public string DecryptedText
        {
            get { return decryptedText; }
            set { decryptedText = value; }
        }
        private string decryptedText;
                
        #endregion

        public ReadOnlyCollection<Individual> Population
        {
            get
            {
                return population.AsReadOnly();
            }
        }
        private List<Individual> population;

        private Random RandomNumberGenerator
        {
            get { return this.randomNumberGenerator; }
        }
        private Random randomNumberGenerator;

        public int CurrentGeneration
        {
            get
            {
                return currentGeneration;
            }
        }
        private int currentGeneration;

        private int CompareIndividuals(Individual a, Individual b)
        {
            return -a.Fitness.CompareTo(b.Fitness);
        }

        private void CreateInitialPopulation()
        {
            this.currentGeneration = 0;
            int remaining = this.PopulationSize;
            if (SEED_POPULATION)
            {
                int seeded = (int)Math.Ceiling(this.PopulationSize * 0.1);
                remaining -= seeded;
                double probabilityOfObeyingFrequency = 0.9;
                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                List<char> trainedFrequencies = new List<char>(alphabet.ToCharArray());
                List<char> cipherFrequencies = new List<char>(alphabet.ToCharArray());
                Comparison<char> trainedComparison = delegate(char c1, char c2)
                {
                    return -this.TrainedLetterFrequencies.FrequencyOf(c1).CompareTo(this.TrainedLetterFrequencies.FrequencyOf(c2));
                };
                Comparison<char> cipherComparison = delegate(char c1, char c2)
                {
                    return -this.CipherLetterFrequencies.FrequencyOf(c1).CompareTo(this.CipherLetterFrequencies.FrequencyOf(c2));
                };
                trainedFrequencies.Sort(trainedComparison);
                cipherFrequencies.Sort(cipherComparison);
                for (int i = 0; i < seeded; i++)
                {
                    char[] chromosone = new char[alphabet.Length];
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        char c = alphabet[j];
                        chromosone[j] = cipherFrequencies[trainedFrequencies.IndexOf(c)];
                    }
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        double probability = this.RandomNumberGenerator.Next();
                        if (probability > probabilityOfObeyingFrequency)
                        {
                            int swapPosition = -1;
                            do
                            {
                                swapPosition = this.RandomNumberGenerator.Next(0, alphabet.Length);
                            } while (swapPosition == j);
                            char oldValue = chromosone[j];
                            chromosone[j] = chromosone[swapPosition];
                            chromosone[swapPosition] = oldValue;
                        }
                    }
                    population.Add(new Individual(this.NGramFrequencies, this.encryptedText, new String(chromosone)));
                }
            }
            for (int i = 0; i < remaining; i++)
            {
                string randomChromosone = SubstitutionCipher.GenerateRandomKey();
                population.Add(new Individual(this.NGramFrequencies, this.encryptedText, randomChromosone));
            }
            population.Sort(CompareIndividuals);
        }

        /// <summary>
        /// Must return an array of size 2
        /// </summary>
        /// <param name="chromosone1"></param>
        /// <param name="chromosone2"></param>
        /// <returns></returns>
        private Individual [] CreateChildren(string chromosone1, string chromosone2)
        {
            Individual[] newChildren = new Individual[2];
            double probabilityOfCrossover = this.RandomNumberGenerator.NextDouble();
            double probabilityOfChild1Mutating = this.RandomNumberGenerator.NextDouble();
            double probabilityOfChild2Mutating = this.RandomNumberGenerator.NextDouble();
            int length = chromosone1.Length;
            char [] child1 = new char[length];
            char [] child2 = new char[length];
            // Position Based Crossover
            if (probabilityOfCrossover < this.ProbabilityOfCrossover)
            {
                List<int> randomPositions = new List<int>();
                for (int i = 0; i < this.NumberOfCrossoverPoints; i++)
                {
                    int index = -1;
                    do
                    {
                        index = this.RandomNumberGenerator.Next(0, length);
                    } while (randomPositions.Contains(index));
                    randomPositions.Add(index);
                }

                List<char> remainingCharacters1 = new List<char>(chromosone2.ToCharArray());
                List<char> remainingCharacters2 = new List<char>(chromosone1.ToCharArray());

                foreach (int point in randomPositions)
                {
                    char c1 = chromosone1[point];
                    char c2 = chromosone2[point];
                    child1[point] = c1;
                    child2[point] = c2;
                    remainingCharacters1.Remove(c1);
                    remainingCharacters2.Remove(c2);
                }
                int j = 0;
                for (int i = 0; i < length; i++)
                {
                    if (!randomPositions.Contains(i))
                    {
                        child1[i] = remainingCharacters1[j];
                        child2[i] = remainingCharacters2[j];
                        j++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    child1[i] = chromosone1[i];
                    child2[i] = chromosone2[i];
                }
            }
            // Will Child One Mutate
            if (probabilityOfChild1Mutating < this.ProbabilityOfMutation)
            {
                int oldPosition = this.RandomNumberGenerator.Next(0, length);
                int newPosition = -1;
                do
                {
                    newPosition = this.RandomNumberGenerator.Next(0, length);
                } while (oldPosition == newPosition);
                char oldChar = child1[oldPosition];
                child1[oldPosition] = child1[newPosition];
                child1[newPosition] = oldChar;
            }
            // Will Child Two Mutate
            if (probabilityOfChild2Mutating < this.ProbabilityOfMutation)
            {
                int oldPosition = this.RandomNumberGenerator.Next(0, length);
                int newPosition = -1;
                do
                {
                    newPosition = this.RandomNumberGenerator.Next(0, length);
                } while (oldPosition == newPosition);
                char oldChar = child2[oldPosition];
                child2[oldPosition] = child2[newPosition];
                child2[newPosition] = oldChar;
            }
            // Create new children
            newChildren[0] = new Individual(this.NGramFrequencies, this.encryptedText, new String(child1));
            newChildren[1] = new Individual(this.NGramFrequencies, this.encryptedText, new String(child2));
            return newChildren;
        }

        public void CreateNewGeneration()
        {
            List<Individual> newPopulation = new List<Individual>();
            // Calculate how many parents survive to the next generation
            int elitismAmount = (int)Math.Ceiling(this.PopulationSize * (this.PercentageOfElitism / 100));
            // Calculate how many children are born in the next generation
            int numberOfChildren = this.PopulationSize - elitismAmount;
            if (elitismAmount > 0)
            {
                // Copy elite parents into new population
                newPopulation.AddRange(this.population.GetRange(0, elitismAmount));
            }
            if (numberOfChildren > 0)
            {                
                List<Individual> tournament1Members = new List<Individual>();
                List<Individual> tournament2Members = new List<Individual>();
                List<double> probabilityList = new List<double>();
                probabilityList.Add(this.TournamentWinnerProbability);
                double runningProbability = probabilityList[0];
                for (int i = 1; i < this.TournamentSize; i++)
                {
                    runningProbability *= (1 - this.TournamentWinnerProbability);
                    probabilityList.Add(probabilityList[i - 1] + runningProbability);
                }
                for (int i = 0; i < (int)Math.Ceiling(numberOfChildren / 2.0); i++)
                {
                    tournament1Members.Clear();
                    tournament2Members.Clear();
                    // Choose individuals for the two separate tournaments require that no individual appear more then
                    // once in the union of the two tournaments.
                    for (int j = 0; j < this.TournamentSize; j++)
                    {
                        Individual individual = null;                        
                        do
                        {
                            individual = this.population[this.RandomNumberGenerator.Next(0, this.populationSize)];
                        }
                        while (tournament1Members.Contains(individual));
                        tournament1Members.Add(individual);
                        do
                        {
                            individual = this.population[this.RandomNumberGenerator.Next(0, this.populationSize)];
                        }
                        while (tournament2Members.Contains(individual) || tournament1Members.Contains(individual));
                        tournament2Members.Add(individual);
                    }
                    // Sort members by fitness (descending)
                    tournament1Members.Sort(CompareIndividuals);
                    tournament2Members.Sort(CompareIndividuals);
                    // Choose two members from tournament                    
                    double probability1 = this.RandomNumberGenerator.NextDouble();
                    double probability2 = this.RandomNumberGenerator.NextDouble();
                    Individual winner1 = null;
                    Individual winner2 = null;
                    for (int j = 0; j < this.TournamentSize; j++)
                    {
                        if (probability1 <= probabilityList[j] || j == this.TournamentSize - 1)
                        {
                            winner1 = tournament1Members[j];
                            break;
                        }
                    }
                    for (int j = 0; j < this.TournamentSize; j++)
                    {
                        if (probability2 <= probabilityList[j] || j == this.TournamentSize - 1)
                        {
                            winner2 = tournament2Members[j];
                            break;
                        }
                    }
                    // winner1 and winner2 are now our parents for two new children
                    Individual[] children = CreateChildren(winner1.Chromosone, winner2.Chromosone);
                    newPopulation.Add(children[0]);
                    // In case we had an odd number of children to create this stops us expanding the
                    // population size
                    if (newPopulation.Count < this.PopulationSize)
                    {
                        newPopulation.Add(children[1]);
                    }
                }
            }
            newPopulation.Sort(CompareIndividuals);
            this.population = newPopulation;
            this.currentGeneration++;
        }
    }
}
