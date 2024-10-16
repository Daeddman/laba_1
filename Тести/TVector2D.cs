using System;

namespace VectorLibrary 
{ 
    public class TVector2D
    {
        // Поля для зберігання координат вектора
        public double X { get; set; }
        public double Y { get; set; }

        // Конструктор без параметрів
        public TVector2D()
        {
            X = 0;
            Y = 0;
        }

        // Конструктор з параметрами
        public TVector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Конструктор копіювання
        public TVector2D(TVector2D other)
        {
            X = other.X;
            Y = other.Y;
        }

        // Перевизначення ToString для виведення
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        // Визначення довжини вектора
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        // Нормування вектора (зміна вектора на одиничний)
        public void Normalize()
        {
            double length = Length();
            if (length > 0)
            {
                X /= length;
                Y /= length;
            }
        }

        // Порівняння на рівність
        public static bool operator ==(TVector2D v1, TVector2D v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        // Порівняння на нерівність
        public static bool operator !=(TVector2D v1, TVector2D v2)
        {
            return !(v1 == v2);
        }

        // Перевантаження оператора + для додавання векторів
        public static TVector2D operator +(TVector2D v1, TVector2D v2)
        {
            return new TVector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Перевантаження оператора - для віднімання векторів
        public static TVector2D operator -(TVector2D v1, TVector2D v2)
        {
            return new TVector2D(v1.X - v2.X, v1.Y - v2.Y);
        }

        // Перевантаження оператора * для знаходження скалярного добутку
        public static double operator *(TVector2D v1, TVector2D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
    }
}