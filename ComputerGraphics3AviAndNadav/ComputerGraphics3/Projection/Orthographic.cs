using ComputerGraphics3.Shapes;
using System.Collections.Generic;

namespace ComputerGraphics3.Castings
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public class Orthographic
    {
        /// <summary>
        ///  מבוסס על מצגת מקור "הטלות למישור המסך" עמוד 12
        /// </summary>
        /// <param name="fc"></param>
        public void OrthographicExc(FileContentAndPath fc)
        {
            float[,] matrix = {
              { 1, 0, 0, 0 },
              { 0, 1, 0, 0 },
              { 0,0, 0, 0 },
              { 0, 0, 0, 1 }
            };
            List<Polygon> Polygons = fc.Polygons;
            for (int i = 0; i < Polygons.Count; i++)
            {
                for (int j = 0; j < Polygons[i].PolygonPoints.Count; j++)
                {
                    MyPoint3D point3 = Polygons[i].PolygonPoints[j];
                    float[,] vector = { { point3.X, point3.Y, 0, 1 } };
                    float[,] res = Utils.MultiplyMatrix(vector, matrix);
                    point3.X = res[0, 0];
                    point3.Y = res[0, 1];
                    point3.Z = point3.Z;
                }
            }
        }
    }
}
  