using System;

class Program
{
    static void Main()
    {
        // Створення об'єкта квадратного рівняння
        QuadraticEquation equation = new QuadraticEquation(1, -2, -12);
        
        // Виведення розв'язків
        equation.PrintSolutions();
        
        // Отримання розв'язків через індексатор
        Console.WriteLine($"Перший розв'язок: {equation[0]}");
        Console.WriteLine($"Другий розв'язок: {equation[2]}");
        
        // Введення нових коефіцієнтів
        equation.InputCoefficients();
        equation.PrintSolutions();
    }
}