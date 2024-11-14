// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saber si un numero es mayor o igual");

// Pedimos al usuario el que introduzca el primer número
Console.WriteLine("Introduce el primero número:");
double num1 = Convert.ToDouble(Console.ReadLine());

// Pedimos al usuario el que introduzca el segundo número
Console.WriteLine("Introduce el segundo número:");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2) {
    Console.WriteLine("El número " + num1 + " es mayor que " + num2);
} else if(num2 == num1) {
    Console.WriteLine("Los números " + num1 + " y " + num2 + " son iguales");
} else {
    Console.WriteLine("El número " + num2 + " es mayor que " + num1);
}