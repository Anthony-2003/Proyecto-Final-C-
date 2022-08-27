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

namespace AgendaEventosApp
{
    class ClaseEventos
    {
        public static void verEventos()
        {
            Console.Clear();
            StreamReader lector = new StreamReader("eventos.txt");
            string linea;

            string[] campos = new string[4];

            while ((linea = lector.ReadLine()) != null)
            {
                campos = linea.Split(',');
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" Nombre: " + campos[0]);
                Console.WriteLine(" Fecha: " + campos[1]);
                Console.WriteLine(" Hora: " + campos[2]);
                Console.WriteLine(" Lugar: " + campos[3]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            lector.Close();
            Console.WriteLine();
            Console.WriteLine(" Presiona cualquier tecla para salir...");
            Console.ReadLine();
            Console.Clear();
            MenuPrincipal();

        }

        public static void buscarEventos()
        {

        inicio:
            Console.Clear();
            StreamReader lector = File.OpenText("eventos.txt");
            lector.Close();
            string cadena;
            bool encontrado = false;
            string[] campos = new string[4];
            string respuesta = string.Empty;

            Console.WriteLine(" Ingresa el parametro por el que desea buscar");
            Console.WriteLine(" [1] Nombre");
            Console.WriteLine(" [2] Fecha");
            Console.WriteLine(" [3] Hora");
            Console.WriteLine(" [4] Lugar");
            Console.WriteLine(" [5] Volver al menu principal");
            Console.Write(" Escoge una opción: ");
            string parametro = Console.ReadLine().Trim();

            switch (parametro)
            {
                case "1":

                nombre:
                    Console.Clear();
                    lector = File.OpenText("eventos.txt");
                    Console.Write(" Ingresa el nombre del evento a buscar: ");
                    parametro = Console.ReadLine();

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');

                        if (campos[0].Trim().Equals(parametro))
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Nombre: " + campos[0].Trim());
                            Console.WriteLine(" Fecha: " + campos[1].Trim());
                            Console.WriteLine(" Hora: " + campos[2].Trim());
                            Console.WriteLine(" Lugar: " + campos[3].Trim());
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El evento con el nombre ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" no existe");
                        lector.Close();
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas buscar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                    Console.Write(" Ingresa la fecha del evento a buscar: ");
                    parametro = Console.ReadLine();
                    lector = File.OpenText("eventos.txt");

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');
                        if (campos[1].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre: " + campos[0].Trim());
                            Console.WriteLine(" Fecha: " + campos[1].Trim());
                            Console.WriteLine(" Hora: " + campos[2].Trim());
                            Console.WriteLine(" Lugar: " + campos[3].Trim());
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El evento con la fecha ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" no existe");
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas buscar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                    Console.Write(" Ingresa la hora del evento a buscar: ");
                    parametro = Console.ReadLine();
                    lector = File.OpenText("eventos.txt");
                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');
                        if (campos[2].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre: " + campos[0].Trim());
                            Console.WriteLine(" Fecha: " + campos[1].Trim());
                            Console.WriteLine(" Hora: " + campos[2].Trim());
                            Console.WriteLine(" Lugar: " + campos[3].Trim());
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El evento con la hora ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" no existe");
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas buscar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                    Console.Write(" Ingresa el lugar del evento a buscar: ");
                    parametro = Console.ReadLine();
                    lector = File.OpenText("eventos.txt");

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');
                        if (campos[3].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre: " + campos[0].Trim());
                            Console.WriteLine(" Fecha: " + campos[1].Trim());
                            Console.WriteLine(" Hora: " + campos[2].Trim());
                            Console.WriteLine(" Lugar: " + campos[3].Trim());
                            Console.WriteLine("");
                            encontrado = true;
                        }
                    }

                    lector.Close();

                    if (encontrado == false)
                    {
                        Console.Write(" El evento con el lugar ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" no existe");
                    }

                    encontrado = false;
                    Console.Write(" ¿Deseas buscar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                    Console.WriteLine(" Esta opción no esta disponible");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                    goto inicio;
                    ;
            }
        }

        public static void crearEventos()
        {
            Console.Clear();
            Eventos evento = new Eventos();

            Console.Write(" Ingresa el nombre del evento: ");
            string nombreEvento = Console.ReadLine();

            Console.Write(" Ingresa la fecha del evento: ");
            string fechaEvento = Console.ReadLine();

            Console.Write(" Ingresa la hora del evento: ");
            string horaEvento = Console.ReadLine();

            Console.Write(" Ingresa el lugar del evento: ");
            string lugarEvento = Console.ReadLine();

            evento.nombreEvento = nombreEvento;
            evento.fechaEvento = fechaEvento;
            evento.horaEvento = horaEvento;
            evento.lugarEvento = lugarEvento;

            TextWriter guardar = File.AppendText("eventos.txt");

            guardar.WriteLine(nombreEvento + "," + fechaEvento + "," + horaEvento + "," + lugarEvento);

            guardar.Close();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" El evento se ha guardado satisfactoriamente");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(1000);

            Console.Clear();
            MenuPrincipal();
        }

