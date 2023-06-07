using ComputerGraphics3.Shapes;

namespace ComputerGraphics3.Castings
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public class Prespective
    {
        /// <summary>
        ///  מבוסס על מצגת מקור "הטלות למישור המסך" עמוד 20
        /// </summary>
        /// <param name="fc"></param>
        /// <param name="D"></param>
        public void PrespectiveExc(FileContentAndPath fc,float D)
        {
            for (int i = 0; i < fc.Polygons.Count; i++)
            {
                for (int j = 0; j < fc.Polygons[i].PolygonPoints.Count; j++)
                {
                    MyPoint3D point = fc.Polygons[i].PolygonPoints[j];

                    float s = 1 / (1 + point.Z / D);

                    float[,] matrix = {
                    { s, 0, 0, 0 },
                    { 0, s, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 }
                    };
                    float[,] vector = { { point.X }, { point.Y }, { point.Z }, { 1 } };
                    float[,] res = Utils.MultiplyMatrix(matrix, vector);

                    point.X = res[0, 0];
                    point.Y = res[1, 0];
                    point.Z = res[2, 0];
                }
            }
        }
    }
}
  