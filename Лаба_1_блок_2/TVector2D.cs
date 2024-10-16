using System;

namespace VectorLibrary 
{ 
    // Клас, що представляє вектор у R^2
    public class TVector2D
    {
        // Поля для зберігання координат вектора
        public double X { get; set; } // Координата X
        public double Y { get; set; } // Координата Y

        // Конструктор без параметрів
        public TVector2D()
        {
            X = 0; // Ініціалізація X значенням 0
            Y = 0; // Ініціалізація Y значенням 0
        }

        // Конструктор з параметрами
        public TVector2D(double x, double y)
        {
            X = x; // Присвоєння значення X з параметра
            Y = y; // Присвоєння значення Y з параметра
        }

        // Конструктор копіювання
        public TVector2D(TVector2D other)
        {
            X = other.X; // Копіювання значення X з іншого вектора
            Y = other.Y; // Копіювання значення Y з іншого вектора
        }

        // Перевизначення ToString для виведення
        public override string ToString()
        {
            return $"({X}, {Y})"; // Форматуємо рядок для виведення координат
        }

        // Визначення довжини вектора
        public double Length()
        {
            // Обчислюємо довжину вектора за формулою √(X² + Y²)
            return Math.Sqrt(X * X + Y * Y);
        }

        // Нормування вектора (зміна вектора на одиничний)
        public void Normalize()
        {
            double length = Length(); // Отримуємо довжину вектора
            if (length > 0) // Перевіряємо, чи не дорівнює довжина 0
            {
                X /= length; // Нормуємо координату X
                Y /= length; // Нормуємо координату Y
            }
        }

        // Порівняння на рівність
        public static bool operator ==(TVector2D v1, TVector2D v2)
        {
            // Повертаємо true, якщо X і Y обох векторів рівні
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        // Порівняння на нерівність
        public static bool operator !=(TVector2D v1, TVector2D v2)
        {
            // Повертаємо true, якщо вектори не рівні
            return !(v1 == v2); // Використовуємо перевантажений оператор ==
        }

        // Перевантаження оператора + для додавання векторів
        public static TVector2D operator +(TVector2D v1, TVector2D v2)
        {
            // Повертаємо новий вектор, координати якого є сумою відповідних координат
            return new TVector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Перевантаження оператора - для віднімання векторів
        public static TVector2D operator -(TVector2D v1, TVector2D v2)
        {
            // Повертаємо новий вектор, координати якого є різницею відповідних координат
            return new TVector2D(v1.X - v2.X, v1.Y - v2.Y);
        }

        // Перевантаження оператора * для знаходження скалярного добутку
        public static double operator *(TVector2D v1, TVector2D v2)
        {
            // Повертаємо значення скалярного добутку
            return v1.X * v2.X + v1.Y * v2.Y;
        }
    }
}
