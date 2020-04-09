using System.Collections.Generic;
using Xunit;

namespace Algorithms.PriorityQueue.Tests
{
    public class PriorityQueueTest
    {
        [Fact]
        public void TestOrder()
        {
            PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
            queue.Add("1", 1);
            queue.Add("2", 2);
            queue.Add("3", 3);

            var removed = queue.Pop();
            Assert.Equal(new KeyValuePair<int, string>(1, "1"), removed);

            removed = queue.Pop();
            Assert.Equal(new KeyValuePair<int, string>(2, "2"), removed);

            removed = queue.Pop();
            Assert.Equal(new KeyValuePair<int, string>(3, "3"), removed);
        }

        [Fact]
        public void TestDuplicatePriorities()
        {
            PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
            queue.Add("1", 1);
            queue.Add("1", 1);
            queue.Add("2", 2);

            var removed = queue.Pop();
            Assert.Equal(new KeyValuePair<int, string>(1, "1"), removed);

            removed = queue.Pop();
            Assert.Equal(new KeyValuePair<int, string>(1, "1"), removed);

            removed = queue.Pop();
            Assert.Equal(new KeyValuePair<int, string>(2, "2"), removed);
        }
    }
}
