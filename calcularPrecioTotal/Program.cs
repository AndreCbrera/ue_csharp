Console.WriteLine("Calcular precio");

Console.WriteLine("Introduce la edad del cliente: ");
int edad = int.Parse(Console.ReadLine()!);

Console.WriteLine("Introduce el precio del producto: ");
decimal precio = decimal.Parse(Console.ReadLine()!);

if( edad <= 18 || edad >= 60 ){
    decimal descuento = precio * 0.15m;
    decimal precioFinal = precio - descuento;
    Console.WriteLine($"La edad del cliente es {edad}. Se ha aplicado un 15% de descuento. Precio original: {precio}, Precio con descuento: {precioFinal:F2}.");
} else {
    decimal precioFinal = precio;
    Console.WriteLine($"La edad del cliente es {edad}. No se aplica descuento. Precio final: {precioFinal:F2}.");
}