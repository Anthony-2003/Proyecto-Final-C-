using System;
using ModulosUtilitariosApp;
using AgendaElectronica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConversorTemperaturasApp
{
    class ConversorTemperaturas
    {
        static double temperatura = 0;
        static int opcion = 0;
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine(@"
                                                                                       ██████╗ ██████╗ ███╗   ██╗██╗   ██╗███████╗██████╗ ███████╗ ██████╗ ██████╗ 
                                                                                      ██╔════╝██╔═══██╗████╗  ██║██║   ██║██╔════╝██╔══██╗██╔════╝██╔═══██╗██╔══██╗
                                                                                      ██║     ██║   ██║██╔██╗ ██║██║   ██║█████╗  ██████╔╝███████╗██║   ██║██████╔╝
                                                                                      ██║     ██║   ██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██╔══██╗╚════██║██║   ██║██╔══██╗
                                                                                      ╚██████╗╚██████╔╝██║ ╚████║ ╚████╔╝ ███████╗██║  ██║███████║╚██████╔╝██║  ██║
                                                                                       ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝
                                                                        ████████╗███████╗███╗   ███╗██████╗ ███████╗██████╗  █████╗ ████████╗██╗   ██╗██████╗  █████╗ ███████╗
                                                                        ╚══██╔══╝██╔════╝████╗ ████║██╔══██╗██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██║   ██║██╔══██╗██╔══██╗██╔════╝
                                                                           ██║   █████╗  ██╔████╔██║██████╔╝█████╗  ██████╔╝███████║   ██║   ██║   ██║██████╔╝███████║███████╗
                                                                           ██║   ██╔══╝  ██║╚██╔╝██║██╔═══╝ ██╔══╝  ██╔══██╗██╔══██║   ██║   ██║   ██║██╔══██╗██╔══██║╚════██║
                                                                           ██║   ███████╗██║ ╚═╝ ██║██║     ███████╗██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║██║  ██║███████║
                                                                           ╚═╝   ╚══════╝╚═╝     ╚═╝╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                                                                                                    Indique los Grados (º) a Convertir: ");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine("                                                                                                    ------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"
                                                                                                            Selecciona la conversion a realizar:
                                                                                                            ------------------------------------
                                                                                                            [1]. Fahrenheit a Celsius
                                                                                                            [2]. Celsius a Fahrenheit
                                                                                                            [3]. Fahrenheit a Kelvin
                                                                                                            [4]. Kelvin a Fahrenheit
                                                                                                            [5]. Celsius a Kelvin
                                                                                                            [6]. Kelvin a Celsius
                                                                                                            [7]. Volver al Menu anterior");
            Console.WriteLine(" ");     
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("                                                                                                         Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            while (opcion < 8)
            {
                switch (opcion)
                {
                    case 1:
                            FahrenheitCelsius();
                        break;
                    case 2:
                            CelsiusFahrenheit();
                        break;
                    case 3:
                            FahrenheitKelvin();
                        break;
                    case 4:
                            KelvinFahrenheit();
                        break;
                    case 5:
                            CelsiusKelvin();
                        break;
                    case 6:
                            KelvinCelsius();
                        break;

                    case 7:
                            Console.Clear();
                            Utilidades.MenuPrincipal();
                        break;

                    default:
                            Console.WriteLine("Esta opcion no es valida, intente de nuevo");
                            Console.Clear();
                            MenuPrincipal();
                        break;

                }
            }

                            Console.WriteLine("Esta opcion no es valida, intente de nuevo");
                            Console.Clear();
                            MenuPrincipal();
        }

            static void FahrenheitCelsius()
            {
                 //Para convertir de ºF a ºC use la fórmula:   ºC = (ºF-32) ÷ 1.8.
                Console.Clear();  
                double Resultado = (temperatura - 32) / 1.8;
                Console.WriteLine("Resultado de la Conversion");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("["+temperatura+ " ºF] = ["+Math.Round(Resultado,2)+" ºC]");
                Console.WriteLine("------------------------------------");

                
                OpcionesAdicionales();
                

            }   
            static void CelsiusFahrenheit()
            {
                
                //Para convertir de ºC a ºF use la fórmula: ºF = ºC x 1.8 + 32.
                Console.Clear();  
                double Resultado = temperatura * 1.8 + 32;
                Console.WriteLine("Resultado de la Conversion");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("["+temperatura+ " ºC] = ["+Math.Round(Resultado,2)+" ºF]");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");

                OpcionesAdicionales();
            }
            static void FahrenheitKelvin()
            {
                //Para convertir de ºF a K use la fórmula: K = 5/9 (ºF – 32) + 273.15.
                Console.Clear();  
                double Resultado = 5/9 * (temperatura - 32) + 273.15;
                Console.WriteLine("Resultado de la Conversion");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("["+temperatura+ " ºF] = ["+Math.Round(Resultado,2)+" ºK]");
                Console.WriteLine("------------------------------------");

                
                OpcionesAdicionales();
            }
            static void KelvinFahrenheit()
            {
                 //Para convertir de K a ºF use la fórmula:   ºF = 1.8(K – 273.15) + 32
                 Console.Clear();  
                double Resultado = 1.8 * (temperatura - 273.15) + 32;
                Console.WriteLine("Resultado de la Conversion");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("["+temperatura+ " ºK] = ["+Math.Round(Resultado,2)+" ºF]");
                Console.WriteLine("------------------------------------");

                
                OpcionesAdicionales();
            }
            static void KelvinCelsius()
            {
                //Para convertir de K a ºC use la fórmula:   ºC = K – 273.15
                Console.Clear();  
                double Resultado = temperatura - 273.15;
                Console.WriteLine("Resultado de la Conversion");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("["+temperatura+ " ºK] = ["+Math.Round(Resultado,2)+" ºC]");
                Console.WriteLine("------------------------------------");

                
                OpcionesAdicionales();
            }
            static void CelsiusKelvin()
            {
                //Para convertir de ºC a K use la fórmula: K = ºC + 273.15.
                Console.Clear();  
                double Resultado = temperatura + 273.15;
                Console.WriteLine("Resultado de la Conversion");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("["+temperatura+ " ºC] = ["+Math.Round(Resultado,2)+" ºK]");
                Console.WriteLine("------------------------------------");

                OpcionesAdicionales();
            }
            static void OpcionesAdicionales()
            {
                Console.WriteLine("Que desea hacer ahora?");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("[1] Convertir a otra Temperatura");
                Console.WriteLine("[2] Volver al Menu Anterior");
                Console.WriteLine("[3] Volver al Menu Principal");
                int opcionesadicionales = int.Parse(Console.ReadLine());
                if (opcionesadicionales == 1)
                {
                    MenuOpciones();

                }
                else if (opcionesadicionales == 2)
                {
                    MenuPrincipal();
                }
                else if (opcionesadicionales == 3)
                {
                    AgendaElectronica.AgendaElectronica.Main();
                }
                else
                {
                    Console.WriteLine("Parece que no ha elegido una opcion valida, intente de nuevo");
                    Console.WriteLine("");
                    OpcionesAdicionales();
                }
                
            }

            static void MenuOpciones()
            {
                Console.WriteLine(@"
    Selecciona la conversion a realizar:
    ------------------------------------
    [1]. Fahrenheit a Celsius
    [2]. Celsius a Fahrenheit
    [3]. Fahrenheit a Kelvin
    [4]. Kelvin a Fahrenheit
    [5]. Celsius a Kelvin
    [6]. Kelvin a Celsius
    [7]. Volver al Menu anterior");
    
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write(" Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            while (opcion < 8)
            {
                switch (opcion)
                {
                    case 1:
                            FahrenheitCelsius();
                        break;
                    case 2:
                            CelsiusFahrenheit();
                        break;
                    case 3:
                            FahrenheitKelvin();
                        break;
                    case 4:
                            KelvinFahrenheit();
                        break;
                    case 5:
                            CelsiusKelvin();
                        break;
                    case 6:
                            KelvinCelsius();
                        break;

                    case 7:
                            Console.Clear();
                            Utilidades.MenuPrincipal();
                        break;

                    default:
                            Console.WriteLine("Esta opcion no es valida, intente de nuevo");
                            Console.Clear();
                            MenuPrincipal();
                        break;

                }
            }
            }
    }
}