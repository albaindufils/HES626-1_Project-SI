using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfServiceCustom;

namespace TestWebServiceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomService client = new CustomService();

            // Use the 'client' variable to call operations on the service.
            Console.WriteLine(client.GetUid());
            Console.WriteLine(client.GetShortGuid());

            System.Threading.Thread.Sleep(10000); // pour pouvoir voir la fenêtre
        }
    }
}
