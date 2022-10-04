internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Syötä kalan määrä: ");
        int fish = Convert.ToInt32(Console.ReadLine());

        int fishForCat = fish % 4;
        int fishForBear = (fish - fishForCat) / 4;
        var karhunKala = fishForBear > 1 ? "kalaa" : "kala" ;
        var kissanKala = fishForCat > 1 ? "kalaa" : "kala";
        // kissa saa enemmän kalan määrä 1,2,3,6,11 kalaa.

        Console.WriteLine($"Kahut saavat {fishForBear} {karhunKala} ja kissa saa {fishForCat} {kissanKala}");
    }

}