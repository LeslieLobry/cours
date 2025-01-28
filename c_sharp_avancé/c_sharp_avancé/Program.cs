using c_sharp_avancé.classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Dinosaur denver = new Dinosaur();
        Dinosaur petitPieds = new Dinosaur();
        denver.Age = 120;
        denver.Espece = "Corythosaurus";
        Console.WriteLine(denver.Age + denver.Espece);
    }
}


