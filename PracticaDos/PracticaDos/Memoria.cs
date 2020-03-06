
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticaDos
{
    class Memoria
    {
        public void LeerMemoria()
        {
            string archivoDB = "../../../db.json";
            using (var reader = new StreamReader(archivoDB))
            {
                var dbJSON = reader.ReadToEnd();
                var dbObject = JObject.Parse(dbJSON);
                // Prueba de lectura de archivo db.json
                // var result = dbObject.ToString();
                // var result = dbObject["arreglo"].ToString();
                // var result = dbObject["arreglo"][0].ToString();
                // Lectura del json iterable
                foreach (var item in dbObject)
                {
                    // Iteración individual de cada grupo de datos del objeto json.
                    Console.WriteLine("Dato en memoria:");
                    MemoriaData memoriaData = new MemoriaData(DateTime.Now, item.Value["operacion"].ToString(), (int)item.Value["resultado"]);
                    Console.WriteLine("Fecha \n:");
                    Console.WriteLine(item.Key.ToString());
                    Console.WriteLine("El resultado es \n:");
                    Console.WriteLine(memoriaData.resultado.ToString());
                }
            }
        }
    }

    public void arreglos ()
    {
        string[] Colores = {"Rojo", "Blanco", "Morado"};
        //List<string> colores = ["Rojo", "Blanco", "Morado"];
        //colores.Sort();
        Array.Sort(Colores);
        Array.ForEach(Colores, (item)=>{
            Console.WriteLine(item);
        });
        String color =Array.Find(Colores, (item) => {
            return item.Length > 4;
            //return item != "Morado";
        });
        
        Console.WriteLine(color);
        Console.WriteLine ("Accede tus colores favoritos y separalos por espacios:");
        String colorUser = Console.ReadLine();
        //Un string se puede convertir en arreglo con su propedad Split, dandole el patron.
        string[] newColors = colorUser.Split(' ');
        Console.WriteLine(newColors);
    }
        public void multidimensional ()
        {
            int[,] array = new int [4, 2,3];
            Console.WriteLine(array);
        }

    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(DateTime date, String operation, int result)
        {
            fecha = date;
            operacion = operation;
            resultado = result;
        }
    }


}