using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Graph
{
    class DijkstraShortestPath
    {
        public static void Main()
        {
            DijkstraShortestPathProcessor processor = new DijkstraShortestPathProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class DijkstraShortestPathProcessor
    {
        Dictionary<char, Dictionary<char, int>> adjacencyList = new Dictionary<char, Dictionary<char, int>>();

        public void Process()
        {
            Initialize();
            FindShortestPath('a', 'e');
        }

        private void Initialize()
        {
            adjacencyList.Add('a', new Dictionary<char, int> { { 'b', 7 }, { 'c', 3 } });
            adjacencyList.Add('b', new Dictionary<char, int> { { 'a', 7 }, { 'c', 1 }, { 'd', 2 }, { 'e', 6 } });
            adjacencyList.Add('c', new Dictionary<char, int> { { 'a', 3 }, { 'b', 1 }, { 'd', 2 } });
            adjacencyList.Add('d', new Dictionary<char, int> { { 'b', 2 }, { 'c', 2 }, { 'e', 4 } });
            adjacencyList.Add('e', new Dictionary<char, int> { { 'b', 6 }, { 'd', 4 } });

            //adjacencyList.Add('a', new Dictionary<char, int> { { 'b', 3 }, { 'c', 2 }, { 'e', 4 } });
            //adjacencyList.Add('b', new Dictionary<char, int> { { 'a', 3 }, { 'c', 8 } });
            //adjacencyList.Add('c', new Dictionary<char, int> { { 'a', 2 }, { 'b', 8 }, { 'd', 1 } });
            //adjacencyList.Add('d', new Dictionary<char, int> { { 'c', 1 }, { 'e', 3 } });
            //adjacencyList.Add('e', new Dictionary<char, int> { { 'a', 4 }, { 'd', 3 } });
        }

        private void FindShortestPath(char start, char end)
        {
            Dictionary<char, TrackingEntity> trackingTable = new Dictionary<char, TrackingEntity>();
            // Prepare and initialize tracking table.
            foreach (var item in adjacencyList.Keys)
            {
                trackingTable.Add(item, new TrackingEntity { ShortestDistance = (item.Equals(start) ? 0 : int.MaxValue) });
            }

            var vertexToBeVisited = FetchUnvisitedShortDistanceVertex(trackingTable);
            while (vertexToBeVisited.HasValue)
            {
                var toBeVisitedTrackingEntity = trackingTable[vertexToBeVisited.Value.Key];
                int shortestDistanceFromSource = toBeVisitedTrackingEntity.ShortestDistance;

                foreach (var item in adjacencyList[vertexToBeVisited.Value.Key])
                {
                    int currentDistanceFromSource = shortestDistanceFromSource + item.Value;
                    var currentTargetTrackingEntity = trackingTable[item.Key];
                    if (currentDistanceFromSource < currentTargetTrackingEntity.ShortestDistance)
                    {
                        currentTargetTrackingEntity.ShortestDistance = currentDistanceFromSource;
                        currentTargetTrackingEntity.PreviousVertex = vertexToBeVisited.Value.Key;
                    }
                }

                toBeVisitedTrackingEntity.Visited = true;
                vertexToBeVisited = FetchUnvisitedShortDistanceVertex(trackingTable);
            }

            Stack<char> identifiedVertexStack = new Stack<char>();
            char currentEndVertex = end;
            identifiedVertexStack.Push(end);
            while (currentEndVertex != start)
            {
                currentEndVertex = trackingTable[currentEndVertex].PreviousVertex;
                identifiedVertexStack.Push(currentEndVertex);
            }

            Console.WriteLine($"Shortest path between {start} to {end} is: {BuildShortestPath(identifiedVertexStack)}");
        }

        private string BuildShortestPath(Stack<char> vertexStack)
        {
            StringBuilder shortestPathResult = new StringBuilder();
            while (vertexStack.Count > 0)
            {
                string continuationString = (vertexStack.Count > 1) ? "--> " : string.Empty;
                string path = $"{vertexStack.Pop()} {continuationString}";
                //Console.Write(path);
                shortestPathResult.Append(path);
            }

            return shortestPathResult.ToString();
        }

        private KeyValuePair<char, TrackingEntity>? FetchUnvisitedShortDistanceVertex(Dictionary<char, TrackingEntity> trackingTable)
        {
            var unvisitedVertex = trackingTable.Where(kv => kv.Value.Visited == false);

            if (unvisitedVertex == null || unvisitedVertex.Count() == 0)
            {
                return null;
            }

            var unvisitedShortestDistance = unvisitedVertex.Min(kv => kv.Value.ShortestDistance);
            var vertexToBeVisited = unvisitedVertex.First(kv => kv.Value.ShortestDistance == unvisitedShortestDistance);

            return vertexToBeVisited;
        }

        class TrackingEntity
        {
            //public char Vertex { get; set; }
            public int ShortestDistance { get; set; }
            public char PreviousVertex { get; set; }
            public bool Visited { get; set; }
        }
    }
}
