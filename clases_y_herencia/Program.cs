// See https://aka.ms/new-console-template for more information
/* Clases*/
// var rect = new Rectangulo();
// rect.Base = 20;
// rect.Altura = 40;
// Console.WriteLine($"EL  area es : {rect.Area()}");
// Console.WriteLine($"EL  perimetro es : {rect.Perimetro()}");
/*End Clases*/

// Acá se Solicita al usuario que ingrese la base y la altura del cuadrado

double baseCuadrado, alturaCuadrado;

        // Bucle para solicitar la base del cuadrado al usuario
        while (true)
        {
            Console.WriteLine("Ingrese la base del cuadrado (ingrese una letra para salir):");
            string input = Console.ReadLine();

            // Intentar convertir la entrada en un número
            if (!double.TryParse(input, out baseCuadrado))
            {
                // Si no se puede convertir, salir del bucle
                Console.WriteLine("¡Hasta luego!");
                return;
            }

            // Si la entrada es válida, continuar
            break;
        }

        // Bucle para solicitar la altura del cuadrado al usuario
        while (true)
        {
            Console.WriteLine("Ingrese la altura del cuadrado (ingrese una letra para salir):");
            string input = Console.ReadLine();

            // Intentar convertir la entrada en un número
            if (!double.TryParse(input, out alturaCuadrado))
            {
                // Si no se puede convertir, salir del bucle
                Console.WriteLine("¡Hasta Pronto!");
                return;
            }

            // Si la entrada es válida, continuar
            break;
        }


// Acá se Crea el objeto Cuadrado con las dimensiones proporcionadas por el usuario
var cuadr = new Cuadrado();
cuadr.Base = baseCuadrado;
cuadr.Altura = alturaCuadrado;

//Mostrando Resultados
Console.WriteLine($"EL  area es : {cuadr.Area()}");
Console.WriteLine($"EL  perimetro es : {cuadr.Perimetro()}");
Console.WriteLine($"EL  lado es : {cuadr.Lado}");

class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * Base + 2 * Altura;
}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }

    }
}

