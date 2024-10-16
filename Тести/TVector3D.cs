namespace VectorLibrary
{
    public class TVector3D : TVector2D
    {
        // Додаткова третя координата
        public double Z { get; set; }
    
        // Конструктор без параметрів
        public TVector3D() : base()
        {
            Z = 0;
        }
    
        // Конструктор з параметрами
        public TVector3D(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }
    
        // Конструктор копіювання
        public TVector3D(TVector3D other) : base(other.X, other.Y)
        {
            Z = other.Z;
        }
    
        // Перевизначення ToString для виведення
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    
        // Визначення довжини вектора в 3D
        public new double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    
        // Нормування вектора
        public new void Normalize()
        {
            double length = Length();
            if (length > 0)
            {
                X /= length;
                Y /= length;
                Z /= length;
            }
        }
    
        // Перевантаження оператора + для додавання векторів
        public static TVector3D operator +(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
    
        // Перевантаження оператора - для віднімання векторів
        public static TVector3D operator -(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
    
        // Перевантаження оператора * для скалярного добутку
        public static double operator *(TVector3D v1, TVector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
    }
}