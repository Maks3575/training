using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAPPs.Graph
{
    public class Edge
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public int Weight { get; set; } = 0;
        //bool HasDirection { get; set; }
    }
}
