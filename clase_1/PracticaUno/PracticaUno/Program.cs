using System;

namespace PracticaUno
{
    class Program
    {
        // Variable de la clase
        static string nombre = "Imelda";
        static void Main(string[] args)
        {
            // Respondemos con el primer argumento y segundo
            // Condicion swe debe de cumplir todas las sentencias si utilizamos &&
            // Condicion swe debe de cumplir cualquierda de las sentencias si utilizamos ||
            // Tipos de comparacion: < > == <= >= !=
            if (args[0].Length > 0 && args [0] == nombre) // verdadero o falso
            {
                Console.WriteLine($"Hello {args[0]}");
            }else
            {
                Console.WriteLine("User unauthorized");
            }
        }
    }
}