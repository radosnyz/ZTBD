using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ZTBD.Db;

namespace ZTBD
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class ZTBDService : IZTBDService
    {
        public List<Data> GetData()
        {
            return MongoDBClient.MongoDbClient.GetData();
        }        

        public void InsertData(Data data)
        {
            System.Diagnostics.Trace.WriteLine(data);
            MongoDBClient.MongoDbClient.InsertData(data);
        }
    }

}
