using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopciones
{
    class Impresora
    {
        private static Impresora impresora=null;
        private Impresora() {}
        public static Impresora generarImpresora() {
            if (impresora==null) {
                impresora = new Impresora();
            }

            return impresora;
        }
        public void imprimirClientes(List<Cliente> cliente) {
            for (int x=0;x<cliente.Count;x++) {
                Console.WriteLine("Identificador: "+x);
                Console.WriteLine("Nombre: "+cliente[x].getNombre());
                Console.WriteLine("Apellido: "+cliente[x].getApellido());
                Console.WriteLine("Edad: "+cliente[x].getEdad());
                Console.WriteLine("Sexo: "+cliente[x].getSexo());
            }
        }
        public void imprimirMascotas(List<Mascota> Mascota) {
            for (int x=0;x<Mascota.Count;x++) {
                Console.WriteLine("Identificador: " + x);
                Console.WriteLine("Nombre: " + Mascota[x].getNombre());
                Console.WriteLine("Raza: " + Mascota[x].getRaza());
                Console.WriteLine("Edad: " + Mascota[x].getEdad());
                Console.WriteLine("Sexo: " + Mascota[x].getSexo());
            }
        }
        public void imprimirAdopciones(List<Mascota> Mascota, List<Cliente> cliente) {
            for (int x = 0; x < Mascota.Count; x++)
            {
                Console.WriteLine("Identificador: " + x);
                Console.WriteLine(cliente[x].getNombre() +" ha adoptado a "+ Mascota[x].getNombre());
            }
        }
    }
}
