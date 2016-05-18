using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static int seleccion = 0;
        static int option = 0;
        static double precio = 0;

        static void Offers()
        {
            Console.Clear();
            Console.WriteLine("Seleccione uno..");
            Console.WriteLine("1.Pantalla LED 40'\n2.Equipo de Sonido 5000wts\n3.Teatro en Casa");
            seleccion = int.Parse(Console.ReadLine());
            if (seleccion == 1)
            {
                Console.WriteLine("¢325,000.00");
                Console.WriteLine("¢410,000.00");
            }

            if (seleccion == 2)
            {
                Console.WriteLine("¢125,000.00");
                Console.WriteLine("¢210,000.00");
            }

            if (seleccion == 3)
            {
                Console.WriteLine("¢200,000.00");
                Console.WriteLine("¢390,000.00");
            }
            //Agregar más ofertas
            Console.ReadKey();
        }
        //Sobrecarga oferta individual


        static int Main() //void
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Almacén Gutierrez");
                Console.WriteLine("1. Evaluar otros comercios.");
                Console.WriteLine("2. Ver clasificación de artículos.");
                Console.WriteLine("3. Ver Ofertas.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        //Salir
                        break;
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione uno..");
                            Console.WriteLine("1.Pantalla LED 40'\n2.Equipo de Sonido 5000wts\n3.Teatro en Casa");
                            seleccion = int.Parse(Console.ReadLine());
                            Console.Write("Digite el precio visto:");
                            precio = int.Parse(Console.ReadLine());
                            if (seleccion == 1 && precio < 300000)
                            {

                                Console.WriteLine("Precio muy barato pero se lo podemos mejorar");
                            }

                            if (seleccion == 1 && precio > 300000 && precio < 600000)
                            {

                                Console.WriteLine("Precio barato recomendable");
                            }

                            if (seleccion == 1 && precio == 600000)
                            {

                                Console.WriteLine("Precio normal decente");
                            }

                            if (seleccion == 1 && precio > 600000 && precio < 900000)
                            {

                                Console.WriteLine("Precio caro");
                            }

                            if (seleccion == 1 && precio > 900000)
                            {
                        
                                Console.WriteLine("Precio muy caro");
                            }

                            
                            if (seleccion == 2 && precio < 200000) {

                                Console.WriteLine("Precio muy barato");                            

                            }

                            if (seleccion == 2 && precio > 200000 && precio < 600000)
                            {

                                Console.WriteLine("Precio barato se puede mejorar");

                            }

                            if (seleccion == 2 && precio == 600000)
                            {

                                Console.WriteLine("Precio normal");

                            }

                            if (seleccion == 2 && precio > 600000)
                            {

                                Console.WriteLine("Precio muy caro");

                            }

                            if (seleccion == 3 && precio < 100000)
                            {

                                Console.WriteLine("Precio muy barato");

                            }

                            if (seleccion == 3 && precio > 100000 && precio < 300000)
                            {

                                Console.WriteLine("Precio barato se puede mejorar");

                            }

                            if (seleccion == 3 && precio == 300000)
                            {

                                Console.WriteLine("Precio normal");

                            }

                            if (seleccion == 3 && precio > 300000)
                            {

                                Console.WriteLine("Precio muy caro");

                            }

                            Console.ReadKey();
                            
                            /* Rangos Pantalla
                             * <300000 muy barato
                             * >300000 y <600000 barato
                             * =600000 normal
                             * >600000 y <900000 caro
                             * >900000 muy caro*/
                            /* Rangos Equipos de Sonido
                             * 200000 y 600000
                             * Rangos Teatro en casa
                             * 100000 y 300000*/
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("1.Pantalla TV LED 40'\n2.Equipo de Sonido 5000wts\n3.Teatro en Casa\n4.Radiograbadora\n5.Minicomponente\n6.Reproductor BluRay\n7.Pantalla LCD PC\n8.Consola de mesa\n9.Consola portátil\n10.Camará fotográfica\n11.Camará fotográfica");
                            seleccion = int.Parse(Console.ReadLine());
                         
                            if (seleccion == 3 || seleccion == 6)
                              
                            {
                                Console.WriteLine("Video");
                            }
                            if (seleccion == 2 || seleccion == 4 || seleccion == 5)
                            {
                                Console.WriteLine("Audio");
                            }

                            if (seleccion == 1 || seleccion == 7)
                            {
                                Console.WriteLine("Pantalla");
                            }

                            if (seleccion == 9 || seleccion == 8)
                            {
                                Console.WriteLine("Consola");
                            }

                            if (seleccion == 10 || seleccion == 11)
                            {
                                Console.WriteLine("Cámara");
                            }

                            
                            Console.ReadKey();
                            /*Agregar y clasificar                              
                             * Minicomponente
                             * Reproductor BluRay
                             * Pantalla LCD PC 
                             * Consola de mesa 
                             * Consola portátil  
                             * Cámara fotográfica
                             * Cámara de vigilancia*/
                            break;
                        }
                    case 3:
                        {
                            Offers();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida..");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (option != 0);
            return 0;
        }
    }
}

