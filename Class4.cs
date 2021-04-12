using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace proyectoclases
{
    class servicios
    {
        //atributos
        public string empresa { get; set; }
        public string direccion { get; set; }
        public long telefono { get; set; }

        //métodos

        public servicios(string empresa, string direccion, long telefono)
        {
            this.empresa = empresa;
            this.direccion = direccion;
            this.telefono = telefono;

        }
        public override string ToString()
        {
            return this.empresa.PadLeft(5) + this.direccion.PadLeft(30) + "  ".PadLeft(10) + this.telefono;

        }

    }
    class luzcomunidad : servicios
    {
        //atributos
        public string comunidad { get; set; }
        public string zona { get; set; }

        //métodos

        public luzcomunidad(string empresa, string direccion, long telefono, string comunidad, string zona)
            : base(empresa, direccion, telefono)
        {
            this.comunidad = comunidad;
            this.zona = zona;
        }
        public override string ToString()
        {
            return base.ToString() + this.comunidad.PadLeft(30) + this.zona.PadLeft(30);
        }
    }
    class luzbarrio : servicios
    { //atributos
        public string transformador { get; set; }
        public string poste { get; set; }

        //métodos

        public luzbarrio(string empresa, string direccion, long telefono, string transformador, string poste)
            : base(empresa, direccion, telefono)
        {
            this.transformador = transformador;
            this.poste = poste;
        }
        public override string ToString()
        {
            return base.ToString() + this.transformador.PadLeft(40) + this.poste.PadLeft(30);
        }
    }

    class luzcasa : servicios
    { //atributos
        public string cliente { get; set; }
        public string tipocliente { get; set; }
        public long medidor { get; set; }
        public string tension { get; set; }
        public string personal { get; set; }

        //métodos

        public luzcasa(string empresa, string direccion, long telefono, string cliente, string tipocliente, long medidor, string tension, string personal)
            : base(empresa, direccion, telefono)
        {
            this.cliente = cliente;
            this.tipocliente = tipocliente;
            this.medidor = medidor;
            this.tension = tension;
            this.personal = personal;
        }
        public override string ToString()
        {
            return base.ToString().PadRight(20) + this.cliente.PadRight(30) + this.tipocliente.PadRight(30) + this.medidor + this.tension.PadLeft(30) + this.personal.PadLeft(30);
        }



    }
    class aguacomunidad : servicios
    {  //atributos
        public string comunidad { get; set; }
        public string zona { get; set; }

        //métodos

        public aguacomunidad(string empresa, string direccion, long telefono, string comunidad, string zona)
            : base(empresa, direccion, telefono)
        {
            this.comunidad = comunidad;
            this.zona = zona;
        }
        public override string ToString()
        {
            return base.ToString() + this.comunidad.PadLeft(30) + this.zona.PadLeft(30);
        }
    }
    class aguabarrio : servicios
    {//atributos
        public string troncal { get; set; }
        public string poste { get; set; }

        //métodos

        public aguabarrio(string empresa, string direccion, long telefono, string troncal, string poste)
            : base(empresa, direccion, telefono)
        {
            this.troncal = troncal;
            this.poste = poste;
        }
        public override string ToString()
        {
            return base.ToString() + this.troncal.PadLeft(40) + this.poste.PadLeft(30);
        }
    }
    class aguacasa : servicios
    {  //atributos
        public string cliente { get; set; }
        public string tipocliente { get; set; }
        public long medidor { get; set; }
        public string personal { get; set; }

        //métodos

        public aguacasa(string empresa, string direccion, long telefono, string cliente, string tipocliente, long medidor, string personal)
            : base(empresa, direccion, telefono)
        {
            this.cliente = cliente;
            this.tipocliente = tipocliente;
            this.medidor = medidor;
            
            this.personal = personal;
        }
        public override string ToString()
        {
            return base.ToString().PadRight(20) + this.cliente.PadRight(30) + this.tipocliente.PadRight(30) + this.medidor + this.personal.PadLeft(30);
        }
    }

    class telefonocomunidad : servicios
    {  //atributos
        public string comunidad { get; set; }
        public string antena { get; set; }

        //métodos

        public telefonocomunidad(string empresa, string direccion, long telefono, string comunidad, string antena)
            : base(empresa, direccion, telefono)
        {
            this.comunidad = comunidad;
            this.antena = antena;
        }
        public override string ToString()
        {
            return base.ToString() + this.comunidad.PadLeft(30) + this.antena.PadLeft(30);
        }
    }

    class telefonobarrio : servicios
    { //atributos
        public long lineaprincipal { get; set; }
        public long caja { get; set; }

        //métodos

        public telefonobarrio(string empresa, string direccion, long telefono, long lineaprincipal, long caja)
            : base(empresa, direccion, telefono)
        {
            this.lineaprincipal = lineaprincipal;
            this.caja = caja;
        }
        public override string ToString()
        {
            return base.ToString() + this.lineaprincipal + this.caja;
        }
    }

    class telefonocasa : servicios
    {  //atributos
        public long nrotelefono { get; set; }
        public string tipocliente { get; set; }
        public string domicliente { get; set; }
        public string tiposervicio { get; set; }
        public string personal { get; set; }

        //métodos

        public telefonocasa(string empresa, string direccion, long telefono, long nrotelefono, string tipocliente, string domicliente, string tension, string personal)
            : base(empresa, direccion, telefono)
        {
            this.nrotelefono = nrotelefono;
            this.tipocliente = tipocliente;
            this.domicliente = domicliente;
            this.tiposervicio = tiposervicio;
            this.personal = personal;
        }
        public override string ToString()
        {
            return base.ToString().PadRight(20) + this.nrotelefono + this.tipocliente.PadRight(30) + this.tiposervicio + this.personal.PadLeft(30) + this.personal.PadLeft(30);
        }
    }

    class internetcomunidad : servicios
    {  //atributos
        public string comunidad { get; set; }
        public string zona { get; set; }

        //métodos

        public internetcomunidad(string empresa, string direccion, long telefono, string comunidad, string zona)
            : base(empresa, direccion, telefono)
        {
            this.comunidad = comunidad;
            this.zona = zona;
        }
        public override string ToString()
        {
            return base.ToString() + this.comunidad.PadLeft(30) + this.zona.PadLeft(30);
        }
    }

    class internetbarrio : servicios
    { //atributos
        public string antena { get; set; }
        public string caja { get; set; }

        //métodos

        public internetbarrio(string empresa, string direccion, long telefono, string antena, string caja)
            : base(empresa, direccion, telefono)
        {
            this.antena = antena;
            this.caja = caja;
        }
        public override string ToString()
        {
            return base.ToString() + this.antena.PadLeft(40) + this.caja.PadLeft(30);
        }
    }

    class internetcasa : servicios
    {  //atributos
        public string modem { get; set; }
        public string tiposervicio { get; set; }
        public string domicliente { get; set; }
        public int cantbocas{ get; set; }
        public string personal { get; set; }

        //métodos

        public internetcasa(string empresa, string direccion, long telefono, string modem, string tiposervicio, int cantbocas,string personal)
            : base(empresa, direccion, telefono)
        {
            this.modem = modem;
            this.tiposervicio = tiposervicio;
            this.domicliente = domicliente;
            this.cantbocas = cantbocas;
            this.personal = personal;
        }
        public override string ToString()
        {
            return base.ToString().PadRight(20) + this.modem.PadRight(30) + this.tiposervicio.PadRight(30) + this.domicliente + this.cantbocas + this.personal.PadLeft(30);
        }

    }
        class cablecomunidad : servicios
        {  //atributos
            public string comunidad { get; set; }
            public string zona { get; set; }

            //métodos

            public cablecomunidad(string empresa, string direccion, long telefono, string comunidad, string zona)
                : base(empresa, direccion, telefono)
            {
                this.comunidad = comunidad;
                this.zona = zona;
            }
            public override string ToString()
            {
                return base.ToString() + this.comunidad.PadLeft(30) + this.zona.PadLeft(30);
            }
        }

        class cablebarrio : servicios
        { //atributos
            public string caja { get; set; }
            public string poste { get; set; }

            //métodos

            public cablebarrio(string empresa, string direccion, long telefono, string caja, string poste)
                : base(empresa, direccion, telefono)
            {
                this.caja = caja;
                this.poste = poste;
            }
            public override string ToString()
            {
                return base.ToString() + this.caja.PadLeft(40) + this.poste.PadLeft(30);
            }
        }

        class cablecasa : servicios
        { //atributos
        public string cliente { get; set; }
        public string tiposervicio { get; set; }
        public long codificador { get; set; }
        public string personal { get; set; }

        //métodos

        public cablecasa(string empresa, string direccion, long telefono, string cliente, string tiposervicio, long codificador,  string personal)
            : base(empresa, direccion, telefono)
        {
            this.cliente = cliente;
            this.tiposervicio = tiposervicio;
            this.codificador = codificador;
            
            this.personal = personal;
        }
        public override string ToString()
        {
            return base.ToString().PadRight(20) + this.cliente.PadRight(30) + this.tiposervicio.PadRight(30) + this.codificador + this.personal.PadLeft(30);
        }
}

        class residuoscomumidad : servicios
        { //atributos
            public string comunidad { get; set; }
            public string zona { get; set; }

            //métodos

            public residuoscomumidad(string empresa, string direccion, long telefono, string comunidad, string zona)
                : base(empresa, direccion, telefono)
            {
                this.comunidad = comunidad;
                this.zona = zona;
            }
            public override string ToString()
            {
                return base.ToString() + this.comunidad.PadLeft(30) + this.zona.PadLeft(30);
            }
        }

        class residuosbarrio : servicios
        {//atributos
            public  int horainiciorecorrido { get; set; }
            public int horafinrecorrido { get; set; }
            public int nrorutarecorrido { get; set; }

            //métodos

            public residuosbarrio(string empresa, string direccion, long telefono,int horainiciorecorrido, int nrorutarecorrido)
                : base(empresa, direccion, telefono)
            {
                this.horainiciorecorrido = horainiciorecorrido;
                this.horafinrecorrido = horafinrecorrido;
                this.nrorutarecorrido = nrorutarecorrido;
            }
            public override string ToString()
            {
                return base.ToString() + this.horainiciorecorrido + this.horafinrecorrido;
            }
        }

        class residuoscasa : servicios
        {  //atributos
            public string cliente { get; set; }
            public string tipocliente { get; set; }
            public string camionrecolector { get; set; }
            public string personal { get; set; }
            public string basureroscontenedores { get; set; }


            //métodos

            public residuoscasa(string empresa, string direccion, long telefono, string cliente, string tipocliente, string camionrecolector, string personal, string basureroscontenedores)
                : base(empresa, direccion, telefono)
            {
                this.cliente = cliente;
                this.tipocliente = tipocliente;
                this.camionrecolector = camionrecolector;
                this.personal = personal;
                this.basureroscontenedores = basureroscontenedores;
            }
            public override string ToString()
            {
                return base.ToString().PadRight(20) + this.cliente.PadRight(30) + this.tipocliente.PadRight(30) + this.camionrecolector  + this.personal.PadLeft(30)+ this.basureroscontenedores;
            }
        }



    }
