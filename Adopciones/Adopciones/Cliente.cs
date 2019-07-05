using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopciones
{
    class Cliente
    {
        private String nombre;
        private String apellido;
        private int edad;
        private Boolean sexo;
        public Cliente(String nombre,String apellido,int edad,Boolean sexo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
        }
        public String getNombre()
        {
            return nombre;
        }
        public String getApellido()
        {
            return apellido;
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
