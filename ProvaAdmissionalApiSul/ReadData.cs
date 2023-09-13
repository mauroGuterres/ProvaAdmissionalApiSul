using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProvaAdmissionalApiSul
{
   public class ReadData
    {
        public List<Informacao> readJsonFile(string fileName) {
            var filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string jsonFromFile;
            using (var reader = new StreamReader(filePath)) {
                jsonFromFile = reader.ReadToEnd();
            }
            var info = JsonConvert.DeserializeObject<List<Informacao>>(jsonFromFile);
            return info;
            
        }
    }
}
