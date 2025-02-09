using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        List<string> kahveler = new List<String>();

        Console.WriteLine("lütfen 5 kahve ismi giriniz");
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"kahve {i}:");
            string kahve = Console.ReadLine();
            kahveler.Add(kahve);
        }
        Console.WriteLine("girilen kahveler:");
        foreach (string kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}



