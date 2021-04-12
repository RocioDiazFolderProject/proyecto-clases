using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyectoclases
{
    class comunidad
    {
        //atributos
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string municipio { get; set; }
        public string zona {get; set;}

        // métodos 
        public comunidad(string Provincia, string ciudad, string municipio, string zona)
        {
            this.Provincia = Provincia;
            this.Ciudad = ciudad;
            this.municipio = municipio;
            this.zona = zona;
        }

        public override string ToString()
        {
            return "\n Provincia: " + this.Provincia + "\n Ciudad: " + this.Ciudad + "\n Municipio: " + this.municipio + "\n zona:" + this.zona;
        }

    }
    class barrio : comunidad
    { 
        //atributos

        public string callenorte { get; set; }
        public string callesur { get; set; }
        public string calleoeste { get; set; }
        public string calleeste { get; set; }

        //métodos

        public barrio(string Provincia, string Ciudad, string municipio, string zona, string calleN, string calleS, string calleO, string calleE)
            : base(Provincia, Ciudad, municipio, zona)
        {
            this.callenorte = calleN;
            this.callesur = calleS;
            this.calleoeste = calleO;
            this.calleoeste = calleE;

        }

        public override string ToString()
        {
            return base.ToString() + "\n Límite Norte:" + this.callenorte + "\n Límite Sur:" +this.callesur + "\n Límite Oeste: " + this.calleoeste + "\n Límite Este: " + this.calleeste;
        }

    }

    class domicilio : comunidad
    {
        public string calle { get; set; }
        public long nrocasa { get; set; }
        public int piso { get; set; }
        public string dpto { get; set; }

        public domicilio(string Provincia, string ciudad, string municipio, string zona, string calle, long nrocasa, int piso, string dpto)
            : base(Provincia, ciudad, municipio, zona)
        {
            this.nrocasa = nrocasa;
            this.calle = calle;
            this.piso = piso;
            this.dpto = dpto;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Calle: " + this.calle + "\n N° Casa: " + this.nrocasa + "\n Piso: " + this.piso + "\n Departamento: " + this.dpto;
        }
    }

}

