using System.Collections.Generic;
using Xunit;

namespace Algorithms.Graph.Tests
{
    public class DirectedGraphTest
    {
        [Fact]
        public void Test()
        {
            var graph = new DirectedGraph<string, string>()
            {
                "a",
                "b",
                { "a", "b", "a-b" },
                { "b", "a", "b-a" },
            };

            Assert.Equal(new Dictionary<string, string>()
            {
                { "b", "a-b" }
            }, graph.GetOut("a"));

            Assert.Equal(new Dictionary<string, string>()
            {
                { "a", "b-a" }
            }, graph.GetOut("b"));

            Assert.Equal(new Dictionary<string, string>()
            {
                { "b", "b-a" }
            }, graph.GetIn("a"));

            Assert.Equal(new Dictionary<string, string>()
            {
                { "a", "a-b" }
            }, graph.GetIn("b"));
        }

        [Fact]
        public void TestEquals()
        {
            var graph = new DirectedGraph<string, string>()
            {
                "a",
                "b",
                { "a", "b", "a-b" },
            };

            var expected = new DirectedGraph<string, string>()
            {
                "a",
                "b",
                { "a", "b", "a-b" },
            };

            Assert.True(expected.Equals(graph));
        }
    }
}