        public static void editarEventos()
        {
        inicio2:

            StreamReader lector = File.OpenText("eventos.txt");
            StreamWriter temporal = File.CreateText("temporal.txt");

            Console.Clear();
            string newNombre, newFecha, newHora, newLugar;

            bool encontrado = false;
            string cadena;
            string[] campos = new string[4];
            string respuesta = string.Empty;

            Console.Write(" Ingresa el nombre del evento a modificar: ");
            string nombre = Console.ReadLine().Trim();

            while ((cadena = lector.ReadLine()) != null)
            {
                campos = cadena.Split(',');
                if (campos[0].Trim().Equals(nombre))
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Nombre: " + campos[0].Trim());
                    Console.WriteLine(" Fecha: " + campos[1].Trim());
                    Console.WriteLine(" Hora: " + campos[2].Trim());
                    Console.WriteLine(" Lugar: " + campos[3].Trim());
                    encontrado = true;
                }

                else
                {
                    temporal.WriteLine(cadena);
                }

            }

            if (encontrado == true)
            {
                Console.WriteLine("");
                Console.WriteLine(" ¿Qué desea modificar?");
                Console.WriteLine(" [1] Nombre");
                Console.WriteLine(" [2] Fecha");
                Console.WriteLine(" [3] Hora");
                Console.WriteLine(" [4] Lugar");
                Console.WriteLine(" [5] Todo");
                Console.Write(" Escoge una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write(" Ingresa el nuevo nombre del evento: ");
                        newNombre = Console.ReadLine();

                        temporal.WriteLine((newNombre + "," + campos[1] + "," + campos[2] + "," + campos[3]).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" El nombre del evento se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        temporal.Close();
                        lector.Close();

                        File.Delete("eventos.txt");
                        File.Move("temporal.txt", "eventos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                        Console.Write(" Ingresa la nueva fecha del evento: ");
                        newFecha = Console.ReadLine();

                        temporal.WriteLine((campos[0] + "," + newFecha + "," + campos[2] + "," + campos[3]).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" La fecha del evento se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        temporal.Close();
                        lector.Close();

                        File.Delete("eventos.txt".Trim());
                        File.Move("temporal.txt".Trim(), "eventos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                        Console.Write(" Ingresa la nueva hora del evento: ");
                        newHora = Console.ReadLine();

                        temporal.WriteLine((campos[0] + "," + campos[1] + "," + newHora + "," + campos[3]).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" La hora del evento se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        temporal.Close();
                        lector.Close();

                        File.Delete("eventos.txt".Trim());
                        File.Move("temporal.txt".Trim(), "eventos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                        Console.Write("Ingresa el nuevo lugar del evento: ");
                        newLugar = Console.ReadLine();

                        temporal.WriteLine((campos[0] + "," + campos[1] + "," + campos[2] + "," + newLugar).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" La hora del evento se ha modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        temporal.Close();
                        lector.Close();

                        File.Delete("eventos.txt".Trim());
                        File.Move("temporal.txt".Trim(), "eventos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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

                    case "5":
                        Console.Write(" Ingresa el nuevo nombre del evento: ");
                        newNombre = Console.ReadLine();

                        Console.Write(" Ingresa la nueva fecha del evento: ");
                        newFecha = Console.ReadLine();

                        Console.Write(" Ingresa la nueva hora del evento: ");
                        newHora = Console.ReadLine();

                        Console.Write(" Ingresa el nuevo lugar del evento: ");
                        newLugar = Console.ReadLine();

                        temporal.WriteLine((newNombre + "," + newFecha + "," + newHora + "," + newLugar).Trim());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" Los datos del evento se han modificado satisfactoriamente.");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        temporal.Close();
                        lector.Close();

                        File.Delete("eventos.txt".Trim());
                        File.Move("temporal.txt".Trim(), "eventos.txt".Trim());

                        Console.WriteLine("");
                        Console.Write(" ¿Deseas modificar otro evento? (escribe 's' para continuar o cualquier para salir): ");

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
                        Console.WriteLine(" Esta opción no esta disponible");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto inicio2;
                        ;
                }
            }

            else
            {
                Console.Write(" El evento con el nombre ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(nombre);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" no existe");
                Console.Write(" ¿Deseas buscar otro evento? (escribe 's' para continuar o cualquier para salir): ");
                if ((respuesta = Console.ReadLine()) == "s")
                {
                    lector.Close();
                    temporal.Close();
                    goto inicio2;
                }

                else
                {
                    Console.Clear();
                    lector.Close();
                    temporal.Close();
                    MenuPrincipal();
                }
            }
        }

        public static void borrarEventos()
        {
        inicioMenuBorrar:
            Console.Clear();

            string cadena;
            bool encontrado = false;
            string[] campos = new string[4];
            string respuesta = string.Empty;

            Console.WriteLine(" Ingresa el parametro por el que desea borrar");
            Console.WriteLine(" [1] Borrar un evento en particular");
            Console.WriteLine(" [2] Borrar todos los eventos");
            Console.WriteLine(" [3] Volver al menu principal");
            Console.Write(" Escoge una opción: ");
            string parametro = Console.ReadLine().Trim();

            switch (parametro)
            {
                case "1":

                inicioNombreBorrar:

                    Console.Clear();
                    StreamReader lector = File.OpenText("eventos.txt");
                    StreamWriter temporal2 = File.CreateText("temporal2.txt");

                    Console.Write(" Ingresa el nombre del evento que quieres borrar: ");
                    parametro = Console.ReadLine();

                    while ((cadena = lector.ReadLine()) != null)
                    {
                        campos = cadena.Split(',');

                        if (campos[0].Trim().Equals(parametro))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Nombre: " + campos[0].Trim());
                            Console.WriteLine(" Fecha: " + campos[1].Trim());
                            Console.WriteLine(" Hora: " + campos[2].Trim());
                            Console.WriteLine(" Lugar: " + campos[3].Trim());
                            encontrado = true;
                        }

                        else
                        {
                            temporal2.WriteLine(cadena);
                        }
                    }

                    if (encontrado == false)
                    {
                        Console.Write(" El evento con el nombre ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(parametro);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" no existe");
                        Console.Write(" ¿Deseas buscar otro evento? (escribe 's' para continuar o cualquier para salir): ");

                        if ((parametro = Console.ReadLine().ToLower()) == "s")
                        {
                            temporal2.Close();
                            Console.Clear();
                            goto inicioNombreBorrar;
                        }

                        else
                        {
                            goto inicioMenuBorrar;
                        }
                    }

                    encontrado = false;
                    Console.Write(" ¿Estas seguro de que deseas borrar este evento? (escribe 's' para continuar o cualquier para salir): ");

                    if ((parametro = Console.ReadLine().ToLower()) == "s")
                    {
                        temporal2.Close();
                        lector.Close();

                        File.Delete("eventos.txt");
                        File.Move("temporal2.txt", "eventos.txt");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" El evento se ha eliminado satisfactoriamente. ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" ¿Deseas buscar otro evento? (escribe 's' para continuar o cualquier para salir): ");

                        if ((parametro = Console.ReadLine().ToLower()) == "s")
                        {
                            temporal2.Close();
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
                    Console.Write(" ¿Estas seguro de que deseas eliminar todos los eventos? (escribe 's' para continuar o cualquier para salir): ");
                    if ((parametro = Console.ReadLine().ToLower()) == "s")
                    {                      
                        File.Delete("eventos.txt");
                        StreamWriter crear = new StreamWriter("eventos.txt");
                        crear.Close();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Has eliminado todos los eventos!");
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
                    Console.WriteLine(" Esta opción no esta disponible");
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
            Console.WriteLine(@"                                                                         ███████╗██╗   ██╗███████╗███╗   ██╗████████╗ ██████╗ ███████╗
                                                                         ██╔════╝██║   ██║██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔════╝
                                                                         █████╗  ██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║███████╗
                                                                         ██╔══╝  ╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║╚════██║
                                                                         ███████╗ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝███████║
");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                                                 
                                                                                                 ██          ██                               
                                                                                              ████████████████████                            
                                                                                            ████████████████████████                          
                                                                                            ██   ██          ██   ██                          
                                                                                           ██                      ██                         
                                                                                           ██                      ██                         
                                                                                           ██████████████████████████                         
                                                                                           ██                      ██                         
                                                                                           ██                      ██                         
                                                                                           ██ ██ ██ ██ ██ ██ ██ ██ ██                         
                                                                                           ██                      ██                         
                                                                                           ██                      ██                         
                                                                                           ██ ██ ██ ██ ██ ██ ██ ██ ██                         
                                                                                           ██                      ██                         
                                                                                            ██                    ██                          
                                                                                            ████████████████████████                          
                                                                                              ████████████████████      
");
            Console.WriteLine("                                                                                          [1] Ver todos los eventos");
            Console.WriteLine("                                                                                          [2] Buscar evento");
            Console.WriteLine("                                                                                          [3] Crear evento");
            Console.WriteLine("                                                                                          [4] Editar evento");
            Console.WriteLine("                                                                                          [5] Borrar evento");
            Console.WriteLine("                                                                                          [6] Volver al menu principal");
            Console.WriteLine("");
            Console.Write("                                                                                          Escoge una opción: ");
            string opcion = (Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    verEventos();
                    break;
                    ;
                case "2":
                    buscarEventos();
                    break;
                    ;
                case "3":
                    crearEventos();
                    break;
                    ;
                case "4":
                    editarEventos();
                    break;
                    ;
                case "5":
                    borrarEventos();
                    break;
                    ;
                    case "6":
                    Console.Clear();
                    AgendaElectronica.AgendaElectronica.Main();
                    break;
                    ;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Esta opción no esta disponible");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto inicio;
                    ;
            }

            Console.ReadKey();
        }
        public class Eventos
        {
            public int numeroEvento { get; set; }
            public string nombreEvento { get; set; }
            public string fechaEvento { get; set; }
            public string horaEvento { get; set; }
            public string lugarEvento { get; set; }
        }
    }
}