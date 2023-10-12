using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public abstract class Celular
    {

        public string Marca { get; set; }
        public int Modelo { get; set; }
        public bool S0 { get; set; }
        private string So;
        public int RAM { get; set; }
        public int Almacenamiento { get; set; }


        public Celular()
        {

        }
        public void setS()
        {
            So = S0 ? "Android" : "IOS";
        }
        public string getS(){
            return So;
        }
        public virtual void mostrarCelular()
        {
            string informacionCelular = $"Marca: {Marca}\nModelo: {Modelo}\nSistema Operativo: {So}\nRAM: {RAM} GB\nAlmacenamiento: {Almacenamiento} GB";
            Console.WriteLine("Información del celular:");
            Console.WriteLine(informacionCelular);

        }


    }
}
