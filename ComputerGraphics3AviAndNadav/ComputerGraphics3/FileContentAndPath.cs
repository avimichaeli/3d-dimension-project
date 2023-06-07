using ComputerGraphics3.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics3
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public class FileContentAndPath
    {
        /// <summary>
        /// all the polygons
        /// </summary>
        public List<Polygon> Polygons { get; set; }

        /// <summary>
        /// list of all points 
        /// </summary>
        public List<MyPoint3D> Points3d { get; set; }

        /// <summary>
        /// the file path
        /// </summary>
        public string Path { get; set; }
    }
}
  