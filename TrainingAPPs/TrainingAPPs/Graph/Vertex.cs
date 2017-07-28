using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAPPs.Graph
{
    public class Vertex
    {
        public int id { get; set; }

        public List<Edge> InputEdges { get; set; } = new List<Edge>();
        public List<Edge> OutputEdges { get; set; } = new List<Edge>();
    }
}
