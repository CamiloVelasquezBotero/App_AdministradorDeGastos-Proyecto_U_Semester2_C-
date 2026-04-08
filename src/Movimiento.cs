using System;

public class Movimiento {
    public string Categoria;
    public string Descripcion;
    public decimal Monto;

    public Movimiento(string categoria, string descripcion, decimal monto) {
        Categoria = categoria;
        Descripcion = descripcion;
        Monto = monto;
    }
}