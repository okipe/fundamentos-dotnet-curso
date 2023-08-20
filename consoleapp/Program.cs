using Humanizer;

Console.Write("Por favor, ingrese un nombre: ");
var nombre = Console.ReadLine();
Console.Write("Por favor, ingrese su cargo: ");
var cargo = Console.ReadLine();
Console.Write("Por favor, ingrese su edad: ");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre}, trabajo como {cargo} y tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años.");