using System;
using System.Collections;
using System.Collections.Generic;

namespace AI.Layers
{
    public class Matrix: IEquatable<Matrix>, IEnumerable<float[]>
    {
        float[][] _values;

        public int Height => _values.Length;
        public int Width => _values[0].Length;

        public Matrix(int height, int width)
        {
            if (height == 0)
            {
                throw new ArgumentException("height cannot be 0");
            }

            if (width == 0)
            {
                throw new ArgumentException("width cannot be 0");
            }

            _values = new float[height][];

            for (int i = 0; i < height; i++)
            {
                _values[i] = new float[width];
            }
        }

        public bool Equals(Matrix other)
        {
            if (this.Height != other.Height) { return false; }
            if (this.Width != other.Width) { return false; }

            for (int y = 0; y < this.Height; y++)
            {
                for (int x = 0; x < this.Width; x++)
                {
                    if (this[y, x] != other[y, x])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public IEnumerator<float[]> GetEnumerator()
        {
            return _values.GetEnumerator() as IEnumerator<float[]>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        public float this[int y, int x]
        {
            get
            {
                return _values[y][x];
            }
            set
            {
                _values[y][x] = value;
            }
        }

        public static Matrix operator*(Matrix left, Matrix right)
        {
            return null;
        }
    }
}
