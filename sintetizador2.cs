using System.Text;

namespace sintetizador2
{
    internal class sintetizador2
    {

        //Atributos de instancia (cada sinte tiene los suyos)
        private bool _encendido;
        
        private string _modelo;
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

        //================================================================================================================

        //Atributos estáticos (comunes a todos los sintes)
        private static int _cantidadDeSintes = 0;
        private static string _fabricante = "Behringer";
        private static string versionFirmeware = "version 1.0.0";

        //=================================================================================================================

        //Constructor
        public sintetizador2(string modelo, bool tieneTeclas, int numeroDeTeclas, bool tienePantalla, int tensionDeTrabajo, 
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
            _cantidadDeSintes++;
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


        }

        //===========================================================================================================================

        //Sintetizador 1
        public string EncenderSinte1(bool encendido)
        {
            this._encendido = encendido;

            if (_encendido)
            {
                
                StringBuilder info1 = new StringBuilder();
                
                info1.AppendLine("Sintetizador 1: ON");
               
               
                info1.AppendLine($"Modelo: {_modelo}");
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

        //====================================================================================================================

        //Sintetizador 2
        public string EncenderSinte2(bool encendido)
        {
            this._encendido = encendido;

            if (_encendido)
            {

                StringBuilder info2 = new StringBuilder();

                info2.AppendLine("Sintetizador 2: ON\n");
                
                info2.AppendLine($"Modelo: {_modelo}");
                info2.AppendLine($"Pantalla: {_tienePantalla}");
                info2.AppendLine($"Tensión: {_tensionDeTrabajo} volts");
                info2.AppendLine($"Tipo de tensión: {_tipoDeTensionDeTrabajo}");
                info2.AppendLine($"Cantidad de osciladores: {_osciladores}");
                info2.AppendLine($"Polifonia: {_polifonia}");

                if (_tieneTeclas)
                {

                    info2.AppendLine($"Número de teclas: {_numeroDeTeclas}");
                }
                else
                {

                    info2.AppendLine($"No posee teclas");
                   
                }


                return info2.ToString();


            }
            else
            {
                StringBuilder info2 = new StringBuilder();
                info2.Append("Sintetizador 2: OFF");
                return info2.ToString();
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

        //Metodos Get y Set

        //Comprueba el estado de la batería con los metodos Get y Set


        public int EstadoBateria 
        
        {   get { return this._nivelBateria; }

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
                    sb.AppendLine("Estado batería: COMPLETO ");

                }
                else if (value >= 66)
                {

                    this._nivelBateria = value;
                    sb.AppendLine("Estado batería: OK + ");

                }
                else if (value >= 33)
                {

                    this._nivelBateria = value;
                    sb.AppendLine("Estado batería: OK - ");

                }

                else
                {
                    //this._nivelBateria = value;
                    sb.AppendLine("Recargar batería");
                }

                _mensajeBateria = sb.ToString();

            }
        }

        public string MensajeBateria 
        { get { return _mensajeBateria;}




        /*
        public string SetEstadoBateria(int nivelBateria)

            {

                StringBuilder sb = new StringBuilder();



                //Normaliza el nivel de bateria
                if (nivelBateria < 0)
                {
                    nivelBateria = 0;
                }

                if (nivelBateria > 100)
                {
                    nivelBateria = 100;
                }

                //Asigna el valor al atributo
                this._nivelBateria = nivelBateria;

                //Comprueba el estado de la bateria
                if (nivelBateria == 100)
                {

                    this._nivelBateria = nivelBateria;
                    sb.AppendLine("Estado batería: COMPLETO ");


                }
                else if (nivelBateria >= 66)
                {

                    this._nivelBateria = nivelBateria;
                    sb.AppendLine("Estado batería: OK + ");



                }
                else if(nivelBateria >= 33)
                {

                    this._nivelBateria = nivelBateria;
                    sb.AppendLine("Estado batería: OK - ");



                }



                else
                {
                    this._nivelBateria = nivelBateria;
                    sb.AppendLine("Recargar batería");
                }

               return sb.ToString();


        }

        //===========================================================================================================================


            //Get
            public int GetEstadoBateria()
            {
                return this._nivelBateria;
            }   


      */
    }
}






