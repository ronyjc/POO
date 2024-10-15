using POOEjemplo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido, vamos a crear un objeto de la clase animales");
        Console.WriteLine("Por favor ingrese la especie");
        string especie = Console.ReadLine();
        Console.WriteLine("Por favor ingrese la edad");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Por favor ingrese la clasificación");
        string clasificacion = Console.ReadLine();

        Animales animal1 = new Animales(especie, edad, clasificacion);
        Console.WriteLine("El animal ingresado es: ");
        Console.WriteLine(animal1.getEspecie());
        Console.WriteLine(animal1.getEdad());
        Console.WriteLine(animal1.getClasificacion());
    }
}