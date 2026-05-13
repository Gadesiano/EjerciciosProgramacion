using EjerciciosProgramacion;

var ejercicios = new List<IEjercicio>
{
    new EjerciciosProgramacion.Fundamentos.Ejercicio00(),
    new EjerciciosProgramacion.Fundamentos.Ejercicio01(),
    new EjerciciosProgramacion.Fundamentos.Ejercicio02()
};

if (ejercicios.Count == 0)
{
    Console.WriteLine("No hay ejercicios disponibles TODAVÍA...");
    return;
}

Console.WriteLine("=== EJERCICIOS DE PROGRAMACIÓN ===\n");

for (int i = 0; i < ejercicios.Count; i++)
{
    Console.WriteLine($"{i + 1}.- {ejercicios[i].Titulo}");
}

Console.Write("\nSelecciona un ejercicio: ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int seleccion) || seleccion < 1 || seleccion > ejercicios.Count)
{
    Console.WriteLine("Opción no válida.");
    return;
}

Console.WriteLine($"\n--- {ejercicios[seleccion-1].Titulo} ---\n");
ejercicios[seleccion-1].Run();