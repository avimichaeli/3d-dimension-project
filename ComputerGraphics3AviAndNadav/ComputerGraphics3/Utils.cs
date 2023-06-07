using ComputerGraphics3.Shapes;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace ComputerGraphics3
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Load file from file explorer
        /// </summary>
        /// <returns>FileContentAndPath</returns>
        public static FileContentAndPath LoadFile(bool newpath, FileContentAndPath fc)
        {
            string filePath = "";
            if (newpath)
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "XML files (*.xml)|*.xml";//filter only xml files
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        return LoadFromPath(null, filePath);
                    }
                    return null;
                }
            else
                return LoadFromPath(fc, fc.Path);
        }

        /// <summary>
        /// Sort polygon points by Z 
        /// </summary>
        /// <param name="polygons"></param>
        public static void SortByMaxZ(List<Polygon> polygons)
        {
            polygons = polygons.OrderBy(o => o.GetMaxmium(MinOrMax.MAX, Coordinate.Z).Z).ToList();
        }

        /// <summary>
        /// gets two mtrices and multiply
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns>the multiply result</returns>
        public static float[,] MultiplyMatrix(float[,] matrix1, float[,] matrix2)
        {
            float val_temp = 0;
            float[,] result = new float[matrix1.GetLength(0), matrix2.GetLength(1)];
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                return null;
            else
                for (int i = 0; i < matrix1.GetLength(0); i++)
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        val_temp = 0;
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                        {
                            val_temp += matrix1[i, k] * matrix2[k, j];
                        }
                        result[i, j] = val_temp;
                    }
            return result;
        }

        /// <summary>
        /// Loads the content from the selected file
        /// </summary>
        /// <param name="fc"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static FileContentAndPath LoadFromPath(FileContentAndPath fc, string filePath)
        {
            FileContentAndPath result;
            List<Polygon> oldpolygons = null;
            bool isNew = false;
            if (fc == null)
            {
                result = new FileContentAndPath();
                isNew = true;
            }
            else
            {
                oldpolygons = fc.Polygons;
                result = fc;
            }

            List<Polygon> polygons = new List<Polygon>();
            List<MyPoint3D> allPoints3d = new List<MyPoint3D>();
            List<MyLine> lines = new List<MyLine>();

            //read file lines to array
            string[] linesFile = File.ReadAllLines(filePath);

            XmlDocument doc = new XmlDocument();         
            doc.Load(filePath);
            XmlNode nodes = doc.DocumentElement.SelectSingleNode("/Root/Points");
            int coordinates_count = 0;
            int point_id = 1;
            //fill points list
            foreach (XmlNode node in nodes)
            {
                MyPoint3D point3D = new MyPoint3D();
                point3D.PointId = point_id;
                foreach (XmlNode n in node)
                {
                    string text = n.InnerText;
                    if (coordinates_count % 3 == 0)
                        point3D.X = int.Parse(text);
                    if (coordinates_count % 3 == 1)
                        point3D.Y = int.Parse(text);
                    if (coordinates_count % 3 == 2)
                        point3D.Z = int.Parse(text);
                    coordinates_count++;
                }
                point_id++;
                allPoints3d.Add(point3D);
            }

            nodes = doc.DocumentElement.SelectSingleNode("/Root/Polygons");
            //fill polygons list
            foreach (XmlNode node in nodes)
            {
                Polygon polygon = new Polygon();
                foreach (XmlNode n in node)
                {
                    string text = n.InnerText;
                    string[] a = text.Split(',');
                    for (int i = 0; i < a.Length; i++)
                        polygon.Ids.Add(a[i]);
                }
                polygons.Add(polygon);
            }

            //fill polygon points, for each polygon
            for (int i = 0; i < polygons.Count; i++)
            {
                for (int j = 0; j < polygons[i].Ids.Count; j++)
                {
                    int index = int.Parse(polygons[i].Ids[j]) - 1;
                    MyPoint3D myPoint3 = allPoints3d[index].Clone();
                    polygons[i].PolygonPoints.Add(myPoint3);
                }
            }

            //fill in lines list
            for (int i = 0; i < polygons.Count; i++)
            {
                List<string> path_points = polygons.ElementAt(i).Ids;
                for (int k = 0; k < path_points.Count - 1; k++)
                {
                    MyLine myLine = new MyLine();
                    MyPoint3D start = allPoints3d.Where(o => o.PointId == int.Parse(path_points.ElementAt(k))).FirstOrDefault();
                    MyPoint3D end = allPoints3d.Where(o => o.PointId == int.Parse(path_points.ElementAt(k + 1))).FirstOrDefault();
                    myLine.Start = start;
                    myLine.End = end;
                    lines.Add(myLine);
                    polygons[i].PolygonLines.Add(myLine);
                }
            }

            //copy old polygons colors
            if (!isNew && oldpolygons != null)
                for (int i = 0; i < oldpolygons.Count; i++)
                    polygons[i].PolygonColor = oldpolygons[i].PolygonColor;

            result.Points3d = allPoints3d;
            result.Path = filePath;
            result.Polygons = polygons;
            return result;
        }

        /// <summary>
        /// Draws the polygons to the screen
        /// </summary>
        /// <param name="fc"></param>
        /// <param name="graphics"></param>
        /// <param name="panelHeight"></param>
        /// <param name="panelWidth"></param>
        public static void Draw(FileContentAndPath fc, Graphics graphics, int panelHeight, int panelWidth)
        {
            // create an axis origin in the screen //
            int delteX = panelWidth / 2;
            int delteY = panelHeight / 2;

            // drawing the x axis and y axis.
            Pen balackPen = new Pen(Color.Black, 1);
            graphics.DrawLine(balackPen, 0, delteY, panelWidth, delteY);//X
            graphics.DrawLine(balackPen, delteX, 0, delteX, panelHeight);//Y

            //lines color
            Pen whitePen = new Pen(Color.White, 1);


            for (int i = 0; i < fc.Polygons.Count; i++)
            {
                Polygon polygon = fc.Polygons[i];
                SolidBrush brush = new SolidBrush(polygon.PolygonColor);
                Point[] points = new Point[fc.Polygons[i].PolygonPoints.Count];
                int index = 0;
                if (!polygon.GetIsVisible())
                    continue;
                for (int j = 0; j < polygon.PolygonPoints.Count; j++)      
                    points[index++] = new Point((int)fc.Polygons[i].PolygonPoints[j].X + delteX, (int)fc.Polygons[i].PolygonPoints[j].Y + delteY);
                
                graphics.FillPolygon(brush, points);
                brush.Dispose();
            }
        }
    }

}

   