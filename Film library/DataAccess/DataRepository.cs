using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_library.DataAccess
{
    public class DataRepository : IDataRepository

    {
        //Read File Section
        public List<T> Read<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                var objectJson = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<T>>(objectJson);
            }
            return new List<T>();


        }


        //Write Section
        public void Write<T>(string filePath, List<T> objectToWrite)
        {
            var objectJson = JsonConvert.SerializeObject(objectToWrite, Formatting.Indented);
            File.WriteAllText(filePath, objectJson);
        }
     
    }
}
