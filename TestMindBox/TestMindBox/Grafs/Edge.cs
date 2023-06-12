using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindBox.Grafs;
internal class Edge
{
    public readonly int Weight;
    public readonly Vertex FromVertex;
    public readonly Vertex ToVertex;

    public Edge(int weight, Vertex fromVertex, Vertex toVertex)
    {
        Weight = weight;
        FromVertex = fromVertex;
        ToVertex = toVertex;
    }
}
