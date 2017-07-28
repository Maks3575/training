using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAPPs.Graph
{
    public class Graph
    {
        List<Vertex> VertexList;
        List<Edge> EdgeList;

        public void FillFromAdjacencyMatrix(int[,] matrix)
        {
            int countVertex = matrix.GetLength(0);
            VertexList = Enumerable.Range(0, countVertex - 1).Select(i => new Vertex() { id = i }).ToList();
            for (int i = 0; i < countVertex; i++)
            {
                for (int j = 0; j < countVertex; j++)
                {
                    if (j == 1)
                    {
                        var edge = new Edge { Vertex1 = VertexList[i], Vertex2 = VertexList[j] };
                        EdgeList.Add(edge);
                        VertexList[i].OutputEdges.Add(edge);
                        VertexList[j].InputEdges.Add(edge);
                    }
                }
            } 
        }

        public int[,] CreateAdjacencyMatrix()
        {
            int countVertex = VertexList.Count;
            int[,] matrix = new int[countVertex, countVertex];
            for (int i = 0; i < countVertex; i++)
            {
                for (int j = 0; j < countVertex; j++)
                {
                    matrix[i, j] = VertexList[i].OutputEdges.Any(edge => edge.Vertex2 == VertexList[j]) ? 1 : 0;
                }
            }
            return matrix;
        }
    }
}
