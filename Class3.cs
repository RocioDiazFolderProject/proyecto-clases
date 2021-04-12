using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyectoclases
{
    class perfilPersona //superclase persona
    { //atributos

        public string nombre { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public DateTime fechaNac { get; set; }

        //métodos

        public perfilPersona(string nombre, string sexo, int edad, DateTime fechNac)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.fechaNac = fechNac;
        }
        //public string mostrarPersona()
        //{
        //return "Nombre de la persona:\n" + this.nombre + ",sexo:\n" + this.sexo + "\n edad" + this.edad + "años" + "\n Fecha de Nacimiento:" + this.fechaNac;
        //
        //}
        public override string ToString()
        {
            return "nombre       Fem/Masc        Edad         Fecha Nac    \n" +this.nombre + this.sexo + "       " +this.edad +"años" +"      " +this.fechaNac;
        }


    }
    class padre : perfilPersona //subclase padre de la superclase persona
    {
        //atributos
        public string trabajo { get; set; }

        //métodos

        public padre(string nombre, string sexo, int edad, DateTime fechaNac, string trabajo)
            : base(nombre, sexo, edad, fechaNac)
        {
            this.trabajo = trabajo;
        }
        public override string ToString()
        {
            return base.ToString() + " trabajo: " + this.trabajo;
        }
      }

    class hijo : perfilPersona // subclase hijo de la superclase persona 
    { 
        //atributos
        public string escuela { get; set; }

        //métodos
        public hijo(string nombre, string sexo, int edad, DateTime fechaNac, string escuela)
            : base(nombre, sexo, edad, fechaNac)
        {
            this.escuela = escuela;
        }

        public override string ToString()
        {
            return base.ToString()+ "escuela" + this.escuela;
        }
    }


}



    