using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopciones
{
    class Menu
    {
        GeneradorSingleton generadorSingleton=GeneradorSingleton.generarGenerador();

        private BaseDatosSingleton baseDatos = BaseDatosSingleton.generarSingleton();
        private Impresora impresora = Impresora.generarImpresora();
        public void iniciarMenu(){
            
            int opcion=0;
            do {
                Console.Clear();
                Console.WriteLine("---------------------------------------Menú------------------------------------");
                Console.WriteLine("1)Dar en adopción una mascota");
                Console.WriteLine("2)Registrar mascota");
                Console.WriteLine("3)Registrar usuario");
                Console.WriteLine("4)Mostrar mascotas registradas");
                Console.WriteLine("5)Mostrar personas registradas");
                Console.WriteLine("6)Mostrar historial de adopciones");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion) {
                    case 1:
                        if (baseDatos.clienteLista.Count == 0)
                        {
                            baseDatos.clienteLista = generadorSingleton.generarClientes();
                        }
                        if (baseDatos.mascotaLista.Count==0) {
                            baseDatos.mascotaLista=generadorSingleton.generarMascotas();
                        }
                            Console.WriteLine("Escribe el identificador del cliente");
                           impresora.imprimirClientes(baseDatos.clienteLista);
                            int idCliente = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe el identificador de la mascota");
                            impresora.imprimirMascotas(baseDatos.mascotaLista);
                            int idMascota = int.Parse(Console.ReadLine());
                       
                         
                            baseDatos.clienteAdopta.Add(baseDatos.clienteLista[idCliente]);
                        baseDatos.mascotaAdoptada.Add(baseDatos.mascotaLista[idMascota]);
                        baseDatos.clienteLista.Remove(baseDatos.clienteLista[idCliente]);
                        baseDatos.mascotaLista.Remove(baseDatos.mascotaLista[idMascota]);
                            Console.WriteLine("Adopcion realizada con exito");
                            Console.ReadLine();

                        break;
                    case 2:
                        formularioMascota();
                        break;
                    case 3:
                        formularioPersona();
                        break;
                    case 4:
                        impresora.imprimirMascotas(baseDatos.mascotaLista);
                        Console.ReadLine();
                        break;
                    case 5:
                        impresora.imprimirClientes(baseDatos.clienteLista);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        impresora.imprimirAdopciones(baseDatos.mascotaAdoptada, baseDatos.clienteAdopta);
                        Console.ReadLine();
                        break;
                }
            } while (opcion!=7);
        }
        private void registrarCliente(String nombre,String apellido,int edad,Boolean sexo) {
            baseDatos.clienteLista.Add(new Cliente(nombre,apellido,edad,sexo));
        }
        private void registrarMascota(String nombre, String raza, int edad, Boolean sexo)
        {
            baseDatos.mascotaLista.Add(new Mascota(nombre, raza, edad, sexo));
        }

        private void formularioMascota() {
            Console.Clear();
            Console.WriteLine("FORMULARIO MASCOTA");
            Console.WriteLine("Nombre:");
            String nombre = Console.ReadLine();
            Console.WriteLine("raza:");
            String raza = Console.ReadLine();
            Console.WriteLine("edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("sexo(Macho/Hembra):");
            Boolean sexo;
            if (Console.ReadLine() == "Macho")
            {
                sexo = true;
            }
            else {
                sexo = false;
            }
            registrarMascota(nombre,raza,edad,sexo);
        }
        private void formularioPersona()
        {
            Console.Clear();
            Console.WriteLine("FORMULARIO MASCOTA");
            Console.WriteLine("Nombre:");
            String nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            String raza = Console.ReadLine();
            Console.WriteLine("Edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("sexo(Hombre/Mujer):");
            Boolean sexo;
            if (Console.ReadLine() == "Macho")
            {
                sexo = true;
            }
            else
            {
                sexo = false;
            }
            registrarCliente(nombre, raza, edad, sexo);
        }
    }
}
