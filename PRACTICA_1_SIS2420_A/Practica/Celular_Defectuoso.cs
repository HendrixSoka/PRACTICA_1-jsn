using System;
namespace Practica
{
    public class Celular_Defectuoso :Celular
{
    private DateTime fecha_Defecto;
    public DateTime Fecha_Defecto { get => fecha_Defecto; set => fecha_Defecto = value; }
    public string motivo { get; set; }
    
    public Celular_Defectuoso(string marca, int modelo, bool so, int ram, int almacenamiento, DateTime fecha_defecto, string Motivo)
	{
        Marca = marca;
        Modelo = modelo;
        this.S0 = so;
        this.setS();

            RAM = ram;
        Almacenamiento = almacenamiento;
        fecha_Defecto = fecha_defecto;
        motivo = Motivo;
    }
    public override void mostrarCelular()
    {
        string informacionCelular = $"Marca: {Marca}\nModelo: {Modelo}\nSistema Operativo: {this.getS()}\nRAM: {RAM} GB\nAlmacenamiento: {Almacenamiento} GB\nmotivo: {motivo}\nFecha de Ingreso: {fecha_Defecto}";
        Console.WriteLine("Información del celular:");
        Console.WriteLine(informacionCelular);
    }
}
}
