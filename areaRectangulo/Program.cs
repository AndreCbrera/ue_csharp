// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos a calcular el área de un Rectangulo");

// Pedimos al usuario el ancho del rectángulo
Console.WriteLine("Introduce el ancho del rectángulo:");
double ancho = Convert.ToDouble(Console.ReadLine());

// Pedimos al usuario la altura del rectángulo
Console.WriteLine("Introduce la altura del rectángulo:");
double altura = Convert.ToDouble(Console.ReadLine());

// Calculamos el área del rectángulo
double area = ancho * altura;
Console.WriteLine("El área del rectángulo es: " + area);