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
        private int _osciladores; //Numero de osciladores
        private int _polifonia; //Numero de notas que puede tocar al mismo tiempo

        //Atributos estáticos (comunes a todos los sintes)
        private static int _cantidadDeSintes = 0;
        private static string _fabricante = "Behringer";
        private static string versionFirmeware = "version 1.0.0";

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
            this._osciladores = osciladores;
            this._polifonia = polifonia;
            _cantidadDeSintes++;
        }

        // Propiedades estáticas
        public static int CantidadDeSintes => _cantidadDeSintes;
        public static string Fabricante => _fabricante;
        
        //Sintetizador 1
        public string EncenderSinte1(bool encendido)
        {
            this._encendido = encendido;

            if (_encendido)
            {
                
                StringBuilder info1 = new StringBuilder();
                
                info1.AppendLine("Sintetizador 1: ON");
                //info1.AppendLine("Bienvenido!");
               
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
                info1.AppendLine("Sintetizador: OFF");
                return info1.ToString();  
            }

        }

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
                info2.Append("Sintetizador: OFF");
                return info2.ToString();
            }

        }

        
        public void ChequearBateria()
        {
            Console.WriteLine("Chequeando batería");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500); // medio segundo de espera (delay en milisegundos)
                Console.Write("."); // imprime un punto sin salto de línea
            }

            Console.WriteLine(); // para terminar la línea
        }

        
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

            public void GenerarOndaTriangular()
            {






            }
            
            //Metodos Get y Set

            //Comprueba el estado de la batería con los metodos Get y Set

            //Set
            public string SetEstadoBateria(int nivelBateria)

            {
            
                StringBuilder sb = new StringBuilder();
            
                if (!_encendido)

                {
                    
                    sb.AppendLine("Sintetizador: OFF");
                    this._nivelBateria = nivelBateria;
                
                }

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


            //Get
            public int GetEstadoBateria()
            {
                return this._nivelBateria;
            }   
        

      


        



       



    }
}

//=============================================================================================================

