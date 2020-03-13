using System;

namespace PracticaDos
{
    class Calculadora
    {
        //static void Main(string[] args)
        static void Calcu()
        {
            Memoria memoria = new Memoria();
            Console.WriteLine("CalculApp");
            Console.WriteLine("----------------- \n");
            bool close_app = true;
            int valor1 = 0;
            int valor2 = 0;
            int result = 0;
            while (close_app)
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("Presiona (+) Suma");
                Console.WriteLine("Presiona (-) Resta");
                Console.WriteLine("Presiona (*) Multiplicación");
                Console.WriteLine("Presiona (/) Disión");
                Console.WriteLine("Presiona (m) Memoria");
                Console.WriteLine("Presiona (mr) Borrar Memoria");
                Console.WriteLine("Presiona (e) Para salir \n");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("Suma \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = result == 0 ? int.Parse(Console.ReadLine()) : result;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.suma(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        String o = valor1 + "+" + valor2;
                        MemoriaData data = new MemoriaData(DateTime.Now.ToString(), o, result.ToString());
                        memoria.GuardarMemoria(data);
                        result = 0;
                        break;
                    case "-":
                        Console.WriteLine("Resta \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = result == 0 ? int.Parse(Console.ReadLine()) : result;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.resta(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        result = 0;

                        break;
                    case "*":
                        Console.WriteLine("Multiplicación \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = result == 0 ? int.Parse(Console.ReadLine()) : result;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.multi(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        result = 0;

                        break;
                    case "/":
                        Console.WriteLine("División \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = result == 0 ? int.Parse(Console.ReadLine()) : result;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        result = Calculus.division(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", result);
                        result = 0;

                        break;
                    case "m":
                        Console.WriteLine("Accediendo a Memoria \n");
                        Console.WriteLine("-----------------\n");
                        //memoria.multidimensional();
                        String key = Console.ReadLine();
                        //Console.WriteLine(data.ToString());
                        // Elegir la opcion de resultado en nuestra memoria 
                        // y reutilizarla en alguna operación.
                        // 1. Crear metodo que nos regrese el resultado seleccionado.
                        result = memoria.GetMemoriaData(key);
                        // 2. Utilizar el resultado en una nueva operación.
                        Console.WriteLine(result);
                        // 3. Guardar la nueva operación en nuestra db.json.
                        // memoria.GuardarMemoria();
                        break;
                    case "mr":
                        Console.WriteLine("Memoria Temporal Reiniciada! \n");
                        result = 0;
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