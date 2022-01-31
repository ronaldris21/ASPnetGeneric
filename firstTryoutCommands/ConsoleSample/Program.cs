// See https://aka.ms/new-console-template for more information

using System.Net;
using System;
using Newtonsoft.Json;

namespace ConsoleSample
{
    public class Program
    {
        
        public static  void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");

            string API_URL = "https://jsonplaceholder.typicode.com/posts?_limit=10";
            var client = new WebClient();
            string json = client.DownloadString(API_URL);
            //System.Console.WriteLine(json);
            dynamic posts  = JsonConvert.DeserializeObject(json);
            foreach(var post in posts)
            {
                System.Console.WriteLine(post.id + " - " + post.title);
            }
            Console.ReadKey();
        }
        
    }
    
}
