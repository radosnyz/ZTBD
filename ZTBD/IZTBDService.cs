using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZTBD
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IZTBDService
    {
        [OperationContract]
        void InsertData(Data data);

        [OperationContract]
        List<Data> GetData();
    }

    [DataContract]
    public class Data
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public Temperature Temperature { get; set; }

        [DataMember]
        public User User { get; set; }

        [DataMember]
        public ComputerUsage ComputerUsage { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: \nUSER: {1} \nComputerUsage: {2} \nTemperature: {3}\n\n", Date, User, ComputerUsage, Temperature);
        }
    }

    [DataContract]
    public class Temperature
    {
        [DataMember]
        public int CPU { get; set; }
        [DataMember]
        public int GPU { get; set; }

        public override string ToString()
        {
            return string.Format("CPU: {0} GPU: {1}", CPU, GPU);
        }
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Ip { get; set; }
        [DataMember]
        public string MAC { get; set; }
        [DataMember]
        public string PcName { get; set; }
        [DataMember]
        public string UserName { get; set; }

        public override string ToString()
        {
            return string.Format("PC: {0} User: {1} IP: {2} MAC: {3}", PcName, UserName, Ip, MAC);
        }
    }

    [DataContract]
    public class ComputerUsage
    {
        [DataMember]
        public double RAM { get; set; }
        [DataMember]
        public double CPU { get; set; }

        public override string ToString()
        {
            return string.Format("RAM: {0} CPU: {1}", RAM, CPU);
        }
    }
}
