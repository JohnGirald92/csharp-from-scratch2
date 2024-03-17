namespace HelloWorld
{
    class Program
    {


        static void Main()
        {
            /* Data Type*/
            DateOnly dateCoverted = new DateOnly();
            string nameImput;
            string BirthdayImput;
            Console.WriteLine("¡Hola Bienvenido al Calculador de Años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameImput = Console.ReadLine();
            Console.WriteLine($"¡Un Gusto Conocerte  {nameImput}!");
            Console.WriteLine("Escribe tu Fecha de Nacimiento en formato dd/mm/yy: ");
            BirthdayImput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(BirthdayImput, out dateCoverted);
            if (isDateValid == false) Console.WriteLine($"La Fecha de Nacimeinto es Inválida, usted nos envió este dato erronéo {BirthdayImput} ");
            var Person = new Person
            {
                Name = nameImput,
                Birthday = dateCoverted,
                Age = DateTime.Now.Year - dateCoverted.Year

            };

            Console.WriteLine($"Tú Nombre  {Person.Name}!");  
            Console.WriteLine($"Tú Fecha de Nacimiento: {Person.Birthday}");  
            Console.WriteLine($"¡Tú Edad es: {Person.Age} años!");  


            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}