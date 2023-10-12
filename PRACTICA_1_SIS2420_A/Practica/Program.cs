using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static string[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        static string[] decenas = { "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        static string[] especiales = { "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };

        static string NumS(int num)
        {
            if (num >= 0 && num <= 9)
            {
                return unidades[num];
            }
            else if (num >= 11 && num <= 19)
            {
                return especiales[num - 11];
            }
            else if (num % 10 == 0)
            {
                return decenas[num / 10 - 1];
            }
            else
            {
                return $"{decenas[num / 10 - 1]} y {unidades[num % 10]}";
            }
        }
        static void mostrarL(List<int> lista)
        {
            foreach (var valor in lista)
            {
                Console.Write(valor+" ");
            }
        }
        static void mostrarLCell(List<Celular_Nuevo> lista)
        {
            Console.WriteLine("Lista Celulares Nuevos");
            foreach (var valor in lista)
            {
                valor.mostrarCelular();
            }
        }
        static void CelularRSA(List<Celular_Nuevo> lista)
        {
            var resultados = from celular in lista
                             where celular.RAM == 8 && celular.getS() == "Android" && celular.Almacenamiento == 128
                             select celular;
            Console.WriteLine("Celulares con RAM=8, SO=Android y Almacenamiento=128:");

            foreach (var celular in resultados)
            {
                Console.WriteLine($"Marca: {celular.Marca}, Modelo: {celular.Modelo}");
            }
        }
        void CelularIngreso(List<Celular_Nuevo> lista)
        {
            var resultados = from celular in lista
                             where celular.Fecha_Ingreso.Year == 2005
                             select celular;

            Console.WriteLine("Celulares con fecha de ingreso en el año 2005:");
            foreach (var celular in resultados)
            {
                Console.WriteLine($"Marca: {celular.Marca}, Modelo: {celular.Modelo}");
            }
        }
        static public List<Celular_Nuevo> Apple(List<Celular_Nuevo> lista)
        {
            var celularesApple = from celular in lista
                                 where celular.Marca == "Apple"
                                 select celular;

            return celularesApple.ToList();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("hola mundo");
            Console.WriteLine(NumS(34));
            Console.WriteLine(NumS(14));
            Console.WriteLine(NumS(4));
            List<int> numbers = new List<int>();
            numbers.Add(18);
            numbers.Add(38);
            numbers.Add(15);
            numbers.Add(8);
            numbers.Add(46);
            numbers.Add(57);
            numbers.Add(99);
            numbers.Add(32);
            numbers.Add(78);
            numbers.Add(66);
            numbers.Add(101);
            numbers.Add(13);
            numbers.Add(28);
            numbers.Add(6);
            Func<List<int>, List<int>> multiplosDeTres = lista => lista.Where(num => num % 3 == 0).ToList();

            Func<List<int>, List<int>> numerosPrimos = lista =>
            {
                bool EsPrimo(int n)
                {
                    if (n <= 1) return false;
                    if (n <= 3) return true;
                    if (n % 2 == 0 || n % 3 == 0) return false;
                    for (int i = 5; i * i <= n; i += 6)
                    {
                        if (n % i == 0 || n % (i + 2) == 0)
                            return false;
                    }
                    return true;
                }
                return lista.Where(EsPrimo).ToList();
            };
            Func<List<int>, List<int>> multiplosDeCinco = lista => lista.Where(num => num % 5 == 0).ToList();

            Func<List<int>, List<int>> numerosPerfectos = lista =>
            {
                bool EsPerfecto(int n)
                {
                    int sumaDivisores = 1;
                    for (int i = 2; i * i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            sumaDivisores += i;
                            if (i != n / i)
                                sumaDivisores += n / i;
                        }
                    }
                    return sumaDivisores == n;
                }
                return lista.Where(EsPerfecto).ToList();
            };

            List<int> multiplosDeTresL = multiplosDeTres(numbers);
            List<int> numerosPrimosL = numerosPrimos(numbers);
            List<int> multiplosDeCincoL = multiplosDeCinco(numbers);
            List<int> numerosPerfectosL = numerosPerfectos(numbers);
            mostrarL(multiplosDeTresL);
            Console.WriteLine();
            mostrarL(numerosPrimosL);
            Console.WriteLine();
            mostrarL(multiplosDeCincoL);
            Console.WriteLine();
            mostrarL(numerosPerfectosL);

            List<Celular_Nuevo> cells = new List<Celular_Nuevo>();
            cells.Add(new Celular_Nuevo("Samsung", 2023, true, 12, 256, DateTime.Now, 799.99));
            cells.Add(new Celular_Nuevo("iPhone", 2024, false, 8, 128, DateTime.Now, 999.99));
            cells.Add(new Celular_Nuevo("Pixel", 2025, true, 6, 64, DateTime.Now, 699.99));
            cells.Add(new Celular_Nuevo("OnePlus", 2026, false, 10, 512, DateTime.Now, 899.99));
            cells.Add(new Celular_Nuevo("Xiaomi", 2027, true, 16, 512, DateTime.Now, 749.99));
            cells.Add(new Celular_Nuevo("Sony", 2028, false, 8, 256, DateTime.Now, 799.99));
            cells.Add(new Celular_Nuevo("LG", 2029, true, 12, 128, DateTime.Now, 699.99));
            cells.Add(new Celular_Nuevo("Asus", 2030, false, 8, 64, DateTime.Now, 649.99));
            cells.Add(new Celular_Nuevo("Nokia", 2031, true, 6, 256, DateTime.Now, 599.99));
            cells.Add(new Celular_Nuevo("Motorola", 2032, false, 12, 512, DateTime.Now, 899.99));
            cells.Add(new Celular_Nuevo("Apple", 2025, false, 8, 256, DateTime.Now, 899.99));
            cells.Add(new Celular_Nuevo("Apple", 2024, false, 8, 128, DateTime.Now, 999.99));

            mostrarLCell(cells);

            Func<List<Celular_Nuevo>, double> promCelular = lista =>
            {
                double sumaDePrecios = lista.Sum(c => c.precio);
                return  sumaDePrecios / lista.Count;
            };
            Func<List<Celular_Nuevo>, List<Celular_Nuevo>> CelMarcaS = lista =>
            {
                return lista.Where(c => c.Marca == "Samsung").ToList();
            };
            Func<List<Celular_Nuevo>, List<Celular_Nuevo>> apple = lista =>
            {
                return lista.Where(c => c.Marca == "Apple").ToList();
            };
            Console.WriteLine("Funciones..................................");
            Console.WriteLine(promCelular(cells));
            List<Celular_Nuevo> samsung = CelMarcaS(cells);
            mostrarLCell(samsung);
            CelularRSA(cells);
            
            List<Celular_Nuevo> manzana = apple(cells);
            Apple(cells);
            Console.ReadKey();

        }
    }
}
