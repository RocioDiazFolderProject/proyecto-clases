using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace proyectoclases
{
    class Program
    {
        static void Main(string[] args)
        
        {
            

              //estructuras de clases domestico, salvaje, persona
                Domestico[] tablaDomesticos = new Domestico[2];//arma la variable Domestico como array 
                Salvaje[] tablaSalvajes = new Salvaje[2];//Salvaje array
                perfilPersona[] tablaPersonas = new perfilPersona[2];//persona array
                luzcasa[] tablaLuzcasas = new luzcasa[2];
                luzbarrio[] tablaluzbarrio = new luzbarrio[2];
                luzcomunidad[] tablaluzcomunidad = new luzcomunidad[2];
                aguacasa[] tablaguacasas = new aguacasa[2];
                aguabarrio[] tablaguabarrio = new aguabarrio[2];
                aguacomunidad[] tablaguacomunidad = new aguacomunidad[2];
                telefonocasa[] tablatelcasa = new telefonocasa[2];
                telefonobarrio[] tablatelbarrio = new telefonobarrio[2];
                telefonocomunidad[] tablatelcomunidad = new telefonocomunidad[2];
                cablecasa[] tablacablecasa = new cablecasa[2];
                cablebarrio[] tablacablebarrio = new cablebarrio[2];
                cablecomunidad[] tablacablecomu = new cablecomunidad[2];
                internetbarrio[] tablainternetbarrio = new internetbarrio[2];
                internetcasa[] tablainternetcasa = new internetcasa[2];
                internetcomunidad[] tablainternetcomu = new internetcomunidad[2];
                residuoscasa[] tablarecoleccioncasa = new residuoscasa[2];
                residuosbarrio[] tablarecoleccionbarrio = new residuosbarrio[2];
                residuoscomumidad[] tablarecoleccioncomu = new residuoscomumidad[2];
                cocina[] tablacocina = new cocina[2];
                baño1[] tablabaño = new baño1[2];
                dormitorio1[] tabladormitorio = new dormitorio1[2];
                jardin[] tablajardin = new jardin[2];
                garage[] tablagarage = new garage[2];
                quincho[] tablaquincho = new quincho[2];




                //variables locales

                string nombre = "", tipo = "", origen = "",empresa = "", direccion ="", cliente = "", tipocliente = "", tension = "", personal = "" ;
                string clase = "", dieta = "", trafo = "", comunidad = "", zona = "", poste = "", cajaString="";
                int edad = 0, edadP = 0, eleccion = 0,eleccionA=0, cantbocas = 0, horainicio = 0, horafin = 0, nroruta = 0;
                string nombreP = "", sexoP = "";
                DateTime fechaNac ;
                bool continuar = true;
                long telefono = 0, medidor = 0, lineappal = 0, caja=0, codificador = 0, telcliente = 0;
                //string[] renglon ;
                string troncal = "", antena = "", domicliente = "", modem = "", tiposervicio = "", recolector = "", contenedor = "";

                long largo = 0, ancho = 0; 
                int cantpta = 0, cantvta = 0;
                string nombreAmb = "", colorAmb = "", artefacto1 = "", artefacto2="", artefacto3="", mueble1="", mueble2="", mueble3="", tiposuelo="", ubicacion="";
                
                
                 
                //variables locales del tipo clases
                casa chaletAmarillo = new casa();
                casa chaletRojo = new casa();
                casa Persona = new casa();
                casa LuzDomi = new casa();
                casa LuzBarrio = new casa();
                casa LuzComuna = new casa();
                casa ADomi = new casa();
                casa ABarrio = new casa();
                casa AComuna = new casa();
                casa IDomi = new casa();
                casa IBarrio = new casa();
                casa IComuna = new casa();
                casa CDomi = new casa();
                casa CBarrio = new casa();
                casa CComuna = new casa();
                casa RDomi = new casa();
                casa RBarrio = new casa();
                casa RComuna = new casa();
                casa TDomi = new casa();
                casa TBarrio = new casa();
                casa TComuna = new casa();


                Console.WriteLine("         ╔══════════♣♣♣♣♣♣♣♣═════════╗");
                Console.WriteLine("         ║         Bienvenidos       ║");
                Console.WriteLine("         ╚═══════════════════════════╝\n");

               
            do
            {//inicio do
                Console.WriteLine("Seleccione las opciones que desea:\n");
                continuar = true;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" 1 - Carga Animal Doméstico\n");
                Console.WriteLine(" 2 - Carga Animal Salvaje\n");
                Console.WriteLine(" 3 - Carga Padre/Hijo\n");
                Console.WriteLine(" 4 - Carga Ambientes de la casa\n");
                Console.WriteLine(" 5 - Carga Servicios\n");
                Console.WriteLine(" 6 - Consultas varias\n");
                Console.WriteLine(" 7 - Impresiones a archivo o impresora\n");
                Console.WriteLine(" 8 - Salir del sistema\n");

                Console.BackgroundColor = ConsoleColor.Black;
                
                eleccion = int.Parse(Console.ReadLine());
                switch (eleccion)
                {//inicio switch
                    case 1://inicio case 1
                        for (int i = 0; i < 2; i++)
                        {//inicio for
                          
                            Console.WriteLine("Ingrese la clase de animal");
                            clase = Console.ReadLine();
                            Console.WriteLine("Ingrese la dieta");
                            dieta = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el tipo");
                            tipo = Console.ReadLine();
                            Console.WriteLine("Ingrese la edad");
                            edad = int.Parse(Console.ReadLine());
                            

                            tablaDomesticos[i] = new Domestico(clase.PadRight(2), dieta.PadRight(2), nombre.PadRight(2), tipo.PadRight(2), edad);


                            chaletAmarillo.nuevaMascota(tablaDomesticos[i]);
                           
                           


                        }//fin for
                        
                        
                        break;//fin case 1
                    case 2:
                        {
                            for (int i = 0; i < 2; i++)
                            {//inicio for
                                Console.WriteLine("Ingrese la clase de animal");
                                clase = Console.ReadLine();
                                Console.WriteLine("Ingrese la dieta");
                                dieta = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese la raza");
                                tipo = Console.ReadLine();
                                Console.WriteLine("Ingrese el origen");
                                origen = Console.ReadLine();

                                tablaSalvajes[i] = new Salvaje(clase, dieta, nombre, tipo, origen);
                                chaletRojo.nuevoSalvaje(tablaSalvajes[i]);
                            }//fin for
                            //chaletRojo.mostratSalvajes();
                            Console.ReadKey();
                        }break;
                    case 3:
                        {
                            for (int i = 0; i < 2; i++)
                            {//inicio for
                                Console.WriteLine("Ingrese nombre del padre/madre");
                                nombreP = Console.ReadLine();
                                Console.WriteLine("Ingrese femenino/masculino");
                                sexoP = Console.ReadLine();
                                Console.WriteLine("Ingrese edad del padre/madre");
                                edadP = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese fecha nacimiento padre/madre");
                                fechaNac = DateTime.Parse(Console.ReadLine());

                                tablaPersonas[i] = new perfilPersona(nombreP.PadRight(10), sexoP.PadRight(10), edadP, fechaNac);
                                Persona.nuevaPersona(tablaPersonas[i]);
                                //Persona.mostrarPersonas();
                                Console.ReadKey();
                            }//fin for
                
                        }
                        break;
                    case 4:
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("Ingrese el largo de la habitación:\n");
                                largo = long.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el ancho de la habitación:\n");
                                ancho = long.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre de la habitación:\n");
                                nombreAmb = Console.ReadLine();
                                Console.WriteLine("Ingrese el color de la habitación:\n");
                                colorAmb = Console.ReadLine();

                                Console.WriteLine("Por favor seleccione la opción que ambiente cargar:\n");
                                 Console.WriteLine("1-Carga Baño\n");
                                 Console.WriteLine("2-Carga Dormitorio\n");
                                   Console.WriteLine("3-Carga cocina\n");
                                    Console.WriteLine("4-Carga garage\n");
                                Console.WriteLine("5-Carga jardin\n");
                                Console.WriteLine("6-Carga quincho\n");
                                
                                Console.WriteLine("7 - Volver al menu principal\n");

                                eleccionA= int.Parse(Console.ReadLine());


                                switch (eleccionA)
                                {
                                    case 1:
                                            Console.WriteLine("Cargue el primer artefacto del baño (lavatorio/bide/inodoro/ducha)\n");
                                            artefacto1 = Console.ReadLine();
                                            Console.WriteLine("Cargue el segundo artefacto del baño (lavatorio/bide/inodoro/ducha)\n");
                                            artefacto2=Console.ReadLine();
                                            Console.WriteLine("Cargue el tercer artefacto del baño (lavatorio/bide/inodoro/ducha)\n");
                                            artefacto3 = Console.ReadLine();
                                            Console.WriteLine("Cargue cantidad de ventanas del baño \n");
                                            cantvta = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Cargue cantidad de puertas del baño \n");
                                            cantpta = int.Parse(Console.ReadLine());

                                            tablabaño[0] = new baño1(largo, ancho,nombreAmb,colorAmb, cantvta, cantpta,artefacto1, artefacto2, artefacto3);
                                            chaletRojo.nuevabaño(tablabaño[0]);
                                        break;
                                    case 2:break;
                                    case 3:break;
                                    case 4:break;
                                    case 5:break;
                                    case 6:break;
                                   
                                    case 7: break;



                                } break;
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("MENU CARGA DE SERVICIOS\n");
                            Console.WriteLine("\n seleccione la opción a cargar\n ");
                            Console.WriteLine("\n 11 - Luz Conexiones Domiciliarias\n");
                            Console.WriteLine("\n 12 - Luz Conexiones Barriales\n");
                            Console.WriteLine("\n 13 - Luz Conexiones Comunidad\n");
                            Console.WriteLine("\n 21 - Agua Conexiones Domiciliarias\n");
                            Console.WriteLine("\n 22 - AguaConexiones Barriales\n");
                            Console.WriteLine("\n 23 - Agua Conexiones Comunidad\n");
                            Console.WriteLine("\n 31 - Telefono Conexiones Domiciliarias\n");
                            Console.WriteLine("\n 32 - Telefono Conexiones Barriales\n");
                            Console.WriteLine("\n 33 - Telefono Conexiones comunidad\n");
                            Console.WriteLine("\n 41 - Cable Conexiones Domiciliarias\n");
                            Console.WriteLine("\n 42 - Cable Conexiones Barriales\n");
                            Console.WriteLine("\n 43 - Cable Conexiones Comunidad\n");
                            Console.WriteLine("\n 51 - Internet Conexiones Domiciliarias\n");
                            Console.WriteLine("\n 52 - Internet Conexiones Barriales\n");
                            Console.WriteLine("\n 53 - Internet Conexiones Comunidad\n");
                            Console.WriteLine("\n 61 - Residuos Recolección Domiciliarias\n");
                            Console.WriteLine("\n 62 - Residuos Recolección Barriales\n");
                            Console.WriteLine("\n 63 - Residuos Recolección Comunidad\n");


                            eleccion = int.Parse(Console.ReadLine());
                            Console.ReadKey();
                            switch (eleccion)
                            {//inicia switch del case 5
                                case 11:
                                    {//inicia case 11
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa eléctrica\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa eléctrica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese nombre del cliente\n");
                                            cliente = Console.ReadLine();
                                            Console.WriteLine("Ingrese tipo de cliente(empresa/particular/otros)\n");
                                            tipocliente = Console.ReadLine();
                                            Console.WriteLine("Ingrese N° medidor\n");
                                            medidor = long.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese tension usada(monofásica/trifásica)\n");
                                            tension = Console.ReadLine();
                                            Console.WriteLine("Ingrese nombre del personal que atendio en la última visita al cliente\n");
                                            personal = Console.ReadLine();


                                            tablaLuzcasas[i] = new luzcasa(empresa, direccion, telefono, cliente, tipocliente, medidor, tension, personal);
                                            LuzDomi.agregardomi(tablaLuzcasas[i]);
                                        }//cierra for carga luz casas


                                    } break;//cierra case 11

                                case 12:
                                    {//abre case 2 luz comunidad
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa eléctrica\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa eléctrica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese comunidad(Villa Libertad/Villa San Martin/etc.)\n");
                                            comunidad = Console.ReadLine();
                                            Console.WriteLine("Ingrese zona(sur/norte/este/oeste)\n");
                                            zona = Console.ReadLine();



                                            tablaluzcomunidad[i] = new luzcomunidad(empresa, direccion, telefono, comunidad, zona);
                                            LuzComuna.agregarzona(tablaluzcomunidad[i]);
                                        }
                                    } break;
                                case 13:
                                    { //luz barrios

                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa eléctrica\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa eléctrica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese transformador\n");
                                            trafo = Console.ReadLine();
                                            Console.WriteLine("Ingrese poste\n");
                                            poste = Console.ReadLine();



                                            tablaluzbarrio[i] = new luzbarrio(empresa, direccion, telefono, trafo, poste);
                                            LuzBarrio.agregaralumbrado(tablaluzbarrio[i]);
                                        }
                                    } break;


                                case 21:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa agua\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa agua\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese nombre del cliente\n");
                                            cliente = Console.ReadLine();
                                            Console.WriteLine("Ingrese tipo de cliente(residencial/empresa/otros)\n");
                                            tipocliente = Console.ReadLine();
                                            Console.WriteLine("Ingrese N° medidor\n");
                                            medidor = long.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese nombre del personal que atendio en la última visita al cliente\n");
                                            personal = Console.ReadLine();


                                            tablaguacasas[i] = new aguacasa(empresa, direccion, telefono, cliente, tipocliente, medidor, personal);
                                            ADomi.agregaraguadomi(tablaguacasas[i]);
                                        }//cierra for carga agua casas

                                    } break;
                                case 22:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa agua\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa agua\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese troncal\n");
                                            troncal = Console.ReadLine();
                                            Console.WriteLine("Ingrese ramal\n");
                                            poste = Console.ReadLine();



                                            tablaguabarrio[i] = new aguabarrio(empresa, direccion, telefono, troncal, poste);
                                            ABarrio.agregaraguabarrio(tablaguabarrio[i]);
                                        }
                                    } break;
                                case 23:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa de agua\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa de agua\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese comunidad(Villa Libertad/Villa San Martin/etc.)\n");
                                            comunidad = Console.ReadLine();
                                            Console.WriteLine("Ingrese zona(sur/norte/este/oeste)\n");
                                            zona = Console.ReadLine();



                                            tablaguacomunidad[i] = new aguacomunidad(empresa, direccion, telefono, comunidad, zona);
                                            AComuna.agregaraguacomuna(tablaguacomunidad[i]);
                                        }
                                    } break;
                                case 31:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa telefónica\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa telefónica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese nombre de teléfono(sin espacios)\n");
                                            telcliente = long.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese tipo de cliente(residencial/empresa/otros)\n");
                                            tipocliente = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio\n");
                                            domicliente = Console.ReadLine();
                                            Console.WriteLine("Ingrese el tipo de servicio(plan del cliente)\n");
                                            tiposervicio = Console.ReadLine();
                                            Console.WriteLine("Ingrese nombre del personal que atendio en la última visita al cliente\n");
                                            personal = Console.ReadLine();


                                            tablatelcasa[i] = new telefonocasa(empresa, direccion, telefono, telcliente, tipocliente, domicliente, tiposervicio, personal);
                                            TDomi.agregarteldomi(tablatelcasa[i]);
                                        }
                                    } break;
                                case 32:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa agua\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa agua\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese N° Linea Principal\n");
                                            lineappal = long.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese N° de caja\n");
                                            caja = long.Parse(Console.ReadLine());



                                            tablatelbarrio[i] = new telefonobarrio(empresa, direccion, telefono, lineappal, caja);
                                            TBarrio.agregartelbarrio(tablatelbarrio[i]);
                                        }
                                    } break;
                                case 33:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa telefónica\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa telefónica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese comunidad(Villa Libertad/Villa San Martin/etc.)\n");
                                            comunidad = Console.ReadLine();
                                            Console.WriteLine("Ingrese Antena)\n");
                                            antena = Console.ReadLine();



                                            tablatelcomunidad[i] = new telefonocomunidad(empresa, direccion, telefono, comunidad, antena);
                                            TComuna.agregarred(tablatelcomunidad[i]);
                                        }
                                    } break;
                                case 41:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa de cable\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa de cable\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese nombre del cliente(sin espacios)\n");
                                            nombre = Console.ReadLine();
                                            Console.WriteLine("Ingrese el tipo de servicio(plan del cliente)\n");
                                            tiposervicio = Console.ReadLine();
                                            Console.WriteLine("Ingrese nombre del personal que atendio en la última visita al cliente\n");
                                            personal = Console.ReadLine();
                                            Console.WriteLine("Ingrese datos del codificador\n");
                                            codificador = long.Parse(Console.ReadLine());


                                            tablacablecasa[i] = new cablecasa(empresa, direccion, telefono, cliente, tiposervicio, codificador, personal);
                                            CDomi.agregarcabledomi(tablacablecasa[i]);
                                        }
                                    } break;
                                case 42:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa cable\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa cable\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese N° Linea Poste\n");
                                            poste = Console.ReadLine();
                                            Console.WriteLine("Ingrese N° de caja\n");
                                            cajaString = Console.ReadLine();



                                            tablacablebarrio[i] = new cablebarrio(empresa, direccion, telefono, cajaString, poste);
                                            CBarrio.agregarcablebarrio(tablacablebarrio[i]);
                                        }
                                    } break;
                                case 43:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa de cable\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa de cable\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese comunidad(Villa Libertad/Villa San Martin/etc.)\n");
                                            comunidad = Console.ReadLine();
                                            Console.WriteLine("Ingrese Zona(sur/norte/este/oeste)\n");
                                            zona = Console.ReadLine();



                                            tablacablecomu[i] = new cablecomunidad(empresa, direccion, telefono, comunidad, antena);
                                            CComuna.agregarcablecomuna(tablacablecomu[i]);
                                        }
                                    } break;
                                case 51:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa telefónica\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa telefónica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese código y modelo del modem\n");
                                            modem = Console.ReadLine();
                                            Console.WriteLine("Ingrese cantidad de bocas conectadas\n");
                                            cantbocas = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese el tipo de servicio(plan del cliente)\n");
                                            tiposervicio = Console.ReadLine();
                                            Console.WriteLine("Ingrese nombre del personal que atendio en la última visita al cliente\n");
                                            personal = Console.ReadLine();


                                            tablainternetcasa[i] = new internetcasa(empresa, direccion, telefono, modem, tiposervicio, cantbocas, personal);
                                            IDomi.agregarinternetcasa(tablainternetcasa[i]);
                                        }
                                    } break;
                                case 52:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa internet\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa internet\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese Antena\n");
                                            antena = Console.ReadLine();
                                            Console.WriteLine("Ingrese datos caja\n");
                                            cajaString = Console.ReadLine();



                                            tablainternetbarrio[i] = new internetbarrio(empresa, direccion, telefono, antena, cajaString);
                                            IBarrio.agregarinternetbarrio(tablainternetbarrio[i]);
                                        }
                                    } break;
                                case 53:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa telefónica\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa telefónica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese comunidad(Villa Libertad/Villa San Martin/etc.)\n");
                                            comunidad = Console.ReadLine();
                                            Console.WriteLine("Ingrese Zona(sur/norte/este/oeste)\n");
                                            zona = Console.ReadLine();



                                            tablainternetcomu[i] = new internetcomunidad(empresa, direccion, telefono, comunidad, zona);
                                            IComuna.agregarinternetcomuna(tablainternetcomu[i]);
                                        }
                                    } break;
                                case 61:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa/municipalidad recolectora\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa/municipalidad recolectora\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese camión recolector\n");
                                            recolector = Console.ReadLine();
                                            Console.WriteLine("Ingrese contenedor\n");
                                            contenedor = Console.ReadLine();
                                            Console.WriteLine("Ingrese tipo de cliente(residencial/empresa/otros)\n");
                                            tipocliente = Console.ReadLine();
                                            Console.WriteLine("Ingrese el tipo de servicio(plan del cliente)\n");
                                            tiposervicio = Console.ReadLine();
                                            Console.WriteLine("Ingrese nombre del personal que atendio en la última visita al cliente\n");
                                            personal = Console.ReadLine();


                                            tablarecoleccioncasa[i] = new residuoscasa(empresa, direccion, telefono, cliente, tipocliente, recolector, personal, contenedor);
                                            RDomi.agregarteldomi(tablatelcasa[i]);
                                        }
                                    } break;
                                case 62:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa agua\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa agua\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese hora de inicio recorrido recolección de residuos barrial(en nro, ej; 1,2..12,20)\n");
                                            horainicio = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese N° ruta de recorrido\n");
                                            nroruta = int.Parse(Console.ReadLine());



                                            tablarecoleccionbarrio[i] = new residuosbarrio(empresa, direccion, telefono, horainicio, nroruta);
                                            RBarrio.agregarrecolecbarrial(tablarecoleccionbarrio[i]);
                                        }
                                    } break;
                                case 63:
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            Console.WriteLine("Ingrese nombre de la empresa/municipalidad recolectora\n");
                                            empresa = Console.ReadLine();
                                            Console.WriteLine("Ingrese domicilio de la empresa/municipalidad telefónica\n");
                                            direccion = Console.ReadLine();
                                            Console.WriteLine("Ingrese teléfono de la compañía/municipalidad \n");
                                            telefono = long.Parse(Console.ReadLine());

                                            Console.WriteLine("Ingrese comunidad(Villa Libertad/Villa San Martin/etc.)\n");
                                            comunidad = Console.ReadLine();
                                            Console.WriteLine("Ingrese zon(sur/norte/este/oeste)\n");
                                            zona = Console.ReadLine();



                                            tablarecoleccioncomu[i] = new residuoscomumidad(empresa, direccion, telefono, comunidad, antena);
                                            RComuna.agregarrecolcomuna(tablarecoleccioncomu[i]);
                                        }
                                    } break;
                            }//cierra el switch
                            }break;//cierra case 5
                            
                        
                    case 6:
                        {
                            Console.WriteLine("MENU CONSULTAS\n");
                            Console.WriteLine("1- Personas");
                            Console.WriteLine("2- Animales domesticos");
                            Console.WriteLine("3- Animales salvajes\n");
                            
                            Console.WriteLine("Consulta Servicios:\n");
                            
                            Console.WriteLine("4 - Luz Casas");
                            Console.WriteLine("5 - Luz Comunidad");
                            Console.WriteLine("6- Luz Barrios");
                            Console.WriteLine("7 - Agua Casas");
                            Console.WriteLine("8 - Agua Barrios");
                            Console.WriteLine("9- Agua Comunidad");
                            Console.WriteLine("10 - Telefono Casas");
                            Console.WriteLine("11 - Telefono Barrios");
                            Console.WriteLine("12- Telefono Comunidad");
                            Console.WriteLine("13 - Internet Casas");
                            Console.WriteLine("14 - Internet Barrios");
                            Console.WriteLine("15- Internet Comunidad");
                            Console.WriteLine("16 - Cable Casas");
                            Console.WriteLine("17 - Cable Barrios");
                            Console.WriteLine("18- Cable Comunidad");
                            Console.WriteLine("19 - Recoleccion Residuos Casas");
                            Console.WriteLine("20 - Recoleccion Residuos Barrios");
                            Console.WriteLine("21- Recoleccion Residuos Comunidad");
                            Console.WriteLine("Consultar caracteristicas de las casas del barrio");
                            Console.WriteLine("22- Dormitorios");
                            Console.WriteLine("23- Baños");
                            Console.WriteLine("24 - Jardines");
                            Console.WriteLine("25 - Garajes");
                            Console.WriteLine("26- Quinchos");
                            Console.WriteLine("27-Cocinas");
                            Console.WriteLine("28 - Volver al menu anterior\n");
                            
                            eleccion = int.Parse(Console.ReadLine());
                            Console.ReadKey();
                            switch (eleccion)
                            {
                                case 4:
                                    {
                                        Console.WriteLine("Empresa    Direccion-empresa   Tel-empresa     Cliente     TipoCliente       Medidor          Tensión      Personal\n");
                                        LuzDomi.mostrarConexionesluzdomi();

                                       
                                    } break;
                                case 5 :
                                    {
                                        Console.WriteLine("Empresa    Direccion-empresa               Tel-empresa                  Comunidad                 Zona\n");

                                        LuzComuna.mostrarzona();
                                                                                                               
                                   } break;
                                     
                                                                  
                                case 6 :
 
                                    {
                                        
                                        Console.WriteLine("Empresa".PadLeft(5) + "Direccion-empresa".PadLeft(30) + "Tel-empresa".PadLeft(10)+"Transformador".PadLeft(30) + "Poste\n".PadLeft(30));

                                        LuzBarrio.mostraralumbrado();

                                    } break;
                                case 1:
                                    {

                                         //consultar personas
                                                {
                                                    Persona.mostrarPersonas();
                                                } break;
                                            
                                        }
                                case 2 : //consultar mascotas
                                       {
                                                    chaletAmarillo.mostratMascotas();
                                                } break;

                                case 3: //consultas salvajes
                                                {
                                                    chaletRojo.mostratSalvajes();
                                                } break;
                                case 7:         {//consulta agua domicilio

                                                    ADomi.mostrarConexionesaguadomi();
                                                }break;
                                case 8:         { // consulta agua barrio

                                                    ABarrio.mostrarpluviales();
                                                }break;
                                case 9:         {//consulta agua comuna
                                                    AComuna.mostrartroncales();
                                                }break;
                                case 10:        {//consulta telefonos casa
                                                    TDomi.mostrarteldomi();
                                                }break;
                                case 11:        {//consulta telefonos barrios
                                                 TBarrio.mostrartelbarrio();
                                                 }break;
                                case 12:        {//consulta telefonos comunidad
                                                    TComuna.mostrarredcomuna();
                                                }break;
                                case 13:        {//consulta internet casas
                                                    IDomi.mostrarinternetcasa();
                                                }break;
                                case 14:        {//consulta internet barrio
                                                    IBarrio.mostrarinternetbarrio();
                                                }break;
                                case 15:        {//consultas internet comunidad
                                                    IComuna.mostrarinternetcomunidad();
                                                }break;
                                case 16:        {// consulta cable casas
                                                    CDomi.mostrarcabledomi();
                                                }break;
                                case 17:        {//consulta cable barrio
                                                    CBarrio.mostrarcablebarrio();
                                                } break;
                                case 18:        {//consulta cable comunidad
                                                    CComuna.mostrarcablecomuna();
                                                }break;
                                case 19:        {//consulta recoleccion residuos casas
                                                    RDomi.mostrarrecoleccioncasa();
                                                }break;
                                case 20:        {//consulta recoleccion residuos barrio
                                                    RBarrio.mostrarrecoleccionbarrio();
                                                }break;
                                case 21:        {//consulta recoleccion de residuos comunidad
                                                    RComuna.mostrarrecoleccioncomunidad();

                                                }break;
                                case 22:        {//consulta dormitorios
                                                    chaletRojo.mostrardormitorio();
                                                }break;
                                case 23:        {//consulta baños
                                                    chaletRojo.mostrarbaño();
                                                }break;
                                case 24:        {//consulta jardines
                                                    chaletRojo.mostrarjardin();
                                                }break;
                                case 25 :       {//consulta garajes
                                                     chaletRojo.mostrargarage();
                                                } break;
                                case 26:        {//consulta quinchos
                                                    chaletRojo.mostrarquincho();
                                                }break;
                                case 27:        {//consulta cocinas
                                                    chaletRojo.mostrarcocina();
                                                 }break;
                                case 28: break;


                            }
                        }
                        break;

                    case 7: 
                            //este menu sirve para imprimir en txt o en pdf o en impresora
                            for (int i= 0; i<2 ; i++)
                                {
                                    chaletAmarillo.persistir(tablaDomesticos[i]);

                                }

                            break;
                        
                    case 8 :
                        {
                            Console.WriteLine("Gracias, por utilizar nuestros servicios\n");
                            Console.ReadKey();
                            continuar = false;
                        }
                        break;

                }
            }while (continuar);
                }
            }
            
     
}

               
              

                    
               