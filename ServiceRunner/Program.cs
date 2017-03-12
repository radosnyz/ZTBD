
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ZTBD;

namespace ServiceRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8989/ztbd");
            using (ServiceHost selfHost = new ServiceHost(typeof(ZTBDService), baseAddress))
            {
                try
                {
                    // Step 3 Add a service endpoint.  
                    selfHost.AddServiceEndpoint(typeof(IZTBDService), new BasicHttpBinding(), "BasicHttpBinding_IZTBDService");

                    // Step 4 Enable metadata exchange.  
                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;
                    selfHost.Description.Behaviors.Add(smb);
                    
                    // Step 5 Start the service.  
                    selfHost.Open();
                    Console.WriteLine("Service enpoint: {0}", baseAddress);
                    Console.WriteLine("The service is ready.");
                    Console.WriteLine("Press <ENTER> to terminate service.");
                    Console.WriteLine();
                    Console.ReadLine();

                    // Close the ServiceHostBase to shutdown the service.  
                    selfHost.Close();
                }
                catch (CommunicationException ce)
                {
                    Console.WriteLine("An exception occurred: {0}", ce.Message);
                    selfHost.Abort();
                }
            }
        }
    }
}
