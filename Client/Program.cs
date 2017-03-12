using Client.ZTBDService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IZTBDService s = new ZTBDServiceClient();
            using (var total_cpu = new PerformanceCounter("Process", "% Processor Time", "_Total"))
            {
                using (var ramCounter = new PerformanceCounter("Memory", "Available MBytes"))
                {
                    while (true)
                    {
                        var data = Collect(ramCounter, total_cpu);
                        s.InsertDataAsync(data);
                        Console.WriteLine(data);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public static Data Collect(PerformanceCounter ramCounter, PerformanceCounter totalCpu)
        {
            User user = new User
            {
                PcName = Environment.MachineName,
                UserName = Environment.UserName,
                MAC = GetMACAddress(),
                Ip = GetIP()
            };

            ComputerUsage cu = new ComputerUsage
                {
                    CPU = totalCpu.NextValue(),
                    RAM = ramCounter.NextValue()
                };
            

            Data data = new Data
            {
                ComputerUsage = cu,
                User = user,
                Date = DateTime.Now
            };

            return data;
        }

        public static string GetMACAddress()
        {

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    //sMacAddress += adapter.Name+"\n";// GetPhysicalAddress().ToString();
                    sMacAddress += adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        public static string GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            string ips = string.Empty;
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ips += ip.ToString() + " ";
                }
            }
            return ips;
        }
    }
}
