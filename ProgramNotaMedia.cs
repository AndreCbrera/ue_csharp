Console.WriteLine("Sacar nota media");

Console.Write("Introduce la nota nº 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Introduce la nota nº 2: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Introduce la nota nº 3: ");
int num3 = int.Parse(Console.ReadLine());

int media = (num1 + num2 + num3) / 3;

Console.WriteLine("La media es: " + media);