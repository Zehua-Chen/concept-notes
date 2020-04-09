using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graph
{
    public class DirectedGraph<TVertex, TEdge> :
        IEnumerable<TVertex>,
        IEquatable<DirectedGraph<TVertex, TEdge>>
    {
        struct VertexData: IEquatable<VertexData>
        {
            public Dictionary<TVertex, TEdge> Out;
            public Dictionary<TVertex, TEdge> In;

            public static VertexData Default()
            {
                return new VertexData()
                {
                    Out = new Dictionary<TVertex, TEdge>(),
                    In = new Dictionary<TVertex, TEdge>(),
                };
            }

            public bool Equals(VertexData other)
            {
                bool @out = this.Out.All((KeyValuePair<TVertex, TEdge> pair) =>
                {
                    if (!other.Out.ContainsKey(pair.Key))
                    {
                        return false;
                    }

                    return pair.Value.Equals(other.Out[pair.Key]);
                });

                bool @in = this.In.All((KeyValuePair<TVertex, TEdge> pair) =>
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

        Dictionary<TVertex, VertexData> _dictionary = new Dictionary<TVertex, VertexData>();

        /// <summary>
        /// Get a number of vertices
        /// </summary>
        public int VertexCount => _dictionary.Count;

        public void Add(TVertex vertex)
        {
            _dictionary.Add(vertex, VertexData.Default());
        }

        public void Add(TVertex @out, TVertex @in, TEdge e)
        {
            VertexData fromVertex = _dictionary[@out];
            VertexData inVertex = _dictionary[@in];

            fromVertex.Out.Add(@in, e);
            inVertex.In.Add(@out, e);

            _dictionary[@out] = fromVertex;
            _dictionary[@in] = inVertex;
        }

        public Dictionary<TVertex, TEdge> GetOut(TVertex vertex)
        {
            return _dictionary[vertex].Out;
        }

        public Dictionary<TVertex, TEdge> GetIn(TVertex vertex)
        {
            return _dictionary[vertex].In;
        }

        public IEnumerator<TVertex> GetEnumerator()
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

        public bool Equals(DirectedGraph<TVertex, TEdge> other)
        {
            return _dictionary.All((KeyValuePair<TVertex, VertexData> pair) =>
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
