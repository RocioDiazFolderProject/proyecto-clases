using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyectoclases
{
    class familia // superclase familia
    { //atributos
        public string clase { get; set; }
        public string dieta { get; set; }

        //métodos

        public familia(string clase, string dieta)
        {
            this.clase = clase;
            this.dieta = dieta;

        }
        public override string ToString()
        {
            return this.clase  + this.dieta;
        }
    }
    class animal : familia //subclase animal
    { 
        //atributos
        public string nombre { get; set; }
        public string tipo { get; set; }

        // métodos

        public animal(string clase, string dieta, string n, string t)
            : base(clase, dieta)
        {
            this.nombre = n;
            this.tipo = t;
            
        }
        private string mostrar()
        {
            return  this.nombre  + this.tipo;
        }
        public override string ToString()
        {
            return base.ToString() + mostrar(); 
        }

    }

    class Domestico : animal// subclase domestico de la superclase animal
    {
        //atributos
        public int edad { get; set; }

        //métodos

        public Domestico(string clase, string dieta, string n, string t, int edad)
            : base(clase, dieta, n, t)
        {
            this.edad = edad;
        }
        public override string ToString()
        {
            return base.ToString() +  this.edad;
        }
    }

    class Salvaje : animal // subclase salvaje de la superclase animal
    { 
        //atributos
        public string origen { get; set; }


        //métodos

        public Salvaje(string clase, string dieta, string n, string t, string origen)
            : base(clase, dieta, n, t)
        {
            this.origen = origen;
        }
        public override string ToString()
        {
            return base.ToString()+ this.origen;
        }
    }

}
