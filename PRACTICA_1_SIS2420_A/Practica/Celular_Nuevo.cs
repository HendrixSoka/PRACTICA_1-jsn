using System;
namespace Practica
{
    public class Celular_Nuevo : Celular
    {
        private DateTime fecha_Ingreso;
        public DateTime Fecha_Ingreso { get => fecha_Ingreso; set => fecha_Ingreso = value; }
        public double precio { get; set; }
        public Celular_Nuevo(string marca, int modelo, bool so, int ram, int almacenamiento, DateTime fecha_ingreso, double Precio)
        {
            Marca = marca;
            Modelo = modelo;
            this.S0 = so;
            this.setS();
            RAM = ram;
            Almacenamiento = almacenamiento;
            fecha_Ingreso = fecha_ingreso;
            precio = Precio;

        }
        public override void mostrarCelular()
        {
            string informacionCelular = $"Marca: {Marca}\nModelo: {Modelo}\nSistema Operativo: {this.getS()}\nRAM: {RAM} GB\nAlmacenamiento: {Almacenamiento} GB\nPrecio: {precio}\nFecha de Ingreso: {fecha_Ingreso}";
            Console.WriteLine("Información del celular:");
            Console.WriteLine(informacionCelular);
        }

    }
}