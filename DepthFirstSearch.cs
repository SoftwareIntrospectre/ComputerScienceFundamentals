
using System;
using System.Collections.Generic;

namespace RouteBetweenNodes
{

    //classes represents a directed graph, using adjacency list representation
    class Graph
    {
        private int Vertex;

        private List<int>[] adjacencyMatrix; //equivalent to an ArrayList (C# automatically expands the List dynamically)

        //Constructor
        Graph(int vertex) //used to initialize the graph with a set number of vertices
        {
            Vertex = vertex;
            adjacencyMatrix = new List<int>[vertex];
            for(int i = 0; i < vertex; ++i)
            {
                adjacencyMatrix[i] = new List<int>(); //add the number of vertices to adjacency matrix, based on user's input
            }
        }

        //method to Add an Edge into the Graph
        void AddEdge(int vertex, int edge) //edge serves as a pointer to a vertex
        {
            adjacencyMatrix[vertex].Add(edge); //add edge to vertex's list
        }

        //method used by Depth First Search (DFS)
        void DFSUtility(int vertex, bool[] visited)
        {
            //mark the current node as visited and print it
            visited[vertex] = true; //set as false by default in C#. Flagged as true once visited. Used recursively: base case when all are flagged true
            Console.Write(vertex + " ");

            //Recur for all the vertices adjacent to this vertex
            List<int> vertexList = adjacencyMatrix[vertex];
            foreach(var n in vertexList)
            {
                if(!visited[n])
                {
                    DFSUtility(n, visited);
                }
            }
        }

        //Method to do the DFS Traversal. It uses recursive DFSUtility()
        void DFS(int vertex)
        {
            //Mark all vertices as not visited (set as false by default in C#)
            bool[] visited = new bool[Vertex];

            //Call the recursive helper function to print DFS traversal
            DFSUtility(vertex, visited);
        }

        static void Main(string[] args)
        {
            Graph graph = new Graph(6);

            graph.AddEdge(1,3);
            graph.AddEdge(3,2);
            graph.AddEdge(2,4);
            graph.AddEdge(4,4);
            graph.AddEdge(4,1);
            graph.AddEdge(2,5);
            graph.AddEdge(4,0);
            graph.AddEdge(0,1);
            Console.WriteLine("Following is Depth First Search Traversal " + "(starting from vertex 0)");

            graph.DFS(3);
            Console.ReadKey();
        }
    }
}
