using System.Collections.Generic;

namespace NLP
{
    using WordMatrix = Dictionary<string, Dictionary<string, float>>;

    internal static class WordMatrixExtension
    {
        public static void InitializeDefautValue(
            this WordMatrix matrix,
            string f,
            string e,
            float defaultValue = 0.0f)
        {
            Dictionary<string, float> row;

            if (!matrix.TryGetValue(f, out row))
            {
                row = new Dictionary<string, float>();
                matrix[e] = row;
            }

            float value;

            if (!row.TryGetValue(e, out value))
            {
                value = defaultValue;
                row[f] = value;
            }
        }
    }

    public class BilingualDictionary
    {
        public WordMatrix Matrix { get; private set; } = new WordMatrix();
        public float DefaultMatrixValue { get; set; } = 0.0f;

        public float Lookup(string e, string f)
        {
            return this.Matrix[f][e];
        }

        public static BilingualDictionary Train(
            BilingualDictionaryTrainingData trainingData,
            int iterations = 10)
        {
            WordMatrix count = new WordMatrix();

            // total(f)
            Dictionary<string, float> total = new Dictionary<string, float>();
            // s-total(e)
            Dictionary<string, float> sTotal = new Dictionary<string, float>();

            BilingualDictionary dictionary = new BilingualDictionary();

            // Initialize default values
            // - count
            // - total
            foreach (SentencePair sentencePair in trainingData)
            {
                foreach (string f in sentencePair.FWords)
                {
                    total[f] = 0.0f;
                }

                foreach (string f in sentencePair.FWords)
                {
                    foreach (string e in sentencePair.EWords)
                    {
                        count.InitializeDefautValue(f, e);
                        dictionary.Matrix.InitializeDefautValue(f, e);
                    }
                }
            }

            for (int iteration = 0; iteration < iterations; iteration++)
            {
                foreach (SentencePair sentencePair in trainingData)
                {
                    // Compute normalizations
                    foreach (string e in sentencePair.EWords)
                    {
                        sTotal[e] = 0.0f;

                        foreach (string f in sentencePair.FWords)
                        {
                            sTotal[e] += dictionary.Lookup(e, f);
                        }
                    }

                    // Collect counts
                    foreach (string e in sentencePair.EWords)
                    {
                        foreach (string f in sentencePair.FWords)
                        {
                            count[f][e] += dictionary.Matrix[f][e] / sTotal[e];
                            total[f] += dictionary.Matrix[f][e] / sTotal[e];
                        }
                    }
                }

                // Esitmate probabilities
                foreach (string f in trainingData.FWords)
                {
                    foreach (string e in trainingData.EWords)
                    {
                        dictionary.Matrix[f][e] = count[f][e] / total[f];
                    }
                }
            }

            return dictionary;
        }
    }
}
