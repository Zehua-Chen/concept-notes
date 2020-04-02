using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graph
{
    public class DirectedGraph<V, E> :
        IEnumerable<V>,
        IEquatable<DirectedGraph<V, E>>
    {
        struct Vertex: IEquatable<Vertex>
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

            public bool Equals(Vertex other)
            {
                bool @out = this.Out.All((KeyValuePair<V, E> pair) =>
                {
                    if (!other.Out.ContainsKey(pair.Key))
                    {
                        return false;
                    }

                    return pair.Value.Equals(other.Out[pair.Key]);
                });

                bool @in = this.In.All((KeyValuePair<V, E> pair) =>
                {
                    if (!other.In.ContainsKey(pair.Key))
                    {
                        return false;
                    }

                    return pair.Value.Equals(other.In[pair.Key]);
                });

                return @out && @in;
            }
        }

        Dictionary<V, Vertex> _dictionary = new Dictionary<V, Vertex>();

        public void Add(V vertex)
        {
            _dictionary.Add(vertex, Vertex.Default());
        }

        public void Add(V @out, V @in, E e)
        {
            Vertex fromVertex = _dictionary[@out];
            Vertex inVertex = _dictionary[@in];

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

        public IEnumerator<V> GetEnumerator()
        {
            foreach (var pair in _dictionary)
            {
                yield return pair.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Equals(DirectedGraph<V, E> other)
        {
            return _dictionary.All((KeyValuePair<V, Vertex> pair) =>
            {
                if (!other._dictionary.ContainsKey(pair.Key))
                {
                    return false;
                }

                return pair.Value.Equals(other._dictionary[pair.Key]);
            });
        }
  }
}
