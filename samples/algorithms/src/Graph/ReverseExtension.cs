using System;
using System.Collections.Generic;

namespace Algorithms.Graph
{
    public static class ReverseExtension
    {
        public static DirectedGraph<V, E> GetReverse<V, E>(
            this DirectedGraph<V, E> graph)
        {
            var reversed = new DirectedGraph<V, E>();

            foreach (V vertex in graph)
            {
                reversed.Add(vertex);
            }

            foreach (V vertex in graph)
            {
                Dictionary<V, E> outs = graph.GetOut(vertex);
                Dictionary<V, E> ins = graph.GetIn(vertex);

                foreach (var @out in outs)
                {
                    reversed.Add(@out.Key, vertex, @out.Value);
                }

                foreach (var @in in ins)
                {
                    reversed.Add(@in.Key, vertex, @in.Value);
                }
            }

            return reversed;
        }
    }
}
