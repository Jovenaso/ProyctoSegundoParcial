using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopciones
{
    class GeneradorSingleton
    {
        public List<Cliente> clienteLista = new List<Cliente>();
        public List<Mascota> mascotaLista = new List<Mascota>();
        private static GeneradorSingleton generadorSingleton = null;
        public static GeneradorSingleton generarGenerador() {

            if (generadorSingleton == null) {
                generadorSingleton = new GeneradorSingleton();
            }
            return generadorSingleton;
        }
        public List<Mascota> generarMascotas() {
            mascotaLista.Add(new Mascota("Pinky", "Zanahoria", 33, false));
            mascotaLista.Add(new Mascota("Coaqueta", "guau guau", 33, false));
            mascotaLista.Add(new Mascota("PinkFloyd", "Zanahoria2", 33, false));
            mascotaLista.Add(new Mascota("Wiwino", "Coquer Spaniel", 33, false));
            mascotaLista.Add(new Mascota("Gatituu", "Gato", 33, false));
            return mascotaLista;
        }
        public List<Cliente> generarClientes()
        {
            clienteLista.Add(new Cliente("Jorge", "Arevalo", 33, false));
            clienteLista.Add(new Cliente("Ivan", "Alejandro", 33, false));
            clienteLista.Add(new Cliente("Black Sabbath", "Zanahoria2", 33, false));
            clienteLista.Add(new Cliente("Wiwino", "aaaaa", 33, false));
            clienteLista.Add(new Cliente("Gatituu", "Gato", 33, false));
            return clienteLista;
        }

    }
}
