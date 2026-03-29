
﻿class HaloGeneric
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

﻿class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: " + data);
    }
}

//public class Program
//{
//    public static void Main(String[] args)
//    {
//        DataGeneric<long> data = new DataGeneric<long>(103022400090);
//        data.PrintData();
//    }
//}

