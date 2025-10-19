using System.Text;

namespace sintetizador2
{
    public enum ModelosSintes
    {
        MonoPoly = 1,
        ARP2600 = 2,
        Model_D = 3,
        Solina = 4,
        Oddissey = 5,
        MS_5 = 6,
        MS_101 = 7
    }




    internal class sintetizador2
    {

        //Atributos de instancia (cada sinte tiene los suyos)
        private bool _encendido;

        private ModelosSintes _modelo;
        private bool _tieneTeclas;
        private int _numeroDeTeclas;
        private bool _tienePantalla;
        private int _tensionDeTrabajo;
        private string _tipoDeTensionDeTrabajo;
        private int _nivelBateria; //Nivel de bateria del sintetizador (0-100)
        private string _estadoBateriaMensaje;
        private string _mensajeBateria;
        private int _osciladores; //Numero de osciladores
        private int _polifonia; //Numero de notas que puede tocar al mismo tiempo
        private int _opcion; //Elije el sinte

        //================================================================================================================

        //Atributos estáticos (comunes a todos los sintes)
        private static int _cantidadDeSintes = 0;
        private static string _fabricante = "Behringer";
        private static string versionFirmeware = "version 1.0.0";

        //=================================================================================================================

        //Constructor
        public sintetizador2(ModelosSintes modelo, bool tieneTeclas, int numeroDeTeclas, bool tienePantalla, int tensionDeTrabajo,
                             string tipoDeTensionDeTrabajo, int osciladores, int polifonia)

        {
            this._encendido = false; //Valor por defecto
             
            this._modelo = modelo;
            this._tieneTeclas = tieneTeclas;
            this._numeroDeTeclas = numeroDeTeclas;
            this._tienePantalla = tienePantalla;
            this._tensionDeTrabajo = tensionDeTrabajo;
            this._tipoDeTensionDeTrabajo = tipoDeTensionDeTrabajo;
            this._nivelBateria = 100; //Valor por defecto
            this._estadoBateriaMensaje = "";
            this._mensajeBateria = "";
            this._osciladores = osciladores;
            this._polifonia = polifonia;
            _cantidadDeSintes++;// ver para constructor estatico
        }

        //===========================================================================================================================

        // Propiedades estáticas
        public static int CantidadDeSintes => _cantidadDeSintes;
        public static string Fabricante => _fabricante;

        //===========================================================================================================================

        public static string Saludar()
        {
            StringBuilder saludar = new StringBuilder();

            saludar.AppendLine("\nBienvenido!\n");


            return saludar.ToString();
        }

        //===========================================================================================================================


        public void CargarMaquinas()
        {
            //Listas

        }

        //===========================================================================================================================

        /*
        public int ElegirSinte(int sinte)
        {

            do
            {
                Console.WriteLine("1.- MonoPoly");
                Console.WriteLine("2.- ARP2600");


                if (sinte == 1)
                {


                
                
                
                }






            } while (true);
                
        
        
        
        
        }
        */

        //Sintetizadores
        public string EncenderSinte1(bool encendido)
        {
            this._encendido = encendido;

            if (_encendido)
            {

                StringBuilder info1 = new StringBuilder();

                info1.AppendLine($"{_modelo}: ON");


                //info1.AppendLine($"Modelo: {_modelo}");
                info1.AppendLine($"Pantalla: {_tienePantalla}");
                info1.AppendLine($"Tensión: {_tensionDeTrabajo} volts");
                info1.AppendLine($"Tipo de tensión: {_tipoDeTensionDeTrabajo}");
                info1.AppendLine($"Cantidad de osciladores: {_osciladores}");
                info1.AppendLine($"Polifonia: {_polifonia}");

                if (_tieneTeclas)
                {

                    info1.AppendLine($"Número de teclas: {_numeroDeTeclas}");

                }
                else
                {

                    info1.AppendLine($"No posee teclas");

                }


                return info1.ToString();


            }
            else
            {
                StringBuilder info1 = new StringBuilder();
                info1.AppendLine("Sintetizador 1: OFF");
                return info1.ToString();
            }

        }

        //=========================================================================================================================

        public string ChequearBateriaMensaje()
        {
            StringBuilder chequearBateria = new StringBuilder();
            chequearBateria.Append("\nChequeando batería");
            return chequearBateria.ToString();

        }

        //=========================================================================================================================

        public void MoverPuntos()
        {


            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500); // medio segundo de espera (delay en milisegundos)
                Console.Write("."); // imprime un punto sin salto de línea
            }


            //Console.WriteLine(); // para terminar la línea
        }

        //=========================================================================================================================

        public void GenerarOndaSenoAnimada()
        {

            if (_encendido)
            {
                int ancho = 80;   // ancho del gráfico (X)
                int alto = 20;    // altura del gráfico (Y)
                double frecuencia = 2 * Math.PI / 40; // cantidad de ciclos
                int desplazamiento = 0; // fase de la onda

                while (true) // bucle infinito
                {
                    Thread.Sleep(5000); //Espera 5 segundos antes de limpiar la pantalla;
                    Console.Clear();

                    // recorrer filas
                    for (int y = 0; y < alto; y++)
                    {
                        for (int x = 0; x < ancho; x++)
                        {
                            // calcular seno con desplazamiento
                            double valor = Math.Sin((x + desplazamiento) * frecuencia);

                            // escalar al rango vertical
                            int posY = (int)((valor + 1) * (alto - 1) / 2);

                            // dibujar punto o espacio
                            if (alto - y - 1 == posY)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                    desplazamiento++;           // mover la onda
                    Thread.Sleep(100);          // velocidad de la animación
                }

            }
        }

        //=============================================================================================================================
        public void GenerarOndaTriangular()
        {






        }

        //=============================================================================================================================

        //Metodos Get y Set (propiedades)
        //Comprueba el estado de la batería

        public int EstadoBateria

        {
            get { return this._nivelBateria; }

            set
            {
                StringBuilder sb = new StringBuilder();

                //Normaliza el nivel de bateria
                if (value < 0)
                {
                    value = 0;
                }

                if (value > 100)
                {
                    value = 100;
                }

                //Asigna el valor al atributo
                this._nivelBateria = value;

                //Comprueba el estado de la bateria
                if (value == 100)
                {

                    this._nivelBateria = value;
                   

                }
                else if (value >= 66)
                {

                    this._nivelBateria = value;
                   

                }
                else if (value >= 33)
                {

                    this._nivelBateria = value;
                    

                }

                else
                {
                    this._nivelBateria = value;
                }

            }
        }

       

        //Propiedad autoreferenciada
        public string MostrarEstadoBateria
        {

            get { return this._mensajeBateria; }



            set
            {
                StringBuilder sb = new StringBuilder();

                if (this._nivelBateria == 100)
                {
                    sb.AppendLine("Estado de batería completo");

                }
                else if (this._nivelBateria >= 66)
                {

                    sb.AppendLine("Estado batería: OK + ");

                }
                else if (this._nivelBateria >=33)
                {

                    sb.AppendLine("Estado batería: OK - ");
                
                }
                else
                {

                    sb.AppendLine("Recargar batería");

                }

                this._mensajeBateria = sb.ToString();
            }



            }
        }
    }



