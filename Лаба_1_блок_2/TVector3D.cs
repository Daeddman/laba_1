namespace VectorLibrary
{
    // Клас, що представляє вектор у R^3, наслідує від класу TVector2D
    public class TVector3D : TVector2D
    {
        // Додаткова третя координата для 3D вектора
        public double Z { get; set; }
    
        // Конструктор без параметрів, ініціалізує X, Y з базового класу і Z = 0
        public TVector3D() : base()
        {
            Z = 0; // Встановлюємо Z в 0
        }
    
        // Конструктор з параметрами, ініціалізує X, Y і Z
        public TVector3D(double x, double y, double z) : base(x, y)
        {
            Z = z; // Встановлюємо Z
        }
    
        // Конструктор копіювання, копіює координати з іншого вектора TVector3D
        public TVector3D(TVector3D other) : base(other.X, other.Y)
        {
            Z = other.Z; // Копіюємо значення Z з іншого вектора
        }
    
        // Перевизначення методу ToString для виведення вектора у форматі "(X, Y, Z)"
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})"; // Форматуємо рядок для виведення
        }
    
        // Визначення довжини вектора в 3D за формулою √(X² + Y² + Z²)
        public new double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z); // Обчислюємо довжину вектора
        }
    
        // Нормування вектора: ділимо координати на довжину, якщо довжина не нульова
        public new void Normalize()
        {
            double length = Length(); // Отримуємо довжину вектора
            if (length > 0) // Перевіряємо, чи не дорівнює довжина 0
            {
                X /= length; // Нормуємо X
                Y /= length; // Нормуємо Y
                Z /= length; // Нормуємо Z
            }
        }
    
        // Перевантаження оператора + для додавання двох 3D векторів
        public static TVector3D operator +(TVector3D v1, TVector3D v2)
        {
            // Повертаємо новий вектор, координати якого є сумою відповідних координат
            return new TVector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
    
        // Перевантаження оператора - для віднімання двох 3D векторів
        public static TVector3D operator -(TVector3D v1, TVector3D v2)
        {
            // Повертаємо новий вектор, координати якого є різницею відповідних координат
            return new TVector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
    
        // Перевантаження оператора * для скалярного добутку двох 3D векторів
        public static double operator *(TVector3D v1, TVector3D v2)
        {
            // Повертаємо значення скалярного добутку
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
    }
}
