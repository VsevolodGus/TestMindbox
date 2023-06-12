namespace TestMindBox.Grafs;

internal class Vertex
{
    public readonly int ID;

    public readonly Edge[] Edges;

    public Vertex(int iD, Edge[] edges)
    {
        ID = iD;
        Edges = edges;
    }
}
