Console.WriteLine("Saber si un número no es múltiplo de 7");

// Pedimos al usuario el que introduzca el primer número
Console.WriteLine("Introduce un número:");
double num = Convert.ToDouble(Console.ReadLine());

if (!(num % 7 == 0)) {
    Console.WriteLine("El número " + num + " no es múltiplo de 7");
} else {
    Console.WriteLine("El número " + num + " es múltiplo de 7");
}