using ComputerGraphics3.Shapes;
using System.Collections.Generic;

namespace ComputerGraphics3.Transformations
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    class ScalingTransform
    {

        public void Scale(FileContentAndPath fc, float sx, float sy, float sz)
        {
            float[,] matrix1 = { { sx,0,0,0},
                                 {0,sy,0,0 },
                                 { 0,0,sz,0},
                                 { 0,0,0,1} };
   
            List<MyPoint3D> Points3d = fc.Points3d;

            for (int i = 0; i < Points3d.Count; i++)
            {
                float[,] vector = { { Points3d[i].X }, { Points3d[i].Y }, { Points3d[i].Z }, { 1 } };
                float[,] res = Utils.MultiplyMatrix(matrix1, vector);
                Points3d[i].X = res[0, 0];
                Points3d[i].Y = res[1, 0];
                Points3d[i].Z = res[2, 0];
            }

            List<Polygon> Polygons = fc.Polygons;
            for (int i = 0; i < Polygons.Count; i++)
            {
                for (int j = 0; j < Polygons[i].PolygonPoints.Count; j++)
                {
                    MyPoint3D point3 = Polygons[i].PolygonPoints[j];
                    float[,] vector = { { point3.X }, { point3.Y }, { point3.Z }, { 1 } };
                    float[,] res = Utils.MultiplyMatrix(matrix1, vector);
                    point3.X = res[0, 0];
                    point3.Y = res[1, 0];
                    point3.Z = res[2, 0];
                }
            }
        }
    }
}
  