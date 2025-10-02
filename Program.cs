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
            Console.WriteLine($"Cantidad de sintes creados: {sintetizador2.CantidadDeSintes}");

            Console.WriteLine("\nBienvenido!\n");

            string infoEncendido1 = miSinte1.EncenderSinte1(true); //Enciende / apaga sintetizador 1
            string infoEncendido2 = miSinte2.EncenderSinte2(true); //Enciende / apaga sintetizador 2
            Console.WriteLine(infoEncendido1);
            Console.WriteLine(infoEncendido2);  



            
            miSinte1.ChequearBateria();
            miSinte1.SetEstadoBateria(87);
           
            Console.WriteLine($"Carga batería sintetizador 1: {miSinte1.GetEstadoBateria()} % ");

            Console.WriteLine("");

            miSinte2.ChequearBateria();
            miSinte2.SetEstadoBateria(66);
            Console.WriteLine($"Carga batería sintetizador 2: {miSinte2.GetEstadoBateria()} % ");



            //sintetizador2 nivelBateria = sintetizador2.GetEstadoBateria();





            //miSinte1.GenerarOndaSeno();
            //miSinte1.GenerarOndaSenoAnimada();

        }
    }
}
