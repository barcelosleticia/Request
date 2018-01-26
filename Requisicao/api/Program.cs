using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;

namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var request = WebRequest.CreateHttp("https://dev.people.com.ai/bug/api/v3/products");
            request.Method = "GET";
            
            using (var takeRequest = request.GetResponse())
            {
                var information = takeRequest.GetResponseStream();
                StreamReader reader = new StreamReader(information);
                object objRequest = reader.ReadToEnd();
                Console.WriteLine(objRequest.ToString() );  
                Console.ReadLine();
                information.Close();
                takeRequest.Close();
            }
            Console.ReadLine();
        }
    }
}