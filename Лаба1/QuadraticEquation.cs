using System;

class QuadraticEquation
{
    // Закриті поля для коефіцієнтів квадратного рівняння
    private double a; // Коєфіцієнт при x^2
    private double b; // Коєфіцієнт при x
    private double c; // Вільний член
    
    // Закриті поля для розв'язків
    private double? x1; // Перший корінь (може бути null)
    private double? x2; // Другий корінь (може бути null)
    
    // Конструктор, який приймає коефіцієнти a, b, c
    public QuadraticEquation(double a, double b, double c)
    {
        this.a = a; // Ініціалізація поля a
        this.b = b; // Ініціалізація поля b
        this.c = c; // Ініціалізація поля c
        CalculateRoots(); // Обчислення коренів при створенні об'єкта
    }

    // Метод для обчислення дискримінанту та розв'язків
    private void CalculateRoots()
    {
        if (a == 0)
        {
            // Якщо a = 0, то рівняння лінійне або немає сенсу
            if (b != 0)
            {
                // Лінійне рівняння bx + c = 0
                x1 = x2 = -c / b; // Обчислення єдиного кореня
            }
            else
            {
                // Якщо a = 0 і b = 0, рівняння не має рішення або має нескінченну кількість розв'язків
                x1 = x2 = null;
            }
        }
        else
        {
            // Класичний випадок квадратного рівняння
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0) // Два різних дійсних корені
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else if (discriminant == 0) // Один дійсний корінь
            {
                x1 = x2 = -b / (2 * a);
            }
            else // Немає дійсних коренів
            {
                x1 = x2 = null;
            }
        }
    }


    // Індексатор для доступу до розв'язків
    public double? this[int index]
    {
        get
        {
            if (index == 0) return x1; // Повертаємо перший корінь
            if (index == 1) return x2; // Повертаємо другий корінь
            throw new IndexOutOfRangeException("Індекс повинен бути 0 або 1."); // Виключення для недопустимого індексу
        }
    }

    // Метод для перевірки наявності розв'язків
    public bool HasSolutions()
    {
        return x1.HasValue && x2.HasValue; // Повертаємо true, якщо обидва корені існують
    }

    // Метод для виведення розв'язків
    public void PrintSolutions()
    {
        if (HasSolutions()) // Перевіряємо, чи існують розв'язки
        {
            Console.WriteLine($"Корінь 1: {x1}"); // Виводимо перший корінь
            Console.WriteLine($"Корінь 2: {x2}"); // Виводимо другий корінь
        }
        else
        {
            Console.WriteLine("Дійсних розв'язків не існує."); // Повідомлення про відсутність розв'язків
        }
    }

    // Метод для введення коефіцієнтів
    public void InputCoefficients()
    {
        Console.Write("Введіть a: "); // Запит на введення коефіцієнта a
        a = double.Parse(Console.ReadLine()); // Зчитування значення та присвоєння
        Console.Write("Введіть b: "); // Запит на введення коефіцієнта b
        b = double.Parse(Console.ReadLine()); // Зчитування значення та присвоєння
        Console.Write("Введіть c: "); // Запит на введення коефіцієнта c
        c = double.Parse(Console.ReadLine()); // Зчитування значення та присвоєння

        // Перерахунок коренів після зміни коефіцієнтів
        CalculateRoots(); // Виклик методу для повторного обчислення коренів
    }
}
