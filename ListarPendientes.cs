using System;
using System.Collections.Generic;

namespace GestorPendientes;

public static class ListarPendientes
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        Console.WriteLine("\n--- Lista de Pendientes ---");

        // Informar si la lista está vacía, sin modificarla
        if (pendientes == null || pendientes.Count == 0)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        // Mostrar identificador, descripción y estado
        foreach (var p in pendientes)
        {
            Console.WriteLine($"Identificador: {p.Identificador} | Descripción: {p.Descripcion} | Estado: {p.Estado}");
        }
    }
}
