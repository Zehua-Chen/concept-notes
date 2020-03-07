using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Reflection;

namespace NLP
{
    public struct SentencePair
    {
        public string[] EWords;
        public string[] FWords;
    }

    public class BilingualDictionaryTrainingData : IEnumerable<SentencePair>
    {
        internal struct ModelPair
        {
            public string E { get; set; }
            public string F { get; set; }
        }

        internal struct Model
        {
            /// <summary>
            /// Name of the training data
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Array of sentence pairs
            /// </summary>
            /// <value>Data[sentence][pair]</value>
            public ModelPair[] Data { get; set; }
        }

        public string Name { get; set; }
        public List<SentencePair> Pairs { get; } = new List<SentencePair>();
        public HashSet<string> EWords { get; } = new HashSet<string>();
        public HashSet<string> FWords { get; } = new HashSet<string>();

        /// <summary>
        /// Load training data from stream
        /// </summary>
        /// <param name="stream">some kind of stream</param>
        public BilingualDictionaryTrainingData(Stream stream)
        {
            using StreamReader reader = new StreamReader(stream);
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            Model model = JsonSerializer.Deserialize<Model>(reader.ReadToEnd(), options);

            this.Name = model.Name;

            foreach (ModelPair pair in model.Data)
            {
                SentencePair sentencePair = new SentencePair()
                {
                    FWords = pair.F.Split(" "),
                    EWords = pair.E.Split(" ")
                };

                this.Add(sentencePair);
            }
        }

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
                Assembly assembly = Assembly.GetAssembly(typeof(BilingualDictionaryTrainingData));
                using Stream stream = assembly.GetManifestResourceStream("NLP.Data.AlienLanguage.json");

                return new BilingualDictionaryTrainingData(stream);
            }
        }
    }
}
