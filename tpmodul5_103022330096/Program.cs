using System;

public class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input nama: ");
        string nama = Console.ReadLine();
        HaloGeneric.SapaUser(nama);
    }
}