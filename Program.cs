using System.ComponentModel;

namespace sintetizador2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sintetizador2 miSinte1 = new sintetizador2("PRO ONE", false, 16, false, 24, "DC", 2, 1 ); //Crea instancia para el sinte1
            sintetizador2 miSinte2 = new sintetizador2("ARP 2600", false, 16, false, 24, "DC", 4, 1); //Crea instancia para el sinte2

            Console.WriteLine($"Fabricante: {sintetizador2.Fabricante}");
            Console.WriteLine($"Cantidad de sintetizadores creados: {sintetizador2.CantidadDeSintes}");

            string saludo = sintetizador2.Saludar();
            Console.WriteLine(saludo);

            string infoEncendido1 = miSinte1.EncenderSinte1(true); //Enciende / apaga sintetizador 1
            string infoEncendido2 = miSinte2.EncenderSinte2(true); //Enciende / apaga sintetizador 2
           
            //Sintetizador 1
            Console.WriteLine(infoEncendido1);
            string checkBateria1 = miSinte1.ChequearBateriaMensaje();
            Console.WriteLine(checkBateria1);
            miSinte1.MoverPuntos();
            string estadoBateria1 = miSinte1.EstadoBateria(); //Setea el nivel de carga de la batería
            Console.WriteLine($"\nCarga batería sintetizador 1: {miSinte1.MensajeBateria()} % ");
            Console.WriteLine(estadoBateria1);


            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("");

            //Sintetizador 2
            Console.WriteLine(infoEncendido2);
            string checkBateria2 = miSinte2.ChequearBateriaMensaje();
            Console.WriteLine(checkBateria2);
            miSinte2.MoverPuntos();
            string estadoBateria2 = miSinte2.EstadoBateria(44); //Setea el nivel de carga de la batería
            Console.WriteLine($"\nCarga batería sintetizador 2: {miSinte2.GetEstadoBateria()} % ");
            Console.WriteLine(estadoBateria2);






            //miSinte1.GenerarOndaSeno();
            //miSinte1.GenerarOndaSenoAnimada();

        }
    }
}
