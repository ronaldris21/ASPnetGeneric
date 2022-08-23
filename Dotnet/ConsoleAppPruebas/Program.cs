﻿public class SchoolClass
{
    public string Name { get; set; }
    public int CantEstudiantes { get; set; }
    public SchoolClass(string Nombre, int Cant) => (Name, CantEstudiantes) = (Nombre, Cant);
    
}
public class WithExpressionBasicExample
{
    public record School(string name, int cantEstudiantes);
    public record NamedPoint(string Name, int X, int Y, School escuela);

    public static void Main()
    {

        var escuelita = new SchoolClass( "Leopoldo Mayen Torres", 548);
        Console.WriteLine($"{nameof(escuelita)}: {escuelita}"); 



        var p1 = new NamedPoint("A", 0, 0, new School("Leopoldo Mayen Torres",548));
        Console.WriteLine($"{nameof(p1)}: {p1}");  // output: p1: NamedPoint { Name = A, X = 0, Y = 0 }

        var p2 = p1 with { Name = "B", X = 5 };
        Console.WriteLine($"{nameof(p2)}: {p2}");  // output: p2: NamedPoint { Name = B, X = 5, Y = 0 }

        var p3 = p1 with
        {
            Name = "C",
            Y = 4
        };
        Console.WriteLine($"{nameof(p3)}: {p3}");  // output: p3: NamedPoint { Name = C, X = 0, Y = 4 }

        Console.WriteLine($"{nameof(p1)}: {p1}");  // output: p1: NamedPoint { Name = A, X = 0, Y = 0 }

        var apples = new { Item = "Apples", Price = "1.19" };
        Console.WriteLine($"original apples: {apples}");
        var saleApples = apples with { Price = "0.79" };
        Console.WriteLine($"sale apples: {saleApples}");

    }
}