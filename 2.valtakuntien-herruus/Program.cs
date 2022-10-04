internal class Program
{
    private static void Main(string[] args)
    {
       Console.Write("Kuinka paljon maatiloja sulla on: ");
       int maatila = Convert.ToInt32(Console.ReadLine());

       Console.Write("Kuinka paljon hettuakuntoja sulla on: ");
       int harttuakunta = Convert.ToInt32(Console.ReadLine());

       Console.Write("Kuinka paljon maakuntoja sulla on: ");
       int maakunta = Convert.ToInt32(Console.ReadLine());

        // maatila = 1 piste, harttuakunta = 3 pistetta, maakunta = 6 pistatta
       int pisteet = maatila + (harttuakunta * 3) + (maakunta * 6);

       Console.WriteLine($"Pelaajalla on {pisteet} piste(-ttä)");

    }
}