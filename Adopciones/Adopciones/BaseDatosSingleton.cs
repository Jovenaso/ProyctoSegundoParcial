using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopciones
{
   
    class BaseDatosSingleton
    {
        public List<Cliente> clienteAdopta = new List<Cliente>();
        public List<Mascota> mascotaAdoptada = new List<Mascota>();
        public List<Cliente> clienteLista = new List<Cliente>();
        public List<Mascota> mascotaLista = new List<Mascota>();

        private static BaseDatosSingleton baseDatosSingleton =null;
        private BaseDatosSingleton()
        {

        }
        public static BaseDatosSingleton generarSingleton() {
            if (baseDatosSingleton==null) {
                baseDatosSingleton = new BaseDatosSingleton();
             }
            return baseDatosSingleton;

        }

    }
}
