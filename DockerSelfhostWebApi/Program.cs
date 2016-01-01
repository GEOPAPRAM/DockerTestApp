using System;
using System.Reflection;
using System.Configuration;
using Microsoft.Owin.Hosting;

namespace DockerSelfhostWebApi
{
    class Program
    {
        static void Main(string[] args)
        {

            var baseUri = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["BaseUri"]);
            // in debug in visual studio you will need 
            //const string baseUri = "http://localhost:8090";

            Console.WriteLine("Starting web Server...");
            WebApp.Start<Startup>(baseUri);
            Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri);
            Console.WriteLine("I'm running on {0} directly from assembly {1}", Environment.OSVersion, Assembly.GetEntryAssembly().FullName);
            Console.ReadLine();
        }
    }
}
