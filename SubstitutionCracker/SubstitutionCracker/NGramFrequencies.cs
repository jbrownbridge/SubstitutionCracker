using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SubstitutionCracker
{
    public class NGramFrequencies: IEnumerable<String>
    {
        private Dictionary<string, int> occurrences;

        private NGramFrequencies(int length, Dictionary<string, int> occurrences)
        {
            this.length = length;
            this.occurrences = occurrences;
        }
        
        public int FrequencyOf(String nGram)
        {
            int nGramOccurrence;
            if (this.occurrences.TryGetValue(nGram, out nGramOccurrence))
            { 
                return nGramOccurrence; 
            }
            else
            {
                return 0; 
            }
        }

        public int Length
        {
            get
            {
                return length;
            }            
        }
        private int length;
              
        public static NGramFrequencies Analyse(StreamReader reader, int length)
        {
            LinkedList<char> accumulator = new LinkedList<char>();
            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            while (!reader.EndOfStream)
            {
                char nextCharacter;
                if (TryNormalizeCharacter((char)reader.Read(), out nextCharacter))
                {
                    accumulator.AddLast(nextCharacter);
                    if (accumulator.Count == length)
                    {
                        StringBuilder nGram = new StringBuilder(length);
                        foreach (char value in accumulator)
                        {
                            nGram.Append(value); 
                        }
                        string nGramString = nGram.ToString();

                        int currentOccurrences;
                        if (occurrences.TryGetValue(nGramString, out currentOccurrences))
                        { 
                            occurrences[nGramString] = currentOccurrences + 1; 
                        }
                        else
                        { 
                            occurrences[nGramString] = 1; 
                        }
                        accumulator.RemoveFirst();
                    }                    
                }
                else
                {
                    accumulator.Clear();
                }
            }
            return new NGramFrequencies(length, occurrences);
        }

        private static bool TryNormalizeCharacter(char input, out char output)
        {
            if (Char.IsLetter(input))
            {
                output = Char.ToUpper(input);
                return true;
            }
            else
            {
                output = '?';
                return false;
            }
        }

        #region IEnumerable<string> Members

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string s in occurrences.Keys)
            {
                yield return s;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (string s in occurrences.Keys)
            {
                yield return s;
            }
        }

        #endregion
    }
}
