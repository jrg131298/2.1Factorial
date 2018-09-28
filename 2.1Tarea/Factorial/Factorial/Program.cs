using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Factorial
{
    class Menu
    {
        static void Main(string[] args)
        {
            int Numero;
            int Opcion;
            bool Salir = false, ProcesoRealizado = false;
            do
            {
                try
                {
                    do
                    {
                        do
                        {
                            Console.Clear();
                            Stopwatch sw = new Stopwatch();
                            Console.WriteLine("FACTORIAL");
                            Console.WriteLine("Ingresa un numero entero para realizar factorial: ");
                            Numero = Convert.ToInt16(Console.ReadLine());
                            Calculo c = new Calculo();
                            Console.WriteLine("Ingresa el numero de la opcion que desee:");
                            Console.WriteLine("1. Factorial utilizando for");
                            Console.WriteLine("2. Factorial utilizando recursividad");
                            Opcion = Convert.ToInt16(Console.ReadLine());
                            if (Opcion == 1)
                            {
                                sw.Start();
                                c.UtilizaFor(Numero);
                                Console.WriteLine("Tiempo: {0}", sw.Elapsed.ToString());
                                Console.WriteLine("Presiona una tecla para continuar.");
                                Console.ReadKey();
                                sw.Stop();
                                ProcesoRealizado = true;
                            }
                            else if (Opcion == 2)
                            {
                                sw.Start();
                                Console.WriteLine("{0}! = {1}.", Numero, c.UtilizaRecursividad(Numero));
                                Console.WriteLine("Tiempo: {0}", sw.Elapsed.ToString());
                                sw.Stop();
                                Console.WriteLine("Presiona una tecla para continuar.");
                                Console.ReadKey();
                                ProcesoRealizado = true;
                            }
                            else
                            {
                                ProcesoRealizado = false;
                            }
                        } while (ProcesoRealizado == false);

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ingresa el numero de la opcion que desee:");
                            Console.WriteLine("1. Regresar a menu");
                            Console.WriteLine("2. Salir");
                            Opcion = Convert.ToInt16(Console.ReadLine());
                            if (Opcion == 1)
                            {
                                ProcesoRealizado = true;
                                Salir = false;
                            }
                            else if (Opcion == 2)
                            {
                                ProcesoRealizado = true;
                                Salir = true;
                            }
                            else
                            {
                                ProcesoRealizado = false;
                                Console.WriteLine("Ingresaste un valor incorrecto.");
                            }
                        } while (ProcesoRealizado == false);
                    } while (Salir == false);
                }
                catch
                {
                    Console.WriteLine("Ingresaste un valor erroneo.\nPresiona una tecla para continuar.");
                    Console.ReadKey();
                    Salir = false;
                }
                finally
                { }
            } while (Salir == false);
        }
    }

    public class Calculo
    {
        private long Resultado;
        public void UtilizaFor(int Numero)
        {
            Resultado = 1;
            for(int Contador = 1; Contador <= Numero; Contador++)
            {
                Resultado = Resultado * Contador;
            }
            Console.WriteLine("{0}! = {1}.", Numero, Resultado);
        }
        public int UtilizaRecursividad(int Numero)
        {
            if(Numero == 0)
            {
                return 1;
            }
            else
            {
                return (Numero * UtilizaRecursividad(Numero - 1));
            }
        }
    }
}
