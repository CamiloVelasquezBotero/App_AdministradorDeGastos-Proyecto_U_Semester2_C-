using System;
using System.Collections.Generic;

public class Movimientos
{
    public static List<Movimiento> gastos = new List<Movimiento>();

    public static decimal RegistrarIngreso(decimal saldo)
    {
        string categoria;
        string descripcion;
        decimal monto;

        Console.Write("Ingrese el monto del ingreso (COP): ");
        monto = Convert.ToDecimal(Console.ReadLine());

        if (monto <= 0)
        {
            Console.WriteLine("Error: el monto debe ser mayor que 0");
            return saldo;
        }

        Console.Write("Ingrese la categoria del ingreso: ");
        categoria = Console.ReadLine();

        Console.Write("Descripcion del ingreso: ");
        descripcion = Console.ReadLine();

        saldo = saldo + monto;

        Console.WriteLine("\nIngreso registrado correctamente");
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Descripcion: " + descripcion);
        Console.WriteLine("Monto: " + monto + " COP");
        Console.WriteLine("Saldo actual: " + saldo + " COP");

        return saldo;
    }

    public static decimal RegistrarGasto(decimal saldo)
    {
        string categoria = "";
        string descripcion = "";
        decimal monto;

        Console.Write("Ingrese el monto del gasto (COP): ");
        monto = Convert.ToDecimal(Console.ReadLine());

        if (monto <= 0)
        {
            Console.WriteLine("Error: el monto debe ser mayor que 0");
            return saldo;
        }

        // Pedimos la categoria
        while(categoria == "") {
            Console.Write("Ingrese la categoria del gasto: ");
            categoria = Console.ReadLine();
        };

        // Pedimos la Descripcion
        while(descripcion == "") {
            Console.Write("Descripcion del gasto: ");
            descripcion = Console.ReadLine();
        };

        // Guardamos el gasto la lista
        Movimiento movimiento = new Movimiento(categoria, descripcion, monto);
        gastos.Add(movimiento);

        saldo = saldo - monto;

        if (monto > 200000)
        {
            Console.WriteLine("Advertencia: gasto alto detectado");
        }

        if (saldo < 0)
        {
            Console.WriteLine("Alerta: saldo negativo");
        }

        Console.WriteLine("\nGasto registrado correctamente");
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Descripcion: " + descripcion);
        Console.WriteLine("Monto: " + monto + " COP");
        Console.WriteLine("Saldo actual: " + saldo + " COP");

        return saldo;
    }

    public static void VerGastos() {
        if(gastos.Count == 0) {
            Console.WriteLine("\nNo hay gastos registrados");
            return;
        }

        Console.WriteLine("\n===== HISTORIAL DE GASTOS =====");
        foreach(Movimiento mov in gastos) {
            Console.WriteLine("=================//=================");
            Console.WriteLine("Categoria: " + mov.Categoria);
            Console.WriteLine("Descripcion: " + mov.Descripcion);
            Console.WriteLine("Monto: " + mov.Monto + "COP\n");
        }
    }
}
