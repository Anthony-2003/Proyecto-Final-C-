///Menu principal Agenda Electronica hoila
using AgendaEventosApp;
using ModulosUtilitariosApp;
using AgendaContactosApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AgendaElectronica
{
    public class AgendaElectronica
    {
        public static void Main()
        {
            CopyRight();
            Thread.Sleep(800);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                                                                                             █████╗  ██████╗ ███████╗███╗   ██╗██████╗  █████╗    
                                                                                            ██╔══██╗██╔════╝ ██╔════╝████╗  ██║██╔══██╗██╔══██╗ TM 
                                                                                            ███████║██║  ███╗█████╗  ██╔██╗ ██║██║  ██║███████║
                                                                                            ██╔══██║██║   ██║██╔══╝  ██║╚██╗██║██║  ██║██╔══██║
                                                                                            ██║  ██║╚██████╔╝███████╗██║ ╚████║██████╔╝██║  ██║
                                                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚═╝  ╚═╝
                                                                                                                                                                                                                                 
                                                                          ███████╗██╗     ███████╗ ██████╗████████╗██████╗  ██████╗ ███╗   ██╗██╗ ██████╗ █████╗ 
                                                                          ██╔════╝██║     ██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗████╗  ██║██║██╔════╝██╔══██╗
                                                                          █████╗  ██║     █████╗  ██║        ██║   ██████╔╝██║   ██║██╔██╗ ██║██║██║     ███████║
                                                                          ██╔══╝  ██║     ██╔══╝  ██║        ██║   ██╔══██╗██║   ██║██║╚██╗██║██║██║     ██╔══██║
                                                                          ███████╗███████╗███████╗╚██████╗   ██║   ██║  ██║╚██████╔╝██║ ╚████║██║╚██████╗██║  ██║
                                                                          ╚══════╝╚══════╝╚══════╝ ╚═════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝ ╚═════╝╚═╝  ╚═╝");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              [1] Contactos
                                                                                                              [2] Eventos
                                                                                                              [3] Modulos Utilitarios
                                                                                                              [4] About us
                                                                                                              [5] Salir");
            Console.WriteLine("");
            Console.WriteLine("");  
            Console.WriteLine("");  
            Console.WriteLine("");                                                                                                    
            Console.Write("                                                                                                              Escoge una opción: "); string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    ClaseContactos.MenuPrincipal();
                    break;

                case "2":
                    Console.Clear();
                     ClaseEventos.MenuPrincipal();
                    break;

                case "3":
                    Console.Clear();
                    Utilidades.MenuPrincipal();
                    break;

                case "4":
                    CopyRight();
                    Console.ReadKey();
                    Main();
                    break;

                case "5":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                                                    Gracias por utilizar Nuestra aplicacion...");
                    Console.WriteLine("");
                    Environment.Exit(0);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La opción no esta disponible");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main();
                    break;
            }
        }

        static void CopyRight()
        {
            Console.Clear();
                   Console.ForegroundColor = ConsoleColor.Cyan;
                   Console.WriteLine(@"
                                                                                             █████╗  ██████╗ ███████╗███╗   ██╗██████╗  █████╗    
                                                                                            ██╔══██╗██╔════╝ ██╔════╝████╗  ██║██╔══██╗██╔══██╗ TM
                                                                                            ███████║██║  ███╗█████╗  ██╔██╗ ██║██║  ██║███████║
                                                                                            ██╔══██║██║   ██║██╔══╝  ██║╚██╗██║██║  ██║██╔══██║
                                                                                            ██║  ██║╚██████╔╝███████╗██║ ╚████║██████╔╝██║  ██║
                                                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚═╝  ╚═╝
                                                                                                                                                                                                                                 
                                                                          ███████╗██╗     ███████╗ ██████╗████████╗██████╗  ██████╗ ███╗   ██╗██╗ ██████╗ █████╗ 
                                                                          ██╔════╝██║     ██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗████╗  ██║██║██╔════╝██╔══██╗
                                                                          █████╗  ██║     █████╗  ██║        ██║   ██████╔╝██║   ██║██╔██╗ ██║██║██║     ███████║
                                                                          ██╔══╝  ██║     ██╔══╝  ██║        ██║   ██╔══██╗██║   ██║██║╚██╗██║██║██║     ██╔══██║
                                                                          ███████╗███████╗███████╗╚██████╗   ██║   ██║  ██║╚██████╔╝██║ ╚████║██║╚██████╗██║  ██║
                                                                          ╚══════╝╚══════╝╚══════╝ ╚═════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝ ╚═════╝╚═╝  ╚═╝");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(@"
                                                                                                               Version: 2.0.10
                                                                                                         Developer Version: 3.0.10
                                                                        *******************************************************************************************
                                                                                                            
                                                                                                              Crafted with ♥ By:
                                                                                               Juan D. Victorino | Anthony Volquez | Roberto Isaac
                                                                        *******************************************************************************************                                    
                                                                                                     Copyright (c) 2022. All rights reserved");
        }
    }
}





