namespace EjerciciosProgramacion.Fundamentos
{
    public class Ejercicio01 : IEjercicio
    {
        public string Titulo => "#01 - Operadores y estructuras de control";
        /*
         * EJERCICIO:
         * - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
         *   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
         *   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
         * - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
         *   que representen todos los tipos de estructuras de control que existan
         *   en tu lenguaje:
         *   Condicionales, iterativas, excepciones...
         * - Debes hacer print por consola del resultado de todos los ejemplos.
         *
         * DIFICULTAD EXTRA (opcional):
         * Crea un programa que imprima por consola todos los números comprendidos
         * entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.
         *
         * Seguro que al revisar detenidamente las posibilidades has descubierto algo nuevo.
         * 
         * Dificultad: Fácil
         * URL: https://github.com/mouredev/roadmap-retos-programacion/blob/main/Roadmap/01%20-%20OPERADORES%20Y%20ESTRUCTURAS%20DE%20CONTROL/ejercicio.md
         */
        public void Run()
        {
            int a = 7;
            int b = 13;
            Console.WriteLine($"Operadores aritméticos con a = {a} y b = {b}");
            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
            Console.WriteLine($"División: {a / b}");
            Console.WriteLine($"Módulo: {a % b}");
            a++;
            Console.WriteLine($"Incremento de a++: {a}");
            b--;
            Console.WriteLine($"Decremento de b--: {b}");
            a--;
            b++;


            Console.WriteLine($"\nOperadores de comparación con a = {a} y b = {b}");
            Console.WriteLine($"Igual: {a == b}");
            Console.WriteLine($"Diferente: {a != b}");
            Console.WriteLine($"Mayor que: {a > b}");
            Console.WriteLine($"Menor que: {a < b}");
            Console.WriteLine($"Mayor-Igual que: {a >= b}");
            Console.WriteLine($"Menor-Igual que: {a <= b}");

            bool c = true;
            bool d = false;

            Console.WriteLine($"\nOperadores lógicos con c = {c} y d = {d}");
            Console.WriteLine($"AND: {c && d}");
            Console.WriteLine($"OR: {c || d}");
            Console.WriteLine($"NOT de c: {!c}");

            int e = 7;
            int f = 2;
            Console.WriteLine($"\nOperadores de asignación con e = {e} y f = {f}");
            Console.WriteLine($"e += f: {e += f}");
            Console.WriteLine($"e -= f: {e -= f}");
            Console.WriteLine($"e *= f: {e *= f}");
            Console.WriteLine($"e /= f: {e /= f}");
            Console.WriteLine($"e %= f: {e %= f}");

            int g = 6;
            int h = 2;
            Console.WriteLine($"\nOperadores de bits con g = {g} y h = {h}");
            Console.WriteLine($"AND bit a bit: {g & h}");
            Console.WriteLine($"OR bit a bit: {g | h}");
            Console.WriteLine($"XOR bit a bit: {g ^ h}");
            Console.WriteLine($"NOT bit a bit de g: {~g}");
            Console.WriteLine($"Desplazamiento izquierda de g: {g << 1}");
            Console.WriteLine($"Desplazamiento derecha de h: {h >> 1}");

            Console.WriteLine($"\nEstructuras de control condicionales => if / else if / else con a = {a} y b = {b}");
            if (a > b)
            {
                Console.WriteLine($"a = {a} es mayor que b = {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"a = {a} es menor que b = {b}");
            }
            else
            {
                Console.WriteLine($"a = {a} y b = {b} son iguales");
            }

            Console.WriteLine($"\nEstructuras de control condicionales => switch case con a = {a}");
            switch (a)
            {
                case 7: 
                    Console.WriteLine($"a es = Siete");
                    break;
                default:
                    Console.WriteLine($"a es = {a}");
                    break;
            }

            Console.WriteLine($"\nEstructuras de control condicionales => switch case compacto con a = {a}");
            string resultado = a switch
            {
                7 => "Siete",
                _ => a.ToString()
            };
            Console.WriteLine(resultado);

            Console.WriteLine($"\nEstructuras de control iterativas => for con (i = 0) <= (a = {a})");
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"\nEstructuras de control iterativas => while con (j = 0) < (a = {a})");
            int j = 0;
            while (j < a)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine($"\nEstructuras de control iterativas => do while con (k = 7) > (a = {a})");
            int k = 7;
            do 
            {
                k--;
                Console.WriteLine(k);
            } 
            while (k >= a);

            Console.WriteLine($"\nEstructuras de control iterativas => foreach con a = {a}, b = {b}, e = {e}, f = {f}, g = {g} y h = {h}");
            int[] ints = {a, b, e, f, g, h};
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"\nEstructuras de control de excepciones => try-catch con a = {a}");
            try
            {
                
                for (int i = 5; i >= 0; i--)
                {
                    var division = a / i;
                    Console.WriteLine(division);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"[ERROR] al dividir por cero. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] indeterminado. " + ex.Message);
            }
            finally
            {
                Console.WriteLine($"Bucle finalizado");
            }

            Console.WriteLine("\nDIFICULTAD AÑADIDA!");
            for (int i = 10; i <= 55; i++)
            {
                var moduloDos = i % 2;
                var igualDieciseis = 16;
                var moduloTres = i % 3;
                if (moduloDos == 0 && i != igualDieciseis && moduloTres != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
