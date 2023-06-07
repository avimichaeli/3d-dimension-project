using ComputerGraphics3.Shapes;
using System;
using System.Collections.Generic;

namespace ComputerGraphics3.Transformations
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    class RotateTransform
    {
        public void Rotate(FileContentAndPath fc, double angle, MyPoint3D point)
        {
            List<MyPoint3D> Points3d = fc.Points3d;
            float[,] r_z = {
                    { (float)Math.Cos(point.Z), (float)Math.Sin(point.Z), 0, 0 },
                    { -(float)Math.Sin(point.Z), (float)Math.Cos(point.Z), 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 }
                    };

            float[,] r_x = {
                    { 1, 0, 0, 0 },
                    { 0,  (float)Math.Cos(point.X), (float)Math.Sin(point.X), 0 },
                    { 0, -(float)Math.Sin(point.X), (float)Math.Cos(point.X), 0 },
                    { 0, 0, 0, 1 }
                    };

            float[,] r_y = {
                     { (float)Math.Cos(point.Y), 0, -(float)Math.Sin(point.Y), 0 },
                     { 0, 1, 0, 0 },
                     { (float)Math.Sin(point.Y), 0, (float)Math.Cos(point.Y), 0 },
                     { 0, 0, 0, 1 }
                     };

                     
            List<Polygon> Polygons = fc.Polygons;
            for (int i = 0; i < Polygons.Count; i++)
            {
                for (int j = 0; j < Polygons[i].PolygonPoints.Count; j++)
                {
                    MyPoint3D point3 = Polygons[i].PolygonPoints[j];
                    float[,] vector = { { point3.X, point3.Y, point3.Z, 1 } };

                    float[,] by_x = null;
                    float[,] by_y = null;
                    float[,] by_z = null;

                    if (point.X == 0)
                        by_x = new float[,] { { point3.X, point.Y, point.Z } };
                    else
                        by_x = Utils.MultiplyMatrix(vector, r_x);

                    if (point.Y == 0)
                        by_y = by_x;
                    else
                        by_y = Utils.MultiplyMatrix(vector, r_y);

                    if (point.Z == 0)
                        by_z = by_y;
                    else
                        by_z = Utils.MultiplyMatrix(vector, r_z);

                    point3.X = by_z[0, 0];
                    point3.Y = by_z[0, 1];
                    point3.Z = by_z[0, 2];
                }
            }     
        }
    }
}
  