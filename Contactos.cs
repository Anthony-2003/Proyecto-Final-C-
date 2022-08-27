using System;
using AgendaElectronica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace AgendaContactosApp
{
    class ClaseContactos
    {
        public static void verContactos()
        {
            Console.Clear();
              if (!File.Exists("contactos.txt"))
        {
            // Create a file to write to.
            using (StreamWriter CrearAgenda = File.CreateText("contactos.txt"))
            {

            }	
        }
            StreamReader lector = new StreamReader("contactos.txt");
            string linea;

            string[] campos = new string[5];
            Console.WriteLine(" Lista de Contactos");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.ForegroundColor = ConsoleColor.Gray;
            while ((linea = lector.ReadLine()) != null)
            {
                campos = linea.Split(',');
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" Nombre     : " + campos[0]);
                Console.WriteLine(" Apellido   : " + campos[1]);
                Console.WriteLine(" N° Telefono: " + campos[2]);
                Console.WriteLine(" Direccion  : " + campos[3]);
                Console.WriteLine(" Correo     : " + campos[4]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            lector.Close();
            Console.WriteLine();
            Console.WriteLine(" Presiona cualquier tecla para volver...");
            Console.ReadLine();
            Console.Clear();
            MenuPrincipal();

        }

        public static void buscarContactos()
        {

        inicio:
            Console.Clear();
            StreamReader lector = File.OpenText("Contactos.txt");
            lector.Close();
            string cadena;
            bool encontrado = false;
            string[] campos = new string[5];
            string respuesta = string.Empty;
            Console.WriteLine(" Seleccione el parametro para buscar: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine(" [1] Nombre[s].");
            Console.WriteLine(" [2] Apellido[s].");
            Console.WriteLine(" [3] N° Telefono.");
            Console.WriteLine(" [4] Correo Electronico.");
            Console.WriteLine(" [5] Volver al Menu Principal.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Escoge una opción: ");
            string parametro = Console.ReadLine().Trim();

            switch (parametro)
            {
                case "1":

                nombre:
                    Console.Clear();
                    lector = File.OpenText("contactos.txt");
                    Console.WriteLine("");
                    Console.Write(" Ingrese el Nombre del Contacto a buscar: ");
                    parametro = Console.ReadLine();
                     Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');

                        if (campos[0].Trim().Equals(parametro))
                        {   
                            Console.WriteLine("");
                            Console.WriteLine(" Resultado de la Busqueda: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre[s]  : " + campos[0].Trim());
                            Console.WriteLine(" Apellido[s]: " + campos[1].Trim());
                            Console.WriteLine(" Telefono   : " + campos[2].Trim());
                            Console.WriteLine(" Direccion  : " + campos[3].Trim());
                            Console.WriteLine(" Correo     : " + campos[4].Trim());
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El Contacto con el nombre [");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        Console.WriteLine(" No existe!!");
                        lector.Close();
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas Realizar Otra Busqueda? ([s] = si  o [n] = no): ");

                    if ((respuesta = Console.ReadLine().ToLower()) == "s")
                    {
                        cadena = "";
                        lector.Close();
                        Console.Clear();
                        goto nombre;
                    }

                    else
                    {
                        lector.Close();
                        goto inicio;
                    }
                    ;

                case "2":
                fecha:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.Write(" Ingrese el Apellido del Contacto a buscar: ");
                    parametro = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    lector = File.OpenText("contactos.txt");

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');
                        if (campos[1].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Resultado de la Busqueda: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre[s]  : " + campos[0].Trim());
                            Console.WriteLine(" Apellido[s]: " + campos[1].Trim());
                            Console.WriteLine(" Telefono   : " + campos[2].Trim());
                            Console.WriteLine(" Direccion  : " + campos[3].Trim());
                            Console.WriteLine(" Correo     : " + campos[4].Trim());
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El Contacto con el Apellido [");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        Console.WriteLine(" no existe!");
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas buscar otro Contacto? ([s] = si  o [n] = no): ");

                    if ((respuesta = Console.ReadLine()) == "s")
                    {
                        cadena = "";
                        lector.Close();
                        Console.Clear();
                        goto fecha;
                    }

                    else
                    {
                        lector.Close();
                        goto inicio;
                    }
                    ;

                case "3":
                hora:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.Write(" Ingrese el N° Telefonico para buscar: ");
                    parametro = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    lector = File.OpenText("contactos.txt");
                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');
                        if (campos[2].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Resultado de la Busqueda: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre[s]  : " + campos[0].Trim());
                            Console.WriteLine(" Apellido[s]: " + campos[1].Trim());
                            Console.WriteLine(" Telefono   : " + campos[2].Trim());
                            Console.WriteLine(" Direccion  : " + campos[3].Trim());
                            Console.WriteLine(" Correo     : " + campos[4].Trim());
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El Contacto con el Telefono [");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        Console.WriteLine(" no existe");
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas buscar otro Contacto? ([s] = si  o [n] = no): ");

                    if ((respuesta = Console.ReadLine()) == "s")
                    {
                        cadena = "";
                        lector.Close();
                        Console.Clear();
                        goto hora;
                    }

                    else
                    {
                        lector.Close();
                        goto inicio;
                    }
                    ;

                case "4":
                lugar:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.Write(" Ingrese el Correo Electronico para buscar: ");
                    parametro = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    lector = File.OpenText("contactos.txt");

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');
                        if (campos[4].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Resultado de la Busqueda: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre[s]  : " + campos[0].Trim());
                            Console.WriteLine(" Apellido[s]: " + campos[1].Trim());
                            Console.WriteLine(" Telefono   : " + campos[2].Trim());
                            Console.WriteLine(" Direccion  : " + campos[3].Trim());
                            Console.WriteLine(" Correo     : " + campos[4].Trim());
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El Contacto con el Correo Electronico [");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        Console.WriteLine(" no existe");
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas buscar otro Contacto? ([s] = si  o [n] = no): ");

                    if ((respuesta = Console.ReadLine()) == "s")
                    {
                        cadena = "";
                        lector.Close();
                        Console.Clear();
                        goto lugar;
                    }

                    else
                    {
                        lector.Close();
                        goto inicio;
                    }
                    ;
                case "5":
                    Console.Clear();
                    MenuPrincipal();
                    break;
                    ;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Esta opción no esta disponible, intente de nuevo.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                    goto inicio;
                    ;
            }
        }

        public static void crearContactos()
        {
            Console.Clear();
            Contactos datos = new Contactos();
            Console.Write("");
            Console.Write("");
            Console.WriteLine("Ingresa los datos Solicitados:");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.Write("");
            Console.Write("");
            Console.Write("Nombre        : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            Console.Write("Apellido      : ");
            string apellido = Console.ReadLine();
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.Write("N° de Telefono: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.Write(" Direccion    : ");
            string direccion = Console.ReadLine();
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");            
            Console.Write(" Correo       : ");
            string correo = Console.ReadLine();
            Console.Write("");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            datos.nombre = nombre;
            datos.apellido = apellido;
            datos.telefono = telefono;
            datos.direccion = direccion;
            datos.correo = correo;

            TextWriter guardar = File.AppendText("contactos.txt");

            guardar.WriteLine(nombre + "," + apellido + "," + telefono + "," + direccion + "," + correo);

            guardar.Close();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Contacto Guardado Exitosamente");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(1000);

            Console.Clear();
            MenuPrincipal();
        }

        public static void editarContactos()
        {
        inicio2:

            StreamReader lector = File.OpenText("contactos.txt");
            StreamWriter AgendaTemp = File.CreateText("AgendaTemp.txt");

            Console.Clear();
            string newNombre, newApellido, newTelefono, newDireccion, newCorreo;

            bool encontrado = false;
            string cadena;
            string[] campos = new string[5];
            string respuesta = string.Empty;

            Console.WriteLine("");
            Console.Write(" Ingrese el Nombre del Contacto a modificar: ");
            string nombre = Console.ReadLine().Trim();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.ForegroundColor = ConsoleColor.Gray;

            while ((cadena = lector.ReadLine()) != null)
            {
                campos = cadena.Split(',');
                if (campos[0].Trim().Equals(nombre))
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Resultado de la Busqueda: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    Console.WriteLine(" Nombre[s]  : " + campos[0].Trim());
                    Console.WriteLine(" Apellido[s]: " + campos[1].Trim());
                    Console.WriteLine(" Telefono   : " + campos[2].Trim());
                    Console.WriteLine(" Direccion  : " + campos[3].Trim());
                    Console.WriteLine(" Correo     : " + campos[4].Trim());
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    encontrado = true;
                }

                else
                {
                    AgendaTemp.WriteLine(cadena);
                }

            }

            if (encontrado == true)
            {
                Console.WriteLine("");
                Console.WriteLine(" ¿Cual de estos datos desea modificar?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                Console.WriteLine(" [1] Nombre");
                Console.WriteLine(" [2] Apellido");
                Console.WriteLine(" [3] N° Telefono");
                Console.WriteLine(" [4] Direccion");
                Console.WriteLine(" [5] Correo Electronico");
                Console.WriteLine(" [6] Modificar Todo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" Escoge una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write(" Ingresa el nuevo Nombre del Contacto: ");
                        newNombre = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        

                        AgendaTemp.WriteLine((newNombre + "," + campos[1] + "," + campos[2] + "," + campos[3] + "," + campos[4]).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine(" El nombre se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.Close();
                        lector.Close();

                        File.Delete("contactos.txt");
                        File.Move("AgendaTemp.txt", "contactos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro Contacto? ([s] = si  o [n] = no): ");

                        if ((opcion = Console.ReadLine()) == "s")
                        {
                            Console.Clear();
                            goto inicio2;
                        }

                        else
                        {
                            Console.Clear();
                            MenuPrincipal();
                        }
                        break;

                    case "2":
                        Console.Write(" Ingrese el nuevo Apellido del Contacto: ");
                        newApellido = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.WriteLine((campos[0] + "," + newApellido + "," + campos[2] + "," + campos[3] + "," + campos[4]).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("");
                        Console.WriteLine(" El Apellido se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.Close();
                        lector.Close();

                        File.Delete("contactos.txt".Trim());
                        File.Move("AgendaTemp.txt".Trim(), "contactos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro Contactos? ([s] = si  o [n] = no): ");

                        if ((opcion = Console.ReadLine()) == "s")
                        {
                            Console.Clear();
                            goto inicio2;
                        }

                        else
                        {
                            Console.Clear();
                            MenuPrincipal();
                        }

                        break; ;

                    case "3":
                        Console.Write(" Ingrese el nuevo N° de Telefono: ");
                        newTelefono = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.WriteLine((campos[0] + "," + campos[1] + "," + newTelefono + "," + campos[3] + "," + campos[4]).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine(" N° de Telefono modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.Close();
                        lector.Close();

                        File.Delete("contactos.txt".Trim());
                        File.Move("AgendaTemp.txt".Trim(), "contactos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro Contacto? ([s] = si  o [n] = no): ");

                        if ((opcion = Console.ReadLine()) == "s")
                        {
                            Console.Clear();
                            goto inicio2;
                        }

                        else
                        {
                            Console.Clear();
                            MenuPrincipal();
                        }

                        break; ;

                    case "4":
                        Console.Write(" Ingrese la nueva Direccion: ");
                        newDireccion = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.WriteLine((campos[0] + "," + campos[1] + "," + campos[2] + "," + newDireccion + "," + campos[4]).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine(" La Direccion se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.Close();
                        lector.Close();

                        File.Delete("contactos.txt".Trim());
                        File.Move("AgendaTemp.txt".Trim(), "contactos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro Contacto? ([s] = si  o [n] = no): ");

                        if ((opcion = Console.ReadLine()) == "s")
                        {
                            Console.Clear();
                            goto inicio2;
                        }

                        else
                        {
                            Console.Clear();
                            MenuPrincipal();
                        }

                        break; //

                    case "5":
                        Console.Write(" Ingresa el nuevo Correo Electronico: ");
                        newCorreo = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.WriteLine((campos[0] + "," + campos[1] + "," + campos[2] + "," + campos[3]+ "," + newCorreo).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine(" La Direccion se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.Close();
                        lector.Close();

                        File.Delete("contactos.txt".Trim());
                        File.Move("AgendaTemp.txt".Trim(), "contactos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro Contacto? ([s] = si  o [n] = no): ");

                        if ((opcion = Console.ReadLine()) == "s")
                        {
                            Console.Clear();
                            goto inicio2;
                        }

                        else
                        {
                            Console.Clear();
                            MenuPrincipal();
                        }

                        break;

                    case "6":
                        Console.WriteLine(" Ingrese los nuevos datos del contacto:");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write(" Nuevo Nombre[s]  : ");
                        newNombre = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write(" Nuevo Apellido[s]: ");
                        newApellido = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write(" Nuevo N° Telefono: ");
                        newTelefono = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write(" Nueva Direccion  :");
                        newDireccion = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write(" Nuevo Correo     : ");
                        newCorreo = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.WriteLine((newNombre + "," + newApellido + "," + newTelefono + "," + newDireccion + "," + newCorreo).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine(" Los datos del Contacto modificados Exitosamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        AgendaTemp.Close();
                        lector.Close();

                        File.Delete("contactos.txt".Trim());
                        File.Move("AgendaTemp.txt".Trim(), "contactos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro Contacto? ([s] = si  o [n] = no): ");

                        if ((opcion = Console.ReadLine()) == "s")
                        {
                            Console.Clear();
                            goto inicio2;
                        }

                        else
                        {
                            Console.Clear();
                            MenuPrincipal();
                        }

                        break; ;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Esta opción no esta disponible, Por favor intente de nuevo");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto inicio2;
                        ;
                }
            }

            else
            {
                Console.Write(" El Contacto con el nombre [");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(nombre);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("]");
                Console.WriteLine(" no existe");
                Console.Write(" ¿Deseas buscar otro Contacto? ([s] = si  o [n] = no): ");
                if ((respuesta = Console.ReadLine()) == "s")
                {
                    lector.Close();
                    AgendaTemp.Close();
                    goto inicio2;
                }

                else
                {
                    Console.Clear();
                    lector.Close();
                    AgendaTemp.Close();
                    MenuPrincipal();
                }
            }
        }

        public static void borrarContactos()
        {
        inicioMenuBorrar:
            Console.Clear();

            string cadena;
            bool encontrado = false;
            string[] campos = new string[4];
            string respuesta = string.Empty;
            
            Console.WriteLine("");
            Console.WriteLine(" Seleciones una opcion de Borrado");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine(" [1] Borrar un Contacto");
            Console.WriteLine(" [2] Borrar todos los Contactos");
            Console.WriteLine(" [3] Volver al menu principal");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Escoge una opción: ");
            string parametro = Console.ReadLine().Trim();

            switch (parametro)
            {
                case "1":

                inicioNombreBorrar:

                    Console.Clear();
                    StreamReader lector = File.OpenText("contactos.txt");
                    StreamWriter AgendaTemp2 = File.CreateText("AgendaTemp2.txt");

                    Console.Write(" Ingrese el nombre del Contacto a borrar: ");
                    parametro = Console.ReadLine();

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');

                        if (campos[0].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Resultado de la Busqueda: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre[s]  : " + campos[0].Trim());
                            Console.WriteLine(" Apellido[s]: " + campos[1].Trim());
                            Console.WriteLine(" Telefono   : " + campos[2].Trim());
                            Console.WriteLine(" Direccion  : " + campos[3].Trim());
                            Console.WriteLine(" Correo     : " + campos[4].Trim());
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            encontrado = true;
                        }

                        else
                        {
                            AgendaTemp2.WriteLine(cadena);
                        }
                    }

                    if (encontrado == false)
                    {
                        Console.Write(" El Contacto con el nombre [");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("]");
                        Console.WriteLine(" no existe!");
                        Console.Write(" ¿Deseas Buscar Nuevamente? ([s] = si  o [n] = no): ");

                        if ((parametro = Console.ReadLine().ToLower()) == "s")
                        {
                            AgendaTemp2.Close();
                            Console.Clear();
                            goto inicioNombreBorrar;
                        }

                        else
                        {
                            goto inicioMenuBorrar;
                        }
                    }

                    encontrado = false;
                    Console.Write(" ¿Seguro que deseas Eliminar este Contacto? ([s] = si  o [n] = no): ");

                    if ((parametro = Console.ReadLine().ToLower()) == "s")
                    {
                        AgendaTemp2.Close();
                        lector.Close();

                        File.Delete("contactos.txt");
                        File.Move("AgendaTemp2.txt", "contactos.txt");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine(" Contacto eliminado satisfactoriamente. ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" ¿Deseas Eliminar otro Contacto? ([s] = si  o [n] = no): ");

                        if ((parametro = Console.ReadLine().ToLower()) == "s")
                        {
                            AgendaTemp2.Close();
                            Console.Clear();
                            goto inicioNombreBorrar;
                        }

                        else
                        {
                            goto inicioMenuBorrar;
                        }
                    }

                    else
                    {
                        goto inicioMenuBorrar;
                    }

                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("             ADVERTENCIA!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(@" 
                                        Esta opcion de elimina tus contactos. 
                                         No se podran recuperar despues de
                                             haber sido eliminados.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    Console.Write(" ¿Seguro que deseas eliminar todos los Contactos? ([s] = si  o [n] = no): ");
                    if ((parametro = Console.ReadLine().ToLower()) == "s")
                    {                      
                        File.Delete("contactos.txt");
                        StreamWriter crear = new StreamWriter("contactos.txt");
                        crear.Close();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine(" Has eliminado todos los Contactos!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1000);
                        goto inicioMenuBorrar;
                    }
                    else
                    {
                        goto inicioMenuBorrar;
                    }

                case "3":
                    Console.Clear();
                    MenuPrincipal();
                    break;
                    ;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Esta opción no esta disponible, intente denuevo");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                    goto inicioMenuBorrar;
            }
        }
        public static void MenuPrincipal()
        {

        inicio:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine(@"                                         
                                                                             ██████╗ ██████╗ ███╗   ██╗████████╗ █████╗  ██████╗████████╗ ██████╗ ███████╗
                                                                            ██╔════╝██╔═══██╗████╗  ██║╚══██╔══╝██╔══██╗██╔════╝╚══██╔══╝██╔═══██╗██╔════╝
                                                                            ██║     ██║   ██║██╔██╗ ██║   ██║   ███████║██║        ██║   ██║   ██║███████╗
                                                                            ██║     ██║   ██║██║╚██╗██║   ██║   ██╔══██║██║        ██║   ██║   ██║╚════██║
                                                                            ╚██████╗╚██████╔╝██║ ╚████║   ██║   ██║  ██║╚██████╗   ██║   ╚██████╔╝███████║
                                                                             ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝   ╚═╝    ╚═════╝ ╚══════╝");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                    [1] Mostrar Lista de Contactos
                                                                                                    [2] Buscar Contactos
                                                                                                    [3] Agregar un Contacto
                                                                                                    [4] Editar Contactos
                                                                                                    [5] Borrar Contactos
                                                                                                    [6] Volver al menu principal");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                                                                                                    Escoge una opción: ");
            string opcion = (Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    verContactos();
                    break;
                    ;
                case "2":
                    buscarContactos();
                    break;
                    ;
                case "3":
                    crearContactos();
                    break;
                    ;
                case "4":
                    editarContactos();
                    break;
                    ;
                case "5":
                    borrarContactos();
                    break;
                    ;
                    case "6":
                    Console.Clear();
                    AgendaElectronica.AgendaElectronica.Main();
                    break;
                    ;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Esta opción no esta disponible, intente de nuevo");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto inicio;
                    ;
            }

            Console.ReadKey();
        }
        public class Contactos
        {
            //public int numero Contacto { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string telefono { get; set; }
            public string direccion { get; set; }
            public string correo { get; set; }
        }
    }
}