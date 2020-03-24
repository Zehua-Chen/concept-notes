using System;

namespace AI.Layers
{
    public class LinearLayer
    {
        int _inputLength = 0;
        int _outputLength = 0;

        float[][] _parameters = null;

        public int InputLength => _inputLength;
        public int OutputLength => _outputLength;

        /// <summary>
        /// - Parameters[output][input]
        /// - Parameters[output][0] is the bias
        /// </summary>
        public float[][] Parameters => _parameters;

        public LinearLayer(int inputLength, int outputLength)
        {
            _inputLength = inputLength;
            _outputLength = outputLength;

            _parameters = new float[outputLength][];

            for (int o = 0; o < outputLength; o++)
            {
                _parameters[o] = new float[inputLength + 1];
            }
        }

        public void Evaluate(in ReadOnlySpan<float> input, in Span<float> output)
        {
            for (int o = 0; o < _outputLength; o++)
            {
                // Initialize sum as the bias
                float sum = _parameters[o][0];

                for (int i = 0; i < _inputLength; i++)
                {
                    sum += _parameters[o][i + 1] * input[i];
                }

                output[o] += sum;
            }
        }
    }
}
