
using System;
using ModulosUtilitariosApp;
using AgendaElectronica;

namespace ConversorDivisasApp
{

public class ConversorDivisas
{
    
    public static void MenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("");
        Console.WriteLine(@"                                         
                                                                            
                                                                              ██████╗ ██████╗ ███╗   ██╗██╗   ██╗███████╗██████╗ ███████╗ ██████╗ ██████╗ 
                                                                             ██╔════╝██╔═══██╗████╗  ██║██║   ██║██╔════╝██╔══██╗██╔════╝██╔═══██╗██╔══██╗
                                                                             ██║     ██║   ██║██╔██╗ ██║██║   ██║█████╗  ██████╔╝███████╗██║   ██║██████╔╝
                                                                             ██║     ██║   ██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██╔══██╗╚════██║██║   ██║██╔══██╗
                                                                             ╚██████╗╚██████╔╝██║ ╚████║ ╚████╔╝ ███████╗██║  ██║███████║╚██████╔╝██║  ██║
                                                                              ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝                                                                             
                                                                                            ██████╗ ██╗██╗   ██╗██╗███████╗ █████╗ ███████╗
                                                                                            ██╔══██╗██║██║   ██║██║██╔════╝██╔══██╗██╔════╝
                                                                                            ██║  ██║██║██║   ██║██║███████╗███████║███████╗
                                                                                            ██║  ██║██║╚██╗ ██╔╝██║╚════██║██╔══██║╚════██║
                                                                                            ██████╔╝██║ ╚████╔╝ ██║███████║██║  ██║███████║
                                                                                            ╚═════╝ ╚═╝  ╚═══╝  ╚═╝╚══════╝╚═╝  ╚═╝╚══════╝");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(@"
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                                    [1]. Convertir dolares a pesos
                                                                                                    [2]. Convertir pesos a dolares
                                                                                                    [3]. Convertir dolares a euros
                                                                                                    [4]. Convertir euros a dolares
                                                                                                    [5]. Convertir pesos a euros
                                                                                                    [6]. Convertir euros a pesos
                                                                                                    [7]. Volver al menu anterior
                                                                                                    [8]. Volver al menu Principal
                                                                                                                                    ");
        Console.WriteLine("");
        Console.Write("                                                                                                    Ingrese la opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("");
        while (opcion != 0 )
        {
            switch(opcion)
            { 
                case 1:
                    DolarPesoDom();                    
                    break;
                case 2:
                    PesoDomDolar();
                    break;
                case 3:
                    DolarEuro();
                    break;
                case 4:
                    EuroDolar();
                    break;
                case 5:
                    PesoDomEuro();
                    break;
                case 6:
                    EuroPesoDom();
                    break;
                case 7: 
                    Console.Clear();
                    Utilidades.MenuPrincipal();
                    break;
                case 8: 
                    AgendaElectronica.AgendaElectronica.Main();
                    break;
                default:
                    Console.WriteLine("Opcion no valida, intente de nuevo");
                    MenuPrincipal();
                    break;

            }
        }
    
        static void DolarPesoDom()
        {
            Console.Clear();
            double dolar = 00.00;
            double peso = 53.95;
            double conversion = 00.00;
            string moneda = "RD$";
            Console.WriteLine("Ingrese la cantidad de dolares que desea convertir");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Cantidad de US$: ");
            dolar = Math.Round(double.Parse(Console.ReadLine()));
            conversion = dolar * peso;
            Console.WriteLine("");
            Console.WriteLine("US$" + dolar +" Dolares en Pesos Dominicanos son: [" + moneda + Math.Round(conversion,2) +"]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write(TasaConversion);
            Console.WriteLine("[ US$1.00 = RD$" + peso +" ]" );
            Console.WriteLine("");
            OpcionesInternas();
        }

        static void PesoDomDolar()
        {
            Console.Clear();
            double peso = 00.00;
            double dolar = 0.0185;
            double conversion = 00.00;
            string moneda = "US$";
            Console.WriteLine("Ingrese la cantidad de Pesos que desea convertir");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Cantidad de RD$: ");
            peso = Math.Round(double.Parse(Console.ReadLine()));
            conversion = dolar * peso;
            Console.WriteLine("");
            Console.WriteLine("RD$" + peso +" Pesos Dominicanos en Dolares son: [" + moneda + Math.Round(conversion,2) +"]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write(TasaConversion);
            Console.WriteLine("[ RD$1.00 = US$" + dolar +" ]" );
            Console.WriteLine("");
            OpcionesInternas();
        }

        static void DolarEuro()
        {
            Console.Clear();
            double dolar = 00.00;
            double euro = 0.9834;
            double conversion = 00.00;
            string moneda = "EUR$";
            Console.WriteLine("Ingrese la cantidad de dolares que desea convertir");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Cantidad de US$: ");
            dolar = Math.Round(double.Parse(Console.ReadLine()));
            Console.WriteLine("");
            conversion = dolar * euro;
            Console.WriteLine("");
            Console.WriteLine("US$" + dolar +" Dolares en Euros son: [" + moneda + Math.Round(conversion,2) +"]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write(TasaConversion);
            Console.WriteLine("[ US$1.00 = EUR$" + euro +" ]" );
            Console.WriteLine("");
            OpcionesInternas();
        }

        static void EuroDolar()
        {
            Console.Clear();
            double euro = 00.00;
            double dolar = 1.02;
            double conversion = 00.00;
            string moneda = "US$";
            Console.WriteLine("Ingrese la cantidad de euros que desea convertir");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Cantidad de EUR$: ");
            euro = Math.Round(double.Parse(Console.ReadLine()));
            conversion = euro * dolar;
            Console.WriteLine("");
            Console.WriteLine("EUR$" + euro +" Euros en Dolares son: [" + moneda + Math.Round(conversion,2) +"]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write(TasaConversion);
            Console.WriteLine("[ EUR$1.00 = US$" + dolar +" ]" );
            Console.WriteLine("");
            OpcionesInternas();

        }
        static void PesoDomEuro()
        {
            Console.Clear();
            double peso = 00.00;
            double euro = 0.0183;
            double conversion = 00.00;
            string moneda = "EUR$";
            Console.WriteLine("Ingrese la cantidad de pesos que desea convertir");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Cantidad de RD$: ");
            peso = Math.Round(double.Parse(Console.ReadLine()));
            conversion = peso * euro;
            Console.WriteLine("");
            Console.WriteLine("RD$" + peso +" Pesos Dominicanos en euros son: [" + moneda + Math.Round(conversion,2) +"]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write(TasaConversion);
            Console.WriteLine("[ RD$1.00 = EUR$" + euro +" ]" );
            Console.WriteLine("");
            OpcionesInternas();
        }
        static void EuroPesoDom()
        {
            Console.Clear();
            double euro = 00.00;
            double peso = 54.8574;
            double conversion = 00.00;
            string moneda = "RD$";
            Console.WriteLine("Ingrese la cantidad de euros que desea convertir");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Cantidad de EUR$: ");
            euro = Math.Round(double.Parse(Console.ReadLine()));
            conversion = euro * peso;
            Console.WriteLine("");
            Console.WriteLine("EUR$" + euro +" Euros en Pesos Dominicanos son: [" + moneda + Math.Round(conversion,2) +"]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.Write(TasaConversion);
            Console.WriteLine("[ EUR$1.00 =  RD$" + peso +" ]" );
            Console.WriteLine("");
            OpcionesInternas();
        }
        
        static void OpcionesInternas()
        {
            Console.WriteLine("Que desea hacer ahora?");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Realizar otra conversion");
            Console.WriteLine("2. Volver al menu");
            Console.WriteLine("");
            string  opcionesinternas = Console.ReadLine();
            if (opcionesinternas == "1")
            {
                MenuPrincipal();
            }
            else if (opcionesinternas == "2")
            {
               MenuPrincipal();
            }
            else
            {
                Console.WriteLine("Opcion no valida, intente de nuevo");
                OpcionesInternas();
            }
        }
      } 
      static string TasaConversion = "Tasa de Conversion: ";
   } 
}