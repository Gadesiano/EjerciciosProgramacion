namespace EjerciciosProgramacion.Fundamentos
{
    /// <summary>
    /// #00 - Sintaxis, Variables, Tipos de Datos y Hola Mundo
    /// Dificultad: Fácil
    /// https://github.com/mouredev/roadmap-retos-programacion/blob/main/Roadmap/00%20-%20SINTAXIS%2C%20VARIABLES%2C%20TIPOS%20DE%20DATOS%20Y%20HOLA%20MUNDO/ejercicio.md
    /// 
    /// ENUNCIADO:
    /// - Crea un comentario en el código y coloca la URL del sitio web oficial del lenguaje.
    /// - Representa las diferentes sintaxis de comentarios (una línea, varias...).
    /// - Crea una variable y una constante.
    /// - Crea variables representando todos los tipos de datos primitivos del lenguaje.
    /// - Imprime por terminal el texto: "¡Hola, [nombre del lenguaje]!"
    /// </summary>
    public class Ejercicio00 : IEjercicio
    {
        public string Titulo => "#00 - Sintaxis, Variables, Tipos de Datos y Hola Mundo";

        public void Run()
        {
            //Comentario de una sola línea

            /*
             * Comentario de varias líneas:
             * El lenguaje elegido es C# en .NET
             * Sitio oficial en español: https://dotnet.microsoft.com/es-es/languages/csharp
             */

            string lenguaje = "C#";
            const string UrlTutorial = "https://github.com/ramsoftware/C-Sharp/tree/main";

            byte limiteInferiorByte = 0;
            byte limiteSuperiorByte = 255;
            sbyte limiteInferiorSbyte = -128;
            sbyte limiteSuperiorSbyte = 127;
            short limiteInferiorShort = -32768;
            short limiteSuperiorShort = 32767;
            int limiteInferiorInt = -2147483648;
            int limiteSuperiorInt = 2147483647;
            uint limiteInferiorUint = 0;
            uint limiteSuperiorUint = 4294967295;
            long limiteInferiorLong = -9223372036854775808;
            long limiteSuperiorLong = 9223372036854775807;
            ulong limiteInferiorUlong = 0;
            ulong limiteSuperiorUlong = 18446744073709551615;
            float piFloat = 3.14f;
            double piDouble = 3.14;
            decimal piDecimal = 3.14m;
            bool isBoolean = true;
            char ultimaLetra = 'Z';
            string ciudad = "Cádiz";

            Console.WriteLine($"El lenguaje elegido para los ejercicios es {lenguaje}.\nAquí se puede acceder a un tutorial desde cero: {UrlTutorial}");
            Console.WriteLine($"Estos son los tipos primitivos en {lenguaje}");
            Console.WriteLine($"byte: {limiteInferiorByte} a {limiteSuperiorByte}");
            Console.WriteLine($"sbyte: {limiteInferiorSbyte} a {limiteSuperiorSbyte}");
            Console.WriteLine($"short: {limiteInferiorShort} a {limiteSuperiorShort}");
            Console.WriteLine($"int: {limiteInferiorInt} a {limiteSuperiorInt}");
            Console.WriteLine($"uint: {limiteInferiorUint} a {limiteSuperiorUint}");
            Console.WriteLine($"long: {limiteInferiorLong} a {limiteSuperiorLong}");
            Console.WriteLine($"ulong: {limiteInferiorUlong} a {limiteSuperiorUlong}");
            Console.WriteLine($"float: {piFloat}");
            Console.WriteLine($"double: {piDouble}");
            Console.WriteLine($"decimal: {piDecimal}");
            Console.WriteLine($"bool: {isBoolean}");
            Console.WriteLine($"char: {ultimaLetra}");
            Console.WriteLine($"string: {ciudad}");
            Console.WriteLine($"Hola, {lenguaje}");
        }
    }
}
