using System.Runtime.InteropServices;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola

            var lstNumeros = new List<int>() { 25,10,99,105, 1, 84, 22};
            var lstNumeroMayor = lstNumeros.Where(w => w > 99);
            foreach (var numero in lstNumeroMayor)
            {
                Console.WriteLine("El numero mayor de la lista es: "+numero);
            }

            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            var lstOrdenAlfabetico = lstNombres.OrderBy(w => w);
            Console.WriteLine("Nombres ordenados alfabéticamente: ");
            foreach (var nombre in lstOrdenAlfabetico)
            {
                
                Console.WriteLine(nombre);
            }

            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            var lstClientesVip = lstClientes.Where(w => w.Vip == true );
            Console.WriteLine("Los clientes VIP son: ");
            foreach (var clienteVip in lstClientesVip)
            {
                Console.WriteLine(clienteVip.Nombre);
            }

            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            var lstNombreClientes = lstClientes.Select( s => s.Nombre);
            Console.WriteLine("El listado completo de clientes es el siguiente: ");
            foreach (var nombres in lstNombreClientes)
            {
                Console.WriteLine(nombres);
            }
            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"
            var lstListaModificada = lstClientes.Select(s => new EdicionCliente
            {
                Nombre = s.Nombre.ToUpper(),    
                Apellido = s.Apellido.ToUpper(),
                Vip = s.Vip ? "Premium" : "Normal"
            }).ToList();
            foreach (var cliente in lstListaModificada)
            {
                Console.WriteLine($"Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Vip: {cliente.Vip}");
            }

            #endregion
        }
    }
}