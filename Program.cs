using System.ComponentModel;

namespace sintetizador2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;



            do
            {


                //Crea las instancias de los objetos
                sintetizador2 miSinte1 = new sintetizador2(ModelosSintes.MonoPoly, true, 32, false, 12, "DC", 2, 1);
                sintetizador2 miSinte2 = new sintetizador2(ModelosSintes.ARP2600, false, 16, false, 24, "DC", 4, 1);
                sintetizador2 miSinte3 = new sintetizador2(ModelosSintes.Model_D, false, 16, false, 24, "DC", 4, 1);
                sintetizador2 miSinte4 = new sintetizador2(ModelosSintes.Solina, false, 16, false, 24, "DC", 4, 1);

                Console.WriteLine($"Fabricante: {sintetizador2.Fabricante}");
                Console.WriteLine($"Cantidad de sintetizadores creados: {sintetizador2.CantidadDeSintes}");

                string saludo = sintetizador2.Saludar();
                Console.WriteLine(saludo);

                Console.WriteLine("*** MENÚ ***");
                Console.WriteLine("Elija una opción:");

                Console.WriteLine("1.- MonoPoly");
                Console.WriteLine("2.- ARP2600");
                Console.WriteLine("3.- Model D");
                Console.WriteLine("2.- ARP Solina");
                Console.WriteLine("5.- Salir");


                //opcion = int.Parse(Console.ReadLine());


                //Corrobora que no se ingrese un caracter erróneo
                if (!int.TryParse(Console.ReadLine(), out opcion)){

                    Console.WriteLine("Opción inválida, intente nuevamente...");
                    continue;

                }



                string infoEncendido1 = miSinte1.EncenderSinte1(true); //Enciende / apaga sintetizador 1
                string infoEncendido2 = miSinte2.EncenderSinte1(true); //Enciende / apaga sintetizador 2
                string infoEncendido3 = miSinte3.EncenderSinte1(true);
                string infoEncendido4 = miSinte4.EncenderSinte1(true);


                if (opcion == 1)
                {

                    Console.WriteLine(infoEncendido1);
                    string checkBateria1 = miSinte1.ChequearBateriaMensaje();
                    Console.WriteLine(checkBateria1);
                    miSinte1.MoverPuntos();
                    int estadoBateria1 = miSinte1.EstadoBateria; //Setea el nivel de carga de la batería
                    string mensajeBateria1 = miSinte1.MostrarEstadoBateria;
                    Console.WriteLine($"\nCarga batería sintetizador 1: {miSinte1.EstadoBateria} % ");
                    Console.WriteLine(estadoBateria1);
                    Console.WriteLine(mensajeBateria1);

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey(); //Espera a presionar tecla

                    //miSinte1.GenerarOndaSeno();
                    miSinte1.GenerarOndaSenoAnimada();

                }
                if (opcion == 2)
                {

                    //Sintetizador 2
                    Console.WriteLine(infoEncendido2);
                    string checkBateria2 = miSinte2.ChequearBateriaMensaje();
                    Console.WriteLine(checkBateria2);
                    miSinte2.MoverPuntos();
                    string estadoBateria2 = miSinte2.MostrarEstadoBateria; //Setea el nivel de carga de la batería
                    Console.WriteLine($"\nCarga batería sintetizador 2: {miSinte2.EstadoBateria} % ");
                    Console.WriteLine(estadoBateria2);

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey(); //Espera a presionar tecla

                    //miSinte1.GenerarOndaSeno();
                    //miSinte1.GenerarOndaSenoAnimada();


                }
                if (opcion == 3)
                {


                    //Sintetizador 3
                    Console.WriteLine(infoEncendido3);
                    string checkBateria3 = miSinte3.ChequearBateriaMensaje();
                    Console.WriteLine(checkBateria3);
                    miSinte2.MoverPuntos();
                    string estadoBateria3 = miSinte3.MostrarEstadoBateria; //Setea el nivel de carga de la batería
                    Console.WriteLine($"\nCarga batería sintetizador 2: {miSinte3.EstadoBateria} % ");
                    Console.WriteLine(estadoBateria3);

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey(); //Espera a presionar tecla

                    //miSinte1.GenerarOndaSeno();
                    //miSinte1.GenerarOndaSenoAnimada();

                }
                if (opcion == 4)
                {


                    //Sintetizador 4
                    Console.WriteLine(infoEncendido4);
                    string checkBateria4 = miSinte4.ChequearBateriaMensaje();
                    Console.WriteLine(checkBateria4);
                    miSinte2.MoverPuntos();
                    string estadoBateria4 = miSinte4.MostrarEstadoBateria; //Setea el nivel de carga de la batería
                    Console.WriteLine($"\nCarga batería sintetizador 4: {miSinte4.EstadoBateria} % ");
                    Console.WriteLine(estadoBateria4);

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey(); //Espera a presionar tecla

                    //miSinte1.GenerarOndaSeno();
                    //miSinte1.GenerarOndaSenoAnimada();


                }


            } while (opcion != 5);
            { Console.WriteLine("Bye bye....");}
        }
    }
}
