using System;

namespace VectorLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тестування TVector2D
            Console.WriteLine("Введіть координати для вектора v1 (TVector2D):");
            Console.Write("X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            TVector2D v1 = new TVector2D(x1, y1);

            Console.WriteLine("Введіть координати для вектора v2 (TVector2D):");
            Console.Write("X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            TVector2D v2 = new TVector2D(x2, y2);

            Console.WriteLine($"Вектор v1: {v1}");
            Console.WriteLine($"Вектор v2: {v2}");
            Console.WriteLine($"Довжина v1: {v1.Length()}");
            Console.WriteLine($"Нормування v1:");
            v1.Normalize();
            Console.WriteLine(v1);

            TVector2D sum2D = v1 + v2;
            TVector2D diff2D = v1 - v2;
            double dotProduct2D = v1 * v2;
            Console.WriteLine($"Сума v1 і v2: {sum2D}");
            Console.WriteLine($"Різниця v1 і v2: {diff2D}");
            Console.WriteLine($"Скалярний добуток v1 і v2: {dotProduct2D}");

            // Тестування TVector3D
            Console.WriteLine("\nВведіть координати для вектора v3 (TVector3D):");
            Console.Write("X3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Z3: ");
            double z3 = Convert.ToDouble(Console.ReadLine());

            TVector3D v3 = new TVector3D(x3, y3, z3);

            Console.WriteLine("Введіть координати для вектора v4 (TVector3D):");
            Console.Write("X4: ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y4: ");
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Z4: ");
            double z4 = Convert.ToDouble(Console.ReadLine());

            TVector3D v4 = new TVector3D(x4, y4, z4);

            Console.WriteLine($"\nВектор v3: {v3}");
            Console.WriteLine($"Вектор v4: {v4}");
            Console.WriteLine($"Довжина v3: {v3.Length()}");
            Console.WriteLine($"Нормування v3:");
            v3.Normalize();
            Console.WriteLine(v3);

            TVector3D sum3D = v3 + v4;
            TVector3D diff3D = v3 - v4;
            double dotProduct3D = v3 * v4;
            Console.WriteLine($"Сума v3 і v4: {sum3D}");
            Console.WriteLine($"Різниця v3 і v4: {diff3D}");
            Console.WriteLine($"Скалярний добуток v3 і v4: {dotProduct3D}");
        }
    }
}
