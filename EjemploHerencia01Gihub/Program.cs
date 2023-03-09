namespace EjemploHerencia01Gihub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1;
            Mamifero mamifero1;
            Aves pajaro;

            animal1 = new Animal();
            mamifero1 = new Mamifero();
            pajaro = new Aves();

            Console.WriteLine(animal1.TipoAlimentacion());
            Console.WriteLine(mamifero1.TipoAlimentacion());
            Console.WriteLine(pajaro.TipoAlimentacion());

            Console.WriteLine(animal1.Nombre);
            Console.WriteLine(mamifero1.Nombre);
            Console.WriteLine(pajaro.Nombre);
        }
    }
}