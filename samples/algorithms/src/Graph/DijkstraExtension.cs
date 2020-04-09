using System;
using System.Collections.Generic;
using Algorithms.PriorityQueue;

namespace Algorithms.Graph
{
    public static class DijkstraExtension
    {
        /// <summary>
        /// Dijkstra's algorithm
        /// </summary>
        /// <typeparam name="TVertex">Type of vertex</typeparam>
        /// <typeparam name="TEdge">Type of edge</typeparam>
        /// <param name="start">Start vertex</param>
        /// <returns>
        /// The shortest distance and the prev node in shortest path of each
        /// vertex
        /// </returns>
        public static Dictionary<TVertex, (int, TVertex)> Dijkstra<TVertex, TEdge>(
            this DirectedGraph<TVertex, TEdge> graph,
            TVertex start)
            where TEdge: IVaringEdge
        {
            Dictionary<TVertex, (int, TVertex)> output = new Dictionary<TVertex, (int, TVertex)>();

            var comparer = EqualityComparer<TVertex>.Default;

            // initialize priority queue
            PriorityQueue<int, TVertex> queue = new PriorityQueue<int, TVertex>();
            queue.Add(0, start);

            foreach (TVertex vertex in graph)
            {
                if (comparer.Equals(vertex, start))
                {
                    continue;
                }

                output.Add(vertex, (int.MaxValue, vertex));
                queue.Add(int.MaxValue, vertex);
            }

            // Go through all vertices
            for (int i = 0; i < graph.VertexCount; i++)
            {
                KeyValuePair<int, TVertex> peek = queue.Peek();

                foreach (KeyValuePair<TVertex, TEdge> @out in graph.GetOut(peek.Value))
                {
                    int newLength = @out.Value.Length + peek.Key;
                    int oldLength = output[@out.Key].Item1;

                    if (newLength < oldLength)
                    {
                        output[@out.Key] = (newLength, peek.Value);

                        queue.Remove(oldLength);
                        queue.Add(newLength, @out.Key);
                    }
                }
            }

            return output;
        }
    }
}
