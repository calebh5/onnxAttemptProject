using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using onnxAttemptProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onnxAttemptProject
{
    public class Program
    {
        static string ONNX_MODEL_PATH = "decision_tree_cleaned.onnx";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://0.0.0.0:8000");
                });

    }
}
