using Sharpbrake.Client;
using Sharpbrake.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBrakeDemo
{
    class Program
    {
        static AirbrakeNotifier airbrake;
        public Program()
        {
            airbrake = new AirbrakeNotifier(new AirbrakeConfig
            {
                ProjectId = "278011",
                ProjectKey = "2ec6156676eeb0b9737cae0eae40a1e9",
                LogFile = "airbrake.log",
                Environment = "dev"
            });
        }
        static void Main(string[] args)
        {
            try
            {
                Program obj = new Program();
                Processor pro = new Processor();
                pro.CreateProcess();
                
            }
            catch (Exception ex)
            {
                Notice notice = airbrake.BuildNotice(ex);
                var response = airbrake.NotifyAsync(notice).Result;
                Console.WriteLine("exception logged in airbarke dashboard");
                Console.WriteLine("Status: {0}, Id: {1}, Url: {2}", response.Status, response.Id, response.Url);
                Console.WriteLine(ex);
            }
            
            
            Console.ReadKey();
        }
        
    }
}
