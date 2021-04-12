using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyectoclases
{
    class ambientes
    {
        //atributos

        public double largo { get; set; }
        public double ancho { get; set; }
        public string nombreambiente { get; set; }
        public string colorambiente { get; set; }
        public int cantventanas { get; set; }
        public int cantpuertas { get; set; }

        //métodos

        public ambientes(double largo, double ancho,  string nombreambiente, string colorambiente, int cantventanas, int cantpuertas)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.nombreambiente = nombreambiente;
            this.colorambiente = colorambiente;
            this.cantventanas = cantventanas;
            this.cantpuertas = cantpuertas;
        }

        public override string ToString()
        {
            return  " nombre de la habitación: " + this.nombreambiente + "\n color de la habitacion:" +this.colorambiente + " \n cant puertas:" + this.cantpuertas + "\n cant ventanas:" + this.cantventanas + "\n medidas largo x ancho: " + this.largo + "x" + this.ancho;
        }

    }
    class cocina : ambientes
    { 
        //atributos
        public string artefacto1 { get; set; }
        public string artefacto2 { get; set; }
        public string artefacto3 { get; set; }
        public string mueble1 { get; set; }
        public string mueble2 { get; set; }
        public string mueble3 { get; set; }
        
        //métodos
        public cocina(double largo, double ancho, string nombreambiente, string colorambiente, int cantventanas, int cantpuertas, string a1, string a2, string a3, string m1, string m2, string m3)
            : base(largo, ancho, nombreambiente, colorambiente, cantventanas , cantpuertas)
        {
            this.artefacto1 = a1;
            this.artefacto2 = a2;
            this.artefacto3 = a3;
            this.mueble1 = m1;
            this.mueble2 = m2;
            this.mueble3 = m3;
        }

        public override string ToString()
        {
            return base.ToString() + this.artefacto1 + this.artefacto2 + this.artefacto3 + mueble1 + mueble2 + mueble3;
        }

    }

    class baño1 : ambientes
    { 
        //atributos
        public string artefacto1 { get; set; }
        public string artefacto2 { get; set; }
        public string artefacto3 { get; set; }
        
        //métodos

        public baño1(double largo, double ancho, string nombreambiente, string colorambiente, int cantventanas, int cantpuertas, string a1, string a2, string a3)
            : base(largo, ancho, nombreambiente, colorambiente, cantventanas, cantpuertas)
        {
            this.artefacto1 = a1;
            this.artefacto2 = a2;
            this.artefacto3 = a3;
        }
        public override string ToString()
        {
            return base.ToString() + "\n artefactos:\n -" + artefacto1 + "\n -" + artefacto2 +"\n -"+ artefacto3;
        }
    }

    

    class dormitorio1 : ambientes
    {  // atributos
        public string mueble1 { get; set; }
        public string mueble2 { get; set; }
        public string mueble3 { get; set; }

        //métodos

        public dormitorio1(double largo, double ancho, string nombreambiente, string colorambiente, int cantventanas, int cantpuertas,string m1, string m2, string m3)
            : base(largo, ancho, nombreambiente, colorambiente, cantventanas, cantpuertas)
        {
            this.mueble1 = m1;
            this.mueble2 = m2;
            this.mueble3 = m3;
        }
        public override string ToString()
        {
            return base.ToString()+ mueble1 + mueble2 + mueble3;
        }
    }

    class jardin : ambientes
    {
        // atributos
        public string mueble1 { get; set; }
        public string mueble2 { get; set; }
        public string mueble3 { get; set; }
        public string tiposuelo { get; set; }
        public string ubicacion { get; set; }

        //métodos

        public jardin(double largo, double ancho, string nombreambiente, string colorambiente, int cantventanas, int cantpuertas,string m1, string m2, string m3, string tiposuelo, string ubicacion)
            : base(largo, ancho, nombreambiente, colorambiente, cantventanas, cantpuertas)
        {
            this.mueble1 = m1;
            this.mueble2 = m2;
            this.mueble3 = m3;
            this.tiposuelo = tiposuelo;
            this.ubicacion = ubicacion;
        }
        public override string ToString()
        {
            return base.ToString()+ mueble1 + mueble2 + mueble3 + tiposuelo + ubicacion;
        }
    }

    class garage : ambientes
    {
        
        // atributos
        public string mueble1 { get; set; }
        public string mueble2 { get; set; }
        public string mueble3 { get; set; }
        public string tiposuelo { get; set; }
        public string ubicacion { get; set; }

        //métodos

        public garage(double largo, double ancho, string nombreambiente, string colorambiente, int cantventanas, int cantpuertas,string m1, string m2, string m3, string tiposuelo, string ubicacion)
            : base(largo, ancho, nombreambiente, colorambiente, cantventanas, cantpuertas)
        {
            this.mueble1 = m1;
            this.mueble2 = m2;
            this.mueble3 = m3;
            this.tiposuelo = tiposuelo;
            this.ubicacion = ubicacion;
        }
        public override string ToString()
        {
            return base.ToString()+ mueble1 + mueble2 + mueble3 + tiposuelo + ubicacion;
        }
    }

    class quincho : ambientes
    { 
        // atributos
        public string mueble1 { get; set; }
        public string mobiliario { get; set; }
        
        public string tiposuelo { get; set; }
        public string ubicacion { get; set; }

        //métodos

        public quincho(double largo, double ancho, string nombreambiente, string colorambiente, int cantventanas, int cantpuertas,string m1, string m2, string tiposuelo, string ubicacion)
            : base(largo, ancho, nombreambiente, colorambiente, cantventanas, cantpuertas)
        {
            this.mueble1 = m1;
            this.mobiliario = m2;
            this.tiposuelo = tiposuelo;
            this.ubicacion = ubicacion;
        }
        public override string ToString()
        {
            return base.ToString()+ mueble1 + mobiliario+ tiposuelo + ubicacion;
        }
    }

}
