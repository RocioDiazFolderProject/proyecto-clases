using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace proyectoclases
{
    class casa //superclase casa
    {
        //atributos
        public List<Domestico> mascotas = new List<Domestico>();
        public List<Salvaje> mascotasalvaje = new List<Salvaje>();
        public List<Domestico> imprimir = new List<Domestico>();

        public List<perfilPersona> personas = new List<perfilPersona>();
        
        public List<luzcasa> serviciodomicilio = new List<luzcasa>();
        public List<luzbarrio> alumbrado = new List<luzbarrio>();
        public List<luzcomunidad> luzonal = new List<luzcomunidad>();

        public List<aguacasa> servicioagua = new List<aguacasa>();
        public List<aguabarrio> pluviales = new List<aguabarrio>();
        public List<aguacomunidad> troncales = new List<aguacomunidad>();

        public List<telefonocasa> telefono = new List<telefonocasa>();
        public List<telefonobarrio> telefonored = new List<telefonobarrio>();
        public List<telefonocomunidad> telefonocomuna = new List<telefonocomunidad>();

        public List<internetcasa> internetdomicilio = new List<internetcasa>();
        public List<internetbarrio> internetes = new List<internetbarrio>();
        public List<internetcomunidad> internetcomuna = new List<internetcomunidad>();

        public List<cablecasa> cablecasa = new List<cablecasa>();
        public List<cablebarrio> cablemanzana = new List<cablebarrio>();
        public List<cablecomunidad> cablecity = new List<cablecomunidad>();

        public List<residuoscasa> residuoscasa = new List<residuoscasa>();
        public List<residuosbarrio> recoleccionbarrio = new List<residuosbarrio>();
        public List<residuoscomumidad> residuoszonal = new List<residuoscomumidad>();

        public List<cocina> quitchen = new List<cocina>();
        public List<baño1> bathroom = new List<baño1>();
        public List<dormitorio1> room = new List<dormitorio1>();
        public List<jardin> garden = new List<jardin>();
        public List<garage> cochera = new List<garage>();
        public List<quincho> quincho = new List<quincho>();


        public string rutarch = @"C:\Persistencia\persistencia.txt";

        






        //métodos para animales

        public void nuevaMascota(Domestico animal)
        {
            this.mascotas.Add(animal);
           

        }
        

        public void nuevoSalvaje(Salvaje animal2)
        {
            this.mascotasalvaje.Add(animal2);
        }
        public void mostratMascotas()
        {
            foreach (var animal in mascotas)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine("\n <<<<<<<<<<<<<<<<<\n");

            }
        }
        public void mostratSalvajes()
        {
            foreach (var animal2 in mascotasalvaje)
            {
                Console.WriteLine(animal2.ToString());
                Console.WriteLine("\n <<<<<<<<<<<<<<<<<\n");

            }
        }
        //métodos para persistir

        public void persistir(Domestico objetofamilia)
       
        {
            imprimir.Add(objetofamilia);

            StreamWriter archivo = new StreamWriter(rutarch);
          

               foreach (var item in imprimir)
               {
                   
                   archivo.WriteLine("" + item.clase + "," + item.dieta + "," + item.nombre + "," + item.tipo + "," + item.edad);
                   Console.WriteLine ("archivo creado en: " + rutarch);
               }
               Console.ReadKey();
               archivo.Close();
           


        }





        //métodos para perfilpersona

        public void nuevaPersona(perfilPersona persona)
       {
            
            this.personas.Add(persona);

        }
        public void mostrarPersonas()
        {
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.ToString());
                Console.WriteLine("\n<<<<<<<<<<<<<<<<<\n");
            }
        }
        
        //métodos para servicios
        
       public void agregardomi(luzcasa nvodomicilio)
        {
           this.serviciodomicilio.Add(nvodomicilio);
        }
       public void agregaralumbrado(luzbarrio nvoalumbrado)
       {
           this.alumbrado.Add(nvoalumbrado);
       }
       public void agregarzona(luzcomunidad nvazona)
       {
           this.luzonal.Add(nvazona);
       }
       public void agregaraguadomi(aguacasa nvodomicilio)
       {
           this.servicioagua.Add(nvodomicilio);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregaraguabarrio(aguabarrio nvopluvial)
       {
           this.pluviales.Add(nvopluvial);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregaraguacomuna(aguacomunidad nvotroncal)
       {
           this.troncales.Add(nvotroncal);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregarteldomi(telefonocasa nvoteldomi)
       {
           this.telefono.Add(nvoteldomi);
       }
       public void agregartelbarrio(telefonobarrio nvotelbarrio)
       {
           this.telefonored.Add(nvotelbarrio);
       }
       public void agregarred(telefonocomunidad nvared)
       {
           this.telefonocomuna.Add(nvared);
       }
       public void agregarcabledomi(cablecasa nvocablecasa)
       {
           this.cablecasa.Add(nvocablecasa);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregarcablebarrio(cablebarrio nvocable)
       {
           this.cablemanzana.Add(nvocable);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregarcablecomuna(cablecomunidad nvocableado)
       {
           this.cablecity.Add(nvocableado);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregarinternetcasa(internetcasa nvodomicilio)
       {
           this.internetdomicilio.Add(nvodomicilio);
       }
       public void agregarinternetbarrio(internetbarrio nvointernet)
       {
           this.internetes.Add(nvointernet);
       }
       public void agregarinternetcomuna(internetcomunidad  vazona)
       {
           this.internetcomuna.Add(vazona);
       }
       public void agregarrecoleccion(residuoscasa nvodomicilio)
       {
           this.residuoscasa.Add(nvodomicilio);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregarrecolecbarrial(residuosbarrio residbarrio)
       {
           this.recoleccionbarrio.Add(residbarrio);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }
       public void agregarrecolcomuna(residuoscomumidad comunaresiduos)
       {
           this.residuoszonal.Add(comunaresiduos);
           //agregar llamado a método persistir
           //servicioagua.persistir
       }

       


        //mostrar 


       public void mostrarConexionesluzdomi()
        {
            foreach (var nvodomicilio in serviciodomicilio)
            {
                Console.WriteLine(nvodomicilio.ToString());
                Console.WriteLine("\n----------------------\n");
            }
        }
        public void mostraralumbrado()
        {
            foreach (var nvoalumbrado in alumbrado)
            {
                Console.WriteLine(nvoalumbrado.ToString());
                Console.WriteLine("\n<<<<<<<<<<<<<<<<<\n");
            }
        }
        public void mostrarzona()
        {
            foreach (var nvazona in luzonal)
            {
                Console.WriteLine(nvazona.ToString());
                Console.WriteLine("\n<<<<<<<<<<<<<<<<<\n");
            }
        }
        public void mostrarConexionesaguadomi()
        {
            foreach (var aguaconexion in servicioagua)
            {
                Console.WriteLine(aguaconexion.ToString());
                Console.WriteLine("\n---------------------------\n");
            }
        }
        public void mostrarpluviales()
        {
            foreach (var nvopluvial in pluviales)
            {
                Console.WriteLine(nvopluvial.ToString());
                Console.WriteLine("\n---------------\n");
            }

        }
        public void mostrartroncales()
        {
            foreach (var nvotroncal in troncales)
            {
                Console.WriteLine(nvotroncal.ToString());
                Console.WriteLine("\n------------\n");
            }
        
        }

        public void mostrarteldomi()
        {
            foreach (var nvotel in telefono)
            {
                Console.WriteLine(nvotel.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrartelbarrio()
        {
            foreach (var nvotelbarrio in telefonored)
            {
                Console.WriteLine(nvotelbarrio.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        
        public void mostrarredcomuna()
        {
            foreach (var nvoredcomuna in telefonored)
            {
                Console.WriteLine(nvoredcomuna.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarcabledomi()
        {
            foreach (var nvocable in cablecasa)
            {
                Console.WriteLine(nvocable.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarcablebarrio()
        {
            foreach (var nvocablebarrio in cablemanzana)
            {
                Console.WriteLine(nvocablebarrio.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarcablecomuna()
        {
            foreach (var nvocablecomuna in cablecity)
            {
                Console.WriteLine(nvocablecomuna.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarinternetcasa()
        {
            foreach (var nvointernetcasa in internetdomicilio)
            {
                Console.WriteLine(nvointernetcasa.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarinternetbarrio()
        {
            foreach (var nvointernet in internetes)
            {
                Console.WriteLine(nvointernet.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarinternetcomunidad()
        {
            foreach (var nvointernetcomunidad in internetcomuna)
            {
                Console.WriteLine(nvointernetcomunidad.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarrecoleccioncasa()
        {
            foreach (var nvorecoleccioncasa in residuoscasa)
            {
                Console.WriteLine(nvorecoleccioncasa.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarrecoleccionbarrio()
        {
            foreach (var nvorecoleccionbarrio in recoleccionbarrio)
            {
                Console.WriteLine(nvorecoleccionbarrio.ToString());
                Console.WriteLine("\n------------\n");
            }

        }
        public void mostrarrecoleccioncomunidad()
        {
            foreach (var nvoresiduoscomunidad in residuoszonal)
            {
                Console.WriteLine(nvoresiduoscomunidad.ToString());
                Console.WriteLine("\n------------\n");
            }

        }

        //agregar ambientes

        public void nuevacocina(cocina quichen)
        {

            this.quitchen.Add(quichen);

        }
        public void nuevabaño(baño1 bath)
        {

            this.bathroom.Add(bath);

        }

        public void nuevadormitorio(dormitorio1 dormi)
        {

            this.room.Add(dormi);

        }

        public void nuevajardin(jardin patio)
        {

            this.garden.Add(patio);

        }
        public void nuevagaraje(garage automo)
        {

            this.cochera.Add(automo);

        }

        public void nuevaquincho(quincho parrilla)
        {

            this.quincho.Add(parrilla);

        }


        public void mostrarcocina()
        {
            foreach (var nvacocina in quitchen)
            {
                Console.WriteLine(nvacocina.ToString());
                Console.WriteLine("\n------------\n");
            }
        }

        public void mostrarbaño()
        {
            foreach (var nvobaño in bathroom)
            {
                Console.WriteLine(nvobaño.ToString());
                Console.WriteLine("\n------------\n");
            }
        }

        public void mostrardormitorio()
        {
            foreach (var nvodormitorio in room)
            {
                Console.WriteLine(nvodormitorio.ToString());
                Console.WriteLine("\n------------\n");
            }
        }

        public void mostrarjardin()
        { 
            foreach (var nvojardin in garden)
            {
                Console.WriteLine(nvojardin.ToString());
                Console.WriteLine("\n------------\n");
            }
        }

        public void mostrargarage()
        {
            foreach (var nvogarage in cochera)
            {
                Console.WriteLine(nvogarage.ToString());
                Console.WriteLine("\n------------\n");
            }
        }

        public void mostrarquincho()
        {
            foreach (var nvoquincho in quincho)
            {
                Console.WriteLine(nvoquincho.ToString());
                Console.WriteLine("\n------------\n");
            }
        }

    }
}
