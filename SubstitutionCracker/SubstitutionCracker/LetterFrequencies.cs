using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SubstitutionCracker
{
    public class LetterFrequencies: IEnumerable<Char>
    {
        private Dictionary<char, int> occurrences;

        private LetterFrequencies(Dictionary<char, int> occurrences)
        {
            this.occurrences = occurrences;
        }
        
        public int FrequencyOf(char c)
        {
            int frequency;
            if (this.occurrences.TryGetValue(c, out frequency))
            {
                return frequency; 
            }
            else
            {
                return 0; 
            }
        }

        public static LetterFrequencies Analyse(StreamReader reader)
        {
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            while (!reader.EndOfStream)
            {
                char nextCharacter;
                if (TryNormalizeCharacter((char)reader.Read(), out nextCharacter))
                {
                    int currentOccurrences;
                    if (occurrences.TryGetValue(nextCharacter, out currentOccurrences))
                    {
                        occurrences[nextCharacter] = currentOccurrences + 1;
                    }
                    else
                    {
                        occurrences[nextCharacter] = 1;
                    }
                }
            }
            return new LetterFrequencies(occurrences);
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

        #region IEnumerable<char> Members

        public IEnumerator<char> GetEnumerator()
        {
            foreach (char c in occurrences.Keys)
            {
                yield return c;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (char c in occurrences.Keys)
            {
                yield return c;
            }
        }

        #endregion
    }
}
