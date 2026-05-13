using System.Security.Cryptography;

namespace EjerciciosProgramacion.Fundamentos
{
    public class Ejercicio02 : IEjercicio
    {
        public string Titulo => "#02 - Funciones y alcance";

        /*
        * EJERCICIO:
        * - Crea ejemplos de funciones básicas que representen las diferentes
        *   posibilidades del lenguaje:
        *   Sin parámetros ni retorno, con uno o varios parámetros, con retorno...
        * - Comprueba si puedes crear funciones dentro de funciones.
        * - Utiliza algún ejemplo de funciones ya creadas en el lenguaje.
        * - Pon a prueba el concepto de variable LOCAL y GLOBAL.
        * - Debes hacer print por consola del resultado de todos los ejemplos.
        *   (y tener en cuenta que cada lenguaje puede poseer más o menos posibilidades)
        *
        * DIFICULTAD EXTRA (opcional):
        * Crea una función que reciba dos parámetros de tipo cadena de texto y retorne un número.
        * - La función imprime todos los números del 1 al 100. Teniendo en cuenta que:
        *   - Si el número es múltiplo de 3, muestra la cadena de texto del primer parámetro.
        *   - Si el número es múltiplo de 5, muestra la cadena de texto del segundo parámetro.
        *   - Si el número es múltiplo de 3 y de 5, muestra las dos cadenas de texto concatenadas.
        *   - La función retorna el número de veces que se ha impreso el número en lugar de los textos.
        *
        * Presta especial atención a la sintaxis que debes utilizar en cada uno de los casos.
        * Cada lenguaje sigue una convenciones que debes de respetar para que el código se entienda.
        */

        public void Run()
        {

            string cara = "Cara";
            string culo = "Culo";
            var niCaraniCulo = ShowCaraCulo(cara, culo);
            Console.WriteLine("Conteo total ni cara ni culo: " + niCaraniCulo);
        }

        public int ShowCaraCulo(string cara, string culo)
        {
            int contador = 0;

            for (int i = 0; i <= 100; i++)
            {
                var moduloTres = i % 3;
                var moduloCinco = i % 5;
                var prefijo = moduloTres == 0 ? cara : "";
                var sufijo = moduloCinco == 0 ? culo : "";
                var salida = prefijo + sufijo;
                if(string.IsNullOrEmpty(salida))
                {
                    Console.WriteLine(i);
                    contador++;
                }
                else
                {
                    Console.WriteLine(salida);
                }

            }

            return contador;
        }
    }
}
