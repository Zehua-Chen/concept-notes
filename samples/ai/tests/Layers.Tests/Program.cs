using System;

namespace AI.Layers.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearLayer layer = new LinearLayer(2, 2);

            // Bias
            layer.Parameters[0][0] = 100.0f;
            // Weights
            layer.Parameters[0][1] = 1.0f;
            layer.Parameters[0][2] = 7.0f;

            // Bias
            layer.Parameters[1][0] = 50.0f;
            // Weights
            layer.Parameters[1][1] = 1.0f;
            layer.Parameters[1][2] = 0.0f;

            float[] input = new float[] { 1.0f, 1.0f };
            float[] output = new float[] { 0.0f, 0.0f };

            layer.Evaluate(input, output);

            Console.WriteLine("Expects 108 and 51");
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
