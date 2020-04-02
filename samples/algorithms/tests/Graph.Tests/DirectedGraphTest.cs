using System.Collections.Generic;
using Xunit;

namespace Algorithms.Graph.Tests
{
    public class DirectedGraphTest
    {
        [Fact]
        public void Test()
        {
            DirectedGraph<string, string> graph = new DirectedGraph<string, string>()
            {
                "a",
                "b",
                { "a", "b", "a-b" },
                { "b", "a", "b-a" },
            };

            Assert.Equal(graph.GetOut("a"), new Dictionary<string, string>()
            {
                { "b", "a-b" }
            });

            Assert.Equal(graph.GetOut("b"), new Dictionary<string, string>()
            {
                { "a", "b-a" }
            });

            Assert.Equal(graph.GetIn("a"), new Dictionary<string, string>()
            {
                { "b", "b-a" }
            });

            Assert.Equal(graph.GetIn("b"), new Dictionary<string, string>()
            {
                { "a", "a-b" }
            });
        }
    }
}
