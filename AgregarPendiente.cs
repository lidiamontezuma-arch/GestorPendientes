namespace GestorPendientes;

public static class AgregarPendiente
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        Console.Write("Escribe la descripción del pendiente: ");
        string? descripcion = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(descripcion))
        {
            Console.WriteLine("La descripción no puede estar vacía.");
            Console.Write("Escribe la descripción del pendiente: ");
            descripcion = Console.ReadLine();
        }

        Pendiente nuevoPendiente = new Pendiente(descripcion);

        pendientes.Add(nuevoPendiente);

        Console.WriteLine(
            $"Pendiente agregado correctamente. ID: {nuevoPendiente.Identificador}");
    }
}

