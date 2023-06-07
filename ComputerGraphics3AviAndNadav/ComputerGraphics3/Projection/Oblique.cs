using ComputerGraphics3.Shapes;
using System;
using System.Collections.Generic;

namespace ComputerGraphics3.Castings
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public class Oblique
    {
        /// <summary>
        /// Oblique function executes the projection
        ///  מבוסס על מצגת מקור "הטלות למישור המסך" עמוד 15
        /// </summary>
        /// <param name="fc"></param>
        /// <param name="angle"></param>
        /// <param name="coefficient"></param>
        public void ObliqueCabinet(FileContentAndPath fc, double angle, float coefficient)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            float[,] matrix = {
              { 1, 0, 0, 0 },
              { 0, 1, 0, 0 },
              { (float)coefficient * cos, (float)coefficient * sin, 1, 0 },
              { 0, 0, 0, 1 }
            };
            List<Polygon> Polygons = fc.Polygons;//all polygons fron file
            for (int i = 0; i < Polygons.Count; i++)
            {
                for (int j = 0; j < Polygons[i].PolygonPoints.Count; j++)
                {
                    MyPoint3D point3 = Polygons[i].PolygonPoints[j];
                    float[,] vector = { { point3.X, point3.Y, point3.Z, 1 } };
                    float[,] res = Utils.MultiplyMatrix(vector, matrix);
                    point3.X = res[0, 0];
                    point3.Y = res[0, 1];
                    point3.Z = res[0, 2];
                }
            }
        }
    }
}
  