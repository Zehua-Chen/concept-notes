using Xunit;

namespace AI.Layers.Tests
{
    public class MatrixTest
    {
        [Fact]
        public void TestEquality()
        {
            Matrix matrixA = new Matrix(2, 1)
            {
                [0, 0] = 17.0f,
                [1, 0] = 17.0f,
            };

            Matrix matrixB = new Matrix(2, 1)
            {
                [0, 0] = 17.0f,
                [1, 0] = 17.0f,
            };

            Assert.True(matrixA.Equals(matrixB));
        }
    }
}
