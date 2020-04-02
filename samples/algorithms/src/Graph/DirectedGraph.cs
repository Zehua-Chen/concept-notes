using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Graph
{
    public class DirectedGraph<V, E> :
        IEnumerable<(V, Dictionary<V, E>, Dictionary<V, E>)>
    {
        struct Vertex
        {
            public Dictionary<V, E> Out;
            public Dictionary<V, E> In;

            public static Vertex Default()
            {
                return new Vertex()
                {
                    Out = new Dictionary<V, E>(),
                    In = new Dictionary<V, E>(),
                };
            }
        }

        Dictionary<V, Vertex> _dictionary = new Dictionary<V, Vertex>();

        public void Add(V vertex)
        {
            _dictionary.Add(vertex, Vertex.Default());
        }

        public void Add(V @out, V @in, E e)
        {
            Vertex fromVertex;
            Vertex inVertex;

            if (!_dictionary.TryGetValue(@out, out fromVertex))
            {
                fromVertex = Vertex.Default();
            }

            if (!_dictionary.TryGetValue(@in, out inVertex))
            {
                inVertex = Vertex.Default();
            }

            fromVertex.Out.Add(@in, e);
            inVertex.In.Add(@out, e);

            _dictionary[@out] = fromVertex;
            _dictionary[@in] = inVertex;
        }

        public Dictionary<V, E> GetOut(V vertex)
        {
            return _dictionary[vertex].Out;
        }

        public Dictionary<V, E> GetIn(V vertex)
        {
            return _dictionary[vertex].In;
        }

        public IEnumerator<(V, Dictionary<V, E>, Dictionary<V, E>)> GetEnumerator()
        {
            foreach (var pair in _dictionary)
            {
                yield return (pair.Key, pair.Value.Out, pair.Value.In);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