/*
            public void GenerarOndaSenoAnimada()
            {
                int ancho = 80;   // ancho del gráfico (X)
                int alto = 20;    // altura del gráfico (Y)
                double frecuencia = 2 * Math.PI / 40; // cantidad de ciclos
                int desplazamiento = 0; // fase de la onda

                while (true) // bucle infinito
                {
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

=====================================================================================================================================
 
 
        public void GenerarOndaSeno()
        {
                if (_encendido)
                {


                    int ancho = 80;   // cantidad de puntos en el eje X
                    int alto = 20;    // altura en caracteres
                    double frecuencia = 2 * Math.PI / 40; // controla ciclos

                    // Recorremos las filas (de arriba hacia abajo)
                    for (int y = 0; y < alto; y++)
                    {
                        for (int x = 0; x < ancho; x++)
                        {
                            // Valor seno normalizado
                            double valor = Math.Sin(x * frecuencia);

                            // Escalar a rango de 0..alto
                            int posY = (int)((valor + 1) * (alto - 1) / 2);

                            // Dibujar punto o espacio
                            if (alto - y - 1 == posY)  // invertimos Y para que el 0 quede abajo
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }

            }

 ======================================================================================================================================

Atributos estáticos

los atributos estáticos no necesitan constructor de instancia porque no pertenecen a un objeto, pertenecen a la clase.

En tu clase sintetizador2 todos los atributos que pusiste ahora son de instancia: eso significa que cada objeto (new sintetizador2()) 
tiene sus propios valores para _marca, _modelo, _nivelBateria, etc.

Un atributo estático (static) en cambio:

Pertenece a la clase, no al objeto.

Se comparte entre todas las instancias.

Sirve para valores que son comunes a todos los sintetizadores.
 


-Ejemplos que sí tienen sentido ser estáticos. Son atributos coumunes a todos los sintes:

1. Cantidad de sintetizadores creados (un contador global):

        private static int _cantidadDeSintes = 0;

2. Marca “fabricante” global si todos los sintetizadores son de la misma compañía:

        private static string _fabricante = "Roland";

3. Versión de firmware o software que aplica a todos los modelos:

        private static string _versionFirmware = "1.0.0";

4. Voltaje de alimentación estándar que todos comparten:

        private static int _voltajeAlimentacion = 9; // voltios



Ejemplos que no deberían ser estáticos:

_encendido → cada sinte puede estar ON/OFF distinto.

_nivelBateria → cada sinte tiene su propia batería.

_numeroDeTeclas, _modelo, _osciladores, _polifonia → cambian según el modelo de sinte.


Ejemplo mezclando ambos:

internal class sintetizador2
{
    // Atributos de instancia (cada objeto tiene los suyos)
    private bool _encendido;
    private string _marca;
    private string _modelo;
    private int _numeroDeTeclas;
    private bool _tienePantalla;
    private int _nivelBateria;
    private int _osciladores;
    private int _polifonia;

    // Atributos estáticos (comunes a todos los sintetizadores)
    private static int _cantidadDeSintes = 0;
    private static string _fabricante = "Roland";
    private static string _versionFirmware = "1.0.0";

    // Constructor
    public sintetizador2()
    {
        _cantidadDeSintes++;
    }

    // Propiedad estática para ver cuántos hay
    public static int CantidadDeSintes => _cantidadDeSintes;
}

Y en el Main:

sintetizador2 s1 = new sintetizador2();
sintetizador2 s2 = new sintetizador2();

Console.WriteLine($"Fabricante: {sintetizador2._fabricante}"); // estático
Console.WriteLine($"Cantidad de sintes: {sintetizador2.CantidadDeSintes}"); // 2


Ejemplo práctico:

internal class sintetizador2
{
    // Atributos de instancia
    private bool _encendido;
    private string _marca;
    private string _modelo;
    private int _numeroDeTeclas;
    private bool _tienePantalla;
    private int _nivelBateria;
    private int _osciladores;
    private int _polifonia;

    // Atributos estáticos
    private static int _cantidadDeSintes = 0;
    private static int _voltajeAlimentacion = 9; 
    private static string _versionFirmware = "1.0.0";
    private static string _fabricante = "Roland";

    // Constructor
    public sintetizador2(string marca, string modelo)
    {
        _marca = marca;
        _modelo = modelo;
        _cantidadDeSintes++; // contador global
    }

    // Propiedades estáticas
    public static int CantidadDeSintes => _cantidadDeSintes;
    public static string Fabricante => _fabricante;
    public static string VersionFirmware => _versionFirmware;
}

en el Main:

sintetizador2 s1 = new sintetizador2("Roland", "Juno-DS");
sintetizador2 s2 = new sintetizador2("Roland", "Fantom");

Console.WriteLine($"Fabricante: {sintetizador2.Fabricante}");
Console.WriteLine($"Versión Firmware: {sintetizador2.VersionFirmware}");
Console.WriteLine($"Voltaje: 9V");
Console.WriteLine($"Cantidad de sintes creados: {sintetizador2.CantidadDeSintes}");


===================================================================================================================================
cuantas clase me convine hacer, una clase alcanza?

Alcanza si tu proyecto es simple y solo querés modelar el sintetizador con sus datos básicos y algunos métodos
(encender, apagar, mostrar info, etc.).

Ejemplo:

internal class Sintetizador
{
    // atributos de instancia
    private bool _encendido;
    private string _marca;
    private string _modelo;
    private int _numeroDeTeclas;
    private bool _tienePantalla;
    private int _nivelBateria;
    private int _osciladores;
    private int _polifonia;

    // atributos estáticos
    private static int _cantidadDeSintes = 0;

    public Sintetizador(string marca, string modelo)
    {
        _marca = marca;
        _modelo = modelo;
        _cantidadDeSintes++;
    }

    public string Encender(bool estado)
    {
        _encendido = estado;
        return estado ? "Sintetizador encendido" : "Sintetizador apagado";
    }

    public string MostrarInfo()
    {
        return $"Marca: {_marca}, Modelo: {_modelo}, Teclas: {_numeroDeTeclas}, Polifonía: {_polifonia}";
    }

    public static int CantidadDeSintes => _cantidadDeSintes;
}

Con esto podés crear objetos y listo.
Sirve para proyectos introductorios o educativos.

=====================================================================================================================


Con varias clases (mejor organización)

Si querés algo más realista/escalable, podés separar responsabilidades:

Clase Sintetizador → el objeto principal.

Clase Bateria → maneja nivel, carga, descarga, estado.

Clase Oscilador → representa cada oscilador (onda seno, cuadrada, diente de sierra…).

Clase Teclado → número de teclas, sensibilidad, aftertouch, etc.


class Bateria
{
    private int _nivel;
    public Bateria(int nivelInicial = 100) => _nivel = nivelInicial;
    public int Nivel => _nivel;
    public void Descargar(int cantidad) => _nivel = Math.Max(0, _nivel - cantidad);
    public void Cargar() => _nivel = 100;
}

class Sintetizador
{
    private string _marca;
    private string _modelo;
    private Bateria _bateria;

    public Sintetizador(string marca, string modelo)
    {
        _marca = marca;
        _modelo = modelo;
        _bateria = new Bateria();
    }

    public string MostrarInfo()
    {
        return $"Marca: {_marca}, Modelo: {_modelo}, Batería: {_bateria.Nivel}%";
    }
}

Esto sirve si después querés simular cosas (descargar batería, añadir más osciladores, cambiar firmware, etc.).


================================================================================================================================
internal class Sintetizador2
{
    // Atributos de instancia (cada sinte tiene los suyos)
    private bool _encendido;
    private string _marca;
    private string _modelo;
    private int _numeroDeTeclas;
    private bool _tienePantalla;
    private int _nivelBateria; // Nivel de batería del sintetizador (0-100)
    private int _osciladores;  // Número de osciladores
    private int _polifonia;    // Número de notas que puede tocar al mismo tiempo

    // Atributos estáticos (comunes a todos los sintes)
    private static int _cantidadDeSintes = 0;
    private static int _alimentacionPositiva = 12;
    private static int _alimentacionNegativa = -12;
    private static string _fabricante = "Behringer";
    // private static string _versionFirmware = "1.0.0";

    // Constructor
    public Sintetizador2(string marca, string modelo, int numeroDeTeclas, bool tienePantalla, int osciladores, int polifonia)
    {
        _encendido = false; // Valor por defecto
        _marca = marca;
        _modelo = modelo;
        _numeroDeTeclas = numeroDeTeclas;
        _tienePantalla = tienePantalla;
        _nivelBateria = 100; // Valor por defecto
        _osciladores = osciladores;
        _polifonia = polifonia;
        _cantidadDeSintes++;
    }

    // Propiedades estáticas (de solo lectura)
    public static int CantidadDeSintes => _cantidadDeSintes;
    public static string Fabricante => _fabricante;
    // public static string VersionFirmware => _versionFirmware;
}


===============================================================================================================

En el constructor está -string marca- y en atributo estático está el -string fabricante- está bien?

Sí, está bien 👍 y cumplen roles distintos:

marca (atributo de instancia):
Cada sintetizador puede ser de una marca distinta. Ejemplo: uno Behringer, otro Roland, otro Korg. Se guarda en el objeto.

fabricante (atributo estático):
Es común a todos los sintetizadores de tu clase. Sirve si querés fijar que todos los Sintetizador2 de este modelo vienen 
de un fabricante específico (ejemplo: Behringer).

ejemplo:
var sinte1 = new Sintetizador2("Behringer", "Model D", 37, false, 3, 6);
var sinte2 = new Sintetizador2("Roland", "Juno-106", 61, true, 2, 6);

Console.WriteLine($"Sinte1 marca: {sinte1.Marca}");
Console.WriteLine($"Sinte2 marca: {sinte2.Marca}");
Console.WriteLine($"Fabricante común: {Sintetizador2.Fabricante}");
Console.WriteLine($"Cantidad de sintes creados: {Sintetizador2.CantidadDeSintes}");

imprime:

Sinte1 marca: Behringer
Sinte2 marca: Roland
Fabricante común: Behringer
Cantidad de sintes creados: 2

 
 
 
 */







