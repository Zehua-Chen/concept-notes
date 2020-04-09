using System.Collections.Generic;

namespace Algorithms.Graph
{
    public static class SCCExtension
    {
        public static HashSet<HashSet<V>> GetSCCs<V, E>(
            this DirectedGraph<V, E> graph)
        {
            return new HashSet<HashSet<V>>();
        }
    }
}
