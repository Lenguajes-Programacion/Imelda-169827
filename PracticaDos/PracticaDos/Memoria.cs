using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticaDos
{
    class Memoria
    {
        // Creación de una lista nativa para el manejo de la memoria.
        public List<MemoriaData> db = new List<MemoriaData>();
        public Memoria()
        {
            // Constructor de la clase Memoria, para inicializar nuestra lista
            db = new List<MemoriaData>();
        }
        public void LeerMemoria()
        {
            ConsoleColor currentColor = Console.BackgroundColor;
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            // Prueba de lectura de archivo db.json
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
            // Lectura de json iterable
            int i = 0; // Indice creado manualmente para ubicar facilmente nuestros objetos dentro de la lista db.
            foreach (var item  in dbObject)
            {
                // Iteración individual de cada grupo de datos del objeto json.
                MemoriaData memoriaData = new MemoriaData(item.Key.ToString(), item.Value["operacion"].ToString(),item.Value["resultado"].ToString());
                this.db.Add(memoriaData);
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.WriteLine("Operación: {0}",memoriaData.operacion);
                Console.WriteLine("Resultado: {0}",memoriaData.resultado.ToString());
                Console.WriteLine("----------------- \n");
                i++;
            }
        }
        public int GetMemoriaData(String key)
        {
            // Encontrar el dato deseado con indice manual en el parseo del json.
            int index = int.Parse(key);
            // Opción Nativa:  para buscar de manera nativa en nuestro List db. con el indice autogenerado.
            // En tres lineas de código encontramos y reutilizamos el valor que se busca.
            MemoriaData data = db[index];
            return data.resultado;
        }
        public void GuardarMemoria(MemoriaData data)
        {
            db.Add(data);
            int i = 0;
            db.ForEach((MemoriaData memoriaData) =>
            {
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.WriteLine("Operación: {0}", memoriaData.operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.resultado.ToString());
                Console.WriteLine("----------------- \n");
                i++;
            });
            string json = JsonConvert.SerializeObject(db.ToArray(), Formatting.Indented);
            string archivoDB = "../../../db.json";
            File.WriteAllText(archivoDB, json);
        }
        public void arreglo()
        {
            string[] Colores = { "Rojo", "Blanco", "Morado" };
            //List<string> colores = ["Rojo", "Blanco", "Morado"];
            //colores.Sort();
            Array.Reverse(Colores);
            Array.ForEach(Colores, (item)=>{
                Console.WriteLine(item);
            });
            String color = Array.Find(Colores, (item) => {
                return item.Length > 4;
            });
            Console.WriteLine(color);
            Console.WriteLine("Accede tus colores y separalos con comas(,):");
            String colorUser = Console.ReadLine();
            // Un string se puede convertir en arreglo con su propiedad Split, dándole el patron.
            string[] newColors = colorUser.Split(' ');
            Console.WriteLine(newColors);
        }

        //public void multidimensional()
        static void Main(String [] args)
        {
            bool salir =  false;
            while (!salir)
            {
                Console.WriteLine ("Arreglo sensillo");
                string[] sencillo = { "Rojo", "Blanco", "Morado" };
                Console.WriteLine ("[{0}]", string.Join(",", sencillo));
                Console.WriteLine("Arreglo dos dimensiones");
                int[,] dosDimensiones = new int[5,5];
                for (int i = 0; i < dosDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < dosDimensiones.GetLength(1);j++)
                    {
                        Console.WriteLine("{0}, {1} = {2}", i,j, dosDimensiones[i,j]);
                    }
                }
                Console.WriteLine("Arreglo de tres dimensiones");
                int [,,] tresDimensiones = new int[5, 5, 5];
                for (int i = 0; i < tresDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < tresDimensiones.GetLength(1); j++)
                    {
                        for (int k = 0; k < tresDimensiones.GetLength(2); k++)
                        {

                            Console.WriteLine("{0}, {1}, {2} = {3}", i,j,k, tresDimensiones[i,j,k]);
                        }
                    }
                }
                Console.WriteLine("Arreglo de cuatro dimensiones");
                int [,,,] cuatroDimensiones = new int[5, 5, 5, 5];
                for (int i = 0; i < cuatroDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < cuatroDimensiones.GetLength(1); j++)
                    {
                        for (int k = 0; k < cuatroDimensiones.GetLength(2); k++)
                        {
                            for (int l = 0; l < cuatroDimensiones.GetLength(2); l++)
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3} = {4}", i,j,k,l, cuatroDimensiones[i,j,k,l]);
                            }
                        }
                    }
                }
                string exit = Console.ReadLine();
                if (exit == "y")
                {
                    salir = true;
                }
            }
        }
    }
    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData( String date, String operation, String result)
        {
            fecha = DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);
        }
    }


}