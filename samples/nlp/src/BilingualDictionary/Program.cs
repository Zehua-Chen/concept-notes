using System;
using System.IO;
using System.Reflection;

namespace NLP
{
    class Program
    {
        static void Main(string[] args)
        {
            BilingualDictionaryTrainingData trainingData = BilingualDictionaryTrainingData.AlienLanguage;

            Console.WriteLine(trainingData);
        }
    }
}
