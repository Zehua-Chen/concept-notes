using System.Collections;
using System.Collections.Generic;

namespace NLP
{
    public struct SentencePair
    {
        public string[] EWords;
        public string[] FWords;
    }

    public class BilingualDictionaryTrainingData: IEnumerable<SentencePair>
    {
        public List<SentencePair> Pairs { get; } = new List<SentencePair>();
        public HashSet<string> EWords { get; } = new HashSet<string>();
        public HashSet<string> FWords { get; } = new HashSet<string>();

        public IEnumerator<SentencePair> GetEnumerator()
        {
            return Pairs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Pairs.GetEnumerator();
        }

        public void Add(SentencePair pair)
        {
            foreach (string e in pair.EWords)
            {
                EWords.Add(e);
            }

            foreach (string f in pair.FWords)
            {
                FWords.Add(f);
            }

            Pairs.Add(pair);
        }


        public static BilingualDictionaryTrainingData AlienLanguage
        {
            get
            {
                return null;
            }
        }
    }
}
