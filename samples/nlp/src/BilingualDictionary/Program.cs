using System;
using System.Collections.Generic;
using System.Linq;

namespace NLP
{
    class Program
    {
        static void Main(string[] args)
        {
            BilingualDictionaryTrainingData trainingData = BilingualDictionaryTrainingData.AlienLanguage;
            BilingualDictionary dictionary = BilingualDictionary.Train(trainingData, 10);

            foreach (string f in trainingData.FWords)
            {
                KeyValuePair<string, float> maxE = dictionary.Table[f].Aggregate((a, b) =>
                {
                    if (a.Value > b.Value) return a;
                    return b;
                });

                Console.WriteLine("f: {0}, e: {1}, p = {2}", f, maxE.Key, maxE.Value);
            }
        }
    }
}
