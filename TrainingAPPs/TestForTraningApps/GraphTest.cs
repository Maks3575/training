using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingAPPs.Graph;

namespace TestForTraningApps
{
    [TestClass]
    public class GraphTest
    {
        [TestMethod]
        public void TestFillGraph()
        {
            var graph = new Graph();
            int[,] inputMatrix = new int[3, 3] {
                    {0, 0, 1 },
                    {1, 0, 0 },
                    {1, 1, 1 }};
            graph.FillFromAdjacencyMatrix(inputMatrix);
            int[,] outputMatrix = graph.CreateAdjacencyMatrix();
            Assert.IsTrue(CompareMatrix(inputMatrix, outputMatrix));
        }

        bool CompareMatrix(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.Length != matrix2.Length) return false;
            int count = matrix2.GetLength(0);
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j]) return false;
                }
            }
            return true;
        }
    }
}
