namespace ComputerGraphics3.Shapes
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// calss defines 3D point
    /// </summary>
    public class MyPoint3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public int PointId { get; set; }

        public MyPoint3D Substructe(MyPoint3D other)
        {
            return new MyPoint3D
            {
                X = X - other.X,
                Y = Y - other.Y,
                Z = Z - other.Z
            };
        }

        public float ScalarMultiply(MyPoint3D other)
        {
            return     X * other.X +
                       Y * other.Y +
                       Z * other.Z;
        }
       
        public MyPoint3D Clone()
        {
            return new MyPoint3D { X = X,
                                   Y = Y,
                                   Z = Z,
                                   PointId=PointId
                                 };
        }

        public MyPoint3D CrossProduct(MyPoint3D other)
        {
            return new MyPoint3D
            {
                X = Y * other.Z - Z * other.Y,
                Y = Z * other.X - X * other.Z,
                Z = X * other.Y - Y * other.X
            };
        }
        
    }
}
  