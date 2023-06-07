using ComputerGraphics3.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics3.Transformations
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// translation transfomation
        /// </summary>
        /// <param name="tx"></param>
        /// <param name="ty"></param>
        /// <param name="fc"></param>
        public void Translate(int tx, int ty, FileContentAndPath fc)
        {
            List<MyPoint3D> Points3d = fc.Points3d;
            for (int i = 0; i < Points3d.Count; i++)
            {
                Points3d[i].X += tx;
                Points3d[i].Y += ty;
            }

            for (int i = 0; i < fc.Polygons.Count; i++)
            {
                for (int j = 0; j < fc.Polygons[i].PolygonPoints.Count; j++)
                {
                    MyPoint3D point = fc.Polygons[i].PolygonPoints[j];

                    point.X += tx;
                    point.Y += ty;
                }
            }
        }
    }
}
  