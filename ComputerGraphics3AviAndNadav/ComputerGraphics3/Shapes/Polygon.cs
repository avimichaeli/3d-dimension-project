using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace ComputerGraphics3.Shapes
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public enum MinOrMax
    {
        MAX, MIN
    }
    public enum Coordinate
    {
        X, Y, Z
    }
    public class Polygon
    {
        public List<string> Ids = new List<string>();
        public List<MyPoint3D> PolygonPoints = new List<MyPoint3D>();
        public List<MyLine> PolygonLines = new List<MyLine>();
        public Color LineColor { get; set; }
        public Color PolygonColor { get; set; }
        public bool IsVisible { get; set; }
        static Random rnd = new Random();

        public Polygon()
        {
            ///generate random color
            var random = new Random();        
            PolygonColor = Color.FromArgb(rnd.Next(75, 145),rnd.Next(75,145),rnd.Next(75,145));
        }

        /// <summary>
        /// Sort polygons by min/max by x/y/z
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="xyz"></param>
        /// <returns></returns>
        public MyPoint3D GetMaxmium(MinOrMax mm, Coordinate xyz)
        {
            MyPoint3D point3D = new MyPoint3D();

            switch (xyz)
            {
                case Coordinate.X:
                    point3D = PolygonPoints.OrderByDescending(item => item.X).First();
                    ; break;
                case Coordinate.Y:
                    point3D = PolygonPoints.OrderByDescending(item => item.Y).First();
                    ; break;
                case Coordinate.Z:
                    point3D = PolygonPoints.OrderByDescending(item => item.Z).First();
                    ; break;
            }
            switch (mm)
            {
                case MinOrMax.MAX:

                    ; break;

                case MinOrMax.MIN:
                    switch (xyz)
                    {
                        case Coordinate.X:
                            point3D = PolygonPoints.OrderByDescending(item => item.X).First();
                            point3D = PolygonPoints.LastOrDefault();
                            ; break;
                        case Coordinate.Y:
                            point3D = PolygonPoints.OrderByDescending(item => item.Y).First();
                            point3D = PolygonPoints.LastOrDefault();
                            ; break;
                        case Coordinate.Z:
                            point3D = PolygonPoints.OrderByDescending(item => item.Z).First();
                            point3D = PolygonPoints.LastOrDefault();
                            ; break;
                    }
                    ; break;
            }

            return point3D;
        }

        public MyPoint3D GetNormal()
        {
            var p1 = PolygonPoints[0].Substructe(PolygonPoints[1]);
            var p2 = PolygonPoints[0].Substructe(PolygonPoints[2]);
            MyPoint3D res = p1.CrossProduct(p2);
            return res;
        }

        public bool GetIsVisible()
        {
            return GetNormal().ScalarMultiply(new MyPoint3D { X = 0, Y = 0, Z = 1 }) < 0;
        }
    }
}
  