using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopciones
{
    class Mascota
    {
        private String nombre;
        private String raza;
        private int edad;
        private Boolean sexo;
        public Mascota(String nombre, String raza, int edad, Boolean sexo)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
            this.sexo = sexo;
        }
        public String getNombre()
        {
            return nombre;
        }
        public String getRaza()
        {
            return raza;
        }
        public int getEdad()
        {
            return edad;
        }
        public Boolean getSexo()
        {
            return sexo;
        }
    }
}
