using System;
using ConversorDivisasApp;
using ConversorTemperaturasApp;
using AgendaElectronica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
 
namespace ModulosUtilitariosApp
{
    class Utilidades
    {
        public static void MenuPrincipal()
        {     
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@"
                                                                              ██╗   ██╗████████╗██╗██╗     ██╗██████╗  █████╗ ██████╗ ███████╗███████╗
                                                                              ██║   ██║╚══██╔══╝██║██║     ██║██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
                                                                              ██║   ██║   ██║   ██║██║     ██║██║  ██║███████║██║  ██║█████╗  ███████╗
                                                                              ██║   ██║   ██║   ██║██║     ██║██║  ██║██╔══██║██║  ██║██╔══╝  ╚════██║
                                                                              ╚██████╔╝   ██║   ██║███████╗██║██████╔╝██║  ██║██████╔╝███████╗███████║
                                                                               ╚═════╝    ╚═╝   ╚═╝╚══════╝╚═╝╚═════╝ ╚═╝  ╚═╝╚═════╝ ╚══════╝╚══════╝"); 
        
                                                                            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                                                                                                                                                       
                                                                                     
                                                                                     
                                                                                     
                                                                                     
                                                                                        |-----------------------------------------------------|
                                                                                        |Ingrese el numero de la operacion que desea realizar |
                                                                                        |            [1] - Sumar                              |
                                                                                        |            [2] - Restar                             |
                                                                                        |            [3] - Multiplicar                        |
                                                                                        |            [4] - Dividir                            |
                                                                                        |            [5] - Conversor de Divisas               |
                                                                                        |            [6] - Conversor de Temperaturas          |
                                                                                        |            [7] - Volver al Menu Principal           |
                                                                                        |-----------------------------------------------------| ");    
 
              Console.Write(@"                                                        
                                                                                                    Elija una Opcion: "); int operacion = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Calcular(operacion);
        }
 
        private static void Calcular(int operacion)
        {
            double numero1;
            double numero2;
            double resultado;
            string respuesta = "";
            bool llave = true;
 
            if (operacion == 1 || operacion == 2 || operacion == 3 || operacion == 4 || operacion == 5 || operacion == 6 || operacion == 7)
            {
                Console.Clear();
                if (operacion == 1)
                {
                    Console.WriteLine("SUMAR");
                }
                else if (operacion == 2)
                {
                    Console.WriteLine("RESTAR");
                }
                else if (operacion == 3)
                {
                    Console.WriteLine("MULTIPLICAR");
                }
                else if (operacion == 4)
                {
                    Console.WriteLine("DIVIDIR");
                }
               else if (operacion == 5)
                {
                    Console.Clear();
                    ConversorDivisas.MenuPrincipal();
                }
                else if (operacion == 6)
                {
                    Console.Clear();
                    ConversorTemperaturas.MenuPrincipal();
                }
                else if (operacion == 7)
                {
                    AgendaElectronica.AgendaElectronica.Main();
                }
                Console.WriteLine("");
                Console.Write("Ingrese el primer numero: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("--------------------------");
                Console.WriteLine("");
                Console.Write("Ingrese el segundo numero: ");
                numero2 = double.Parse(Console.ReadLine());
                Console.Write("--------------------------");
                Console.WriteLine("");

                
                if (operacion == 1)
                {

                    resultado = numero1 + numero2;
                    Console.WriteLine("");
                    Console.WriteLine("Resultado {0} + {1} = {2} ", numero1, numero2, resultado);
                    Console.WriteLine("");

                    while (llave == true)
                    { 
                    Console.WriteLine("Deseas realizar otra operacion");
                    Console.WriteLine("");
                    Console.WriteLine("[1] Realizar otra operacion");
                    Console.WriteLine("[2] Volver al Menu Pricipal");
                    Console.WriteLine("");
                    Console.Write("Ingrese una opcion:");
                    respuesta = Console.ReadLine();
                    if (respuesta == "1")
                    {
                    Console.Clear();
                    MenuPrincipal();
                     }
                    else if (respuesta == "2")
                    {
                    
                    AgendaElectronica.AgendaElectronica.Main();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("Esta opcion no es valida, intente otra opcion.");
                        Console.WriteLine("");
                        Console.ReadKey();
                        llave = true;
                    }
                    }
                }
                else if (operacion == 2)
                {
                    resultado = numero1 - numero2;
                    Console.WriteLine("");
                    Console.WriteLine("Resultado {0} - {1} = {2} ", numero1, numero2, resultado);
                    Console.WriteLine("");
                    
                    while (llave == true)
                    { 
                    Console.WriteLine("Deseas realizar otra operacion");
                    Console.WriteLine("");
                    Console.WriteLine("[1] Realizar otra operacion");
                    Console.WriteLine("[2] Volver al Menu Pricipal");
                    Console.WriteLine("");
                    Console.Write("Ingrese una opcion:");
                    respuesta = Console.ReadLine();
                    if (respuesta == "1")
                    {
                    Console.Clear();
                    MenuPrincipal();
                     }
                    else if (respuesta == "2")
                    {
                    
                    AgendaElectronica.AgendaElectronica.Main();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("Esta opcion no es valida, intente otra opcion.");
                        Console.WriteLine("");
                        Console.ReadKey();
                        llave = true;
                    }
                    }
                }
                else if (operacion == 3)
                {
                    resultado = numero1 * numero2;
                    Console.WriteLine("");
                    Console.WriteLine("Resultado {0} x {1} = {2} ", numero1, numero2, resultado);
                    Console.WriteLine("");

                    while (llave == true)
                    { 
                    Console.WriteLine("Deseas realizar otra operacion");
                    Console.WriteLine("");
                    Console.WriteLine("[1] Realizar otra operacion");
                    Console.WriteLine("[2] Volver al Menu Pricipal");
                    Console.WriteLine("");
                    Console.Write("Ingrese una opcion:");
                    respuesta = Console.ReadLine();
                    if (respuesta == "1")
                    {
                    Console.Clear();
                    MenuPrincipal();
                     }
                    else if (respuesta == "2")
                    {
                    
                    AgendaElectronica.AgendaElectronica.Main();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("Esta opcion no es valida, intente otra opcion.");
                        Console.WriteLine("");
                        Console.ReadKey();
                        llave = true;
                    }
                    }
                }
                else if (operacion == 4)
                {
                    
                    if (numero2 != 0)
                    {
                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado {0} / {1} = {2}", numero1, numero2, resultado);
                    Console.WriteLine("");

                    while (llave == true)
                    { 
                    Console.WriteLine("Deseas realizar otra operacion");
                    Console.WriteLine("");
                    Console.WriteLine("[1] Realizar otra operacion");
                    Console.WriteLine("[2] Volver al Menu Pricipal");
                    Console.WriteLine("");
                    Console.Write("Ingrese una opcion:");
                    respuesta = Console.ReadLine();
                    if (respuesta == "1")
                    {
                    Console.Clear();
                    MenuPrincipal();
                     }
                    else if (respuesta == "2")
                    {
                    
                    AgendaElectronica.AgendaElectronica.Main();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("Esta opcion no es valida, intente otra opcion.");
                        Console.ReadKey();
                        llave = true;
                    }
                    }
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre {0} ", numero2);

                    }
                }
            }
            else
            {
                Console.WriteLine("No se ha seleccionado ningua de las operaciones probables");
                Console.ReadKey();
                MenuPrincipal();
                
            }
            
        }
    }
}