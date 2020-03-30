using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HostInCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service));
            host.Open();
            Console.WriteLine("Gestartet");
            Console.ReadLine();
            host.Close();
        }
    }
}
