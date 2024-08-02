using System.Text;
namespace NetworkBuilder;

/// <summary>
/// Generating optimal network configuration from given topology by using Prim's algorithm 
/// </summary>
public class Configuration
{
    /// <summary>
    /// 
    /// </summary>
    private class GraphEdge
    {
        public int Weight { get; }
        public int FirstVertex { get; }
        public int SecondVertex { get; }

        public GraphEdge(int firstVertex, int secondVertex, int weight)
        {
            FirstVertex = firstVertex;
            SecondVertex = secondVertex;
            Weight = weight;
        }
    }

    /// <summary>
    /// Build optimal network configuration from given topology
    /// </summary>
    /// <param name="topology"></param>
    /// <returns></returns>
    public static string BuildClearlyTopology(string topology)
    {
        (List<GraphEdge>, int) graphFromTopology = ParseStringToGraph(topology);
        List<GraphEdge> newGraph = PrimsAlgorithm(graphFromTopology.Item1, graphFromTopology.Item2);
        return ParseGraphToString(newGraph);

    }

    private static (List<GraphEdge>, int) ParseStringToGraph(string topology)
    {
        var vertices = new HashSet<int>();
        var result = new List<GraphEdge>();

        foreach (var component in topology.Split("\n"))
        {
            var data = component.Split(":");
            var firstVertex = int.Parse(data[0]);

            foreach (var verticesWithEdges in data[1].Split(','))
            {
                var currentVertexWithEdge = verticesWithEdges.Replace("(", "").Replace(")", "").Split(" ");

                if (currentVertexWithEdge.Length < 3)
                {
                    throw new FormatException("Incorrect information about the router!");
                }

                var secondVertex = int.Parse(currentVertexWithEdge[1]);
                var edgeWeight = int.Parse(currentVertexWithEdge[2]);

                if (edgeWeight <= 0)
                {
                    throw new ArgumentException("Incorrect information about the router's throughput. Throughput can't be negative.");
                }

                result.Add(new GraphEdge(firstVertex, secondVertex, edgeWeight));
                vertices.Add(secondVertex);
            }
            vertices.Add(firstVertex);
        }
        return (result, vertices.Count);
    }

    private static string ParseGraphToString(List<GraphEdge> graph)
    {
        var builder = new StringBuilder();

        foreach (var edge in graph)
        {
            var edgeRepresentation = $"{edge.FirstVertex}: {edge.SecondVertex} ({edge.Weight})";
            builder.Append(edgeRepresentation + '\n');
        }
        return builder.ToString();
    }

    /// <summary>
    /// Finds the maximum throughput edges that is not yet included in the new topology and does not close the loop
    /// </summary>
    /// <param name="spanningTreeVertices"></param>
    /// <param name="graph"></param>
    /// <returns></returns>
    private static GraphEdge FindMaxEdge(HashSet<int> spanningTreeVertices, List<GraphEdge> graph)
    {
        var result = new GraphEdge(0, 0, int.MinValue);
        foreach (var edge in graph)
        {
            if ((spanningTreeVertices.Contains(edge.FirstVertex) && !spanningTreeVertices.Contains(edge.SecondVertex))
                || (spanningTreeVertices.Contains(edge.SecondVertex) && !spanningTreeVertices.Contains(edge.FirstVertex)))
            {
                if (result.Weight < edge.Weight)
                {
                    result = edge;
                }
            }
        }
        return result;
    }

    /// <summary>
    /// The Prim's algorithm for building the maximum spanning tree
    /// </summary>
    /// <param name="graph"></param>
    /// <param name="countGraphVertices"></param>
    /// <returns></returns>
    /// <exception cref="TopologyIsNotConnectedException"></exception>
    private static List<GraphEdge> PrimsAlgorithm(List<GraphEdge> graph, int countGraphVertices)
    {
        List<GraphEdge> spanningTree = new List<GraphEdge>();
        HashSet<int> spanningTreeVertices = new HashSet<int> { 1 };

        while (spanningTreeVertices.Count < countGraphVertices)
        {
            GraphEdge currentMaxEdges = FindMaxEdge(spanningTreeVertices, graph);
            if (currentMaxEdges.Weight == int.MinValue)
            {
                break;
            }
            spanningTreeVertices.Add(currentMaxEdges.FirstVertex);
            spanningTreeVertices.Add(currentMaxEdges.SecondVertex);
            spanningTree.Add(currentMaxEdges);
        }

        if (spanningTreeVertices.Count != countGraphVertices)
        {
            throw new TopologyIsNotConnectedException("Not all routers are reachable");
        }
        return spanningTree;
    }
}
