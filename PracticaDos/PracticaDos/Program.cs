using System;

namespace PracticaDos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CalculApp");
            Console.WriteLine("----------------- \n");
            bool close_app = true;
            int valor1 = 0;
            int valor2 = 0;
            float result = 0;
            while (close_app)
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("(+) Suma");
                Console.WriteLine("(-) Resta");
                Console.WriteLine("(*) Multiplicación");
                Console.WriteLine("(/) Disión");
                Console.WriteLine("(m) memoria");
                Console.WriteLine("e Para salir \n");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("Suma \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.suma(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        break;
                    case "-":
                        Console.WriteLine("Resta \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.resta(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        break;
                    case "*":
                        Console.WriteLine("Multiplicación \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.multi(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        break;
                    case "/":
                        Console.WriteLine("División \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.division(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        break;
                    case "m":
                        Console.WriteLine("Accediendo a Memoria \n");
                        Console.WriteLine("-----------------\n");
                        Memoria memoria = new Memoria();
                        memoria.LeerMemoria();
                        //Elegir la opcion de resultado en nuestra memoria y reautilizarla en alguna operacion.
                        // 1. Crear metodo que nos regrese el resultado en una nueva operacion.
                        // 2. Utilizar el resultado en una nueva operacion.
                        // 3. Guardar la nueva operacion en nuestro db.Json

                        break;
                    case "e":
                        Console.WriteLine("-----------------\n");
                        Console.WriteLine("Cerrando CalculApp! \n");
                        close_app = false;
                        break;
                    default:
                        Console.WriteLine("Opción desconocida: {0}, intenta de nuevo \n", opcion);
                        break;
                }
            }
        }
    }
    class Calculus
    {
        public static int suma(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 + valor2;
            return result;
        }
        public static int resta(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 - valor2;
            return result;
        }
        public static int multi(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 * valor2;
            return result;
        }
        public static int division(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 / valor2;
            return result;
        }
    }
}