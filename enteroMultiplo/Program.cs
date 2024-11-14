// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saber si un número entero es múltiplo de 5");

// Pedimos al usuario el que introduzca el primer número
Console.WriteLine("Introduce un número:");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 5 == 0) {
    Console.WriteLine("El número " + num + " es múltiplo de 5");
} else {
    Console.WriteLine("El número " + num + " no es múltiplo de 5");
}