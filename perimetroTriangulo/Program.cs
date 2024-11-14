// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos a calcular el perímetro de un Triángulo");

// Lado 1
Console.WriteLine("Introduce primer lado del triángulo:");
double l1 = Convert.ToDouble(Console.ReadLine());

// Lado 2
Console.WriteLine("Introduce segundo lado del triángulo");
double l2 = Convert.ToDouble(Console.ReadLine());

// Lado 3
Console.WriteLine("Introduce tercer lado del triángulo");
double l3 = Convert.ToDouble(Console.ReadLine());

// Calculamos el perímetro sumando sus lados
double perimetro = l1 + l2 + l3;

// Redondeamos para tener un numero más corto
perimetro = Math.Round(perimetro, 2);

Console.WriteLine("El perímetro del triángulo es: " + perimetro);