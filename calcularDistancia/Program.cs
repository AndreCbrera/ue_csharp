Console.WriteLine("Calcular tiempo entre ciudades");

Console.Write("Introduce los kilometros: ");
int kilometros = int.Parse(Console.ReadLine());

Console.Write("Velocidad promedio: ");
int velocidad = int.Parse(Console.ReadLine());

int tiempo = kilometros / velocidad;

Console.WriteLine("Tiempo de demora entre ciudades es: " + tiempo + " horas");

// Faltaria una comprobación de solo introducir numeros y no otros caracteres tipo string etc