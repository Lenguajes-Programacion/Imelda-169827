using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace PracticaDos
{
	class Memoria
	{
        public void LeerMemoria()
        {
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJson = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJson);
            //Prueba de lectura de archivo db.json
            //var result = dbObject - ToString();
            //var result = dbObject["arreglo"][0].ToString();
            //lectura de nuestro Json iterable
            foreach(var item in dbObject)
            {
                // Interaccion indibidual de cada grupo de datos del objeto Json
                Console.WriteLine("Dato de Memoria");
                memoriaData meoriaData = new MemoriaData(DateTime.Now, item["operacion"].ToString(),(int) int;
                Console.WriteLine(item.Key.ToString());
                Console.WriteLine(memoriaData.resultado.ToString());
            }
        }
	}
    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;
        public int imelda;
        
        public MemoriaData(DateTime fecha, String operacion, int resultado)
        {
            fecha = fecha;
            operacion = operacion;
            resultado = resultado;
        }
    }
}
