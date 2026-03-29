class HaloGeneric
{
    public void SapaUser<T>(ref T x)
    {
        Console.Write("Halo user " + x);
    }
}

public class Program 
{
    public static void Main(String[] args)
    {
        HaloGeneric hai = new HaloGeneric();
        string nama;

        Console.Write("Input nama User: ");
        nama = Console.ReadLine();

        Console.WriteLine();


        hai.SapaUser<string>(ref nama);
    }
}
