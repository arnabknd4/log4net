using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net_sample_app
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Info("Hello logging world!");
            Console.WriteLine("Hit enter");
            try
            {
                var a = 100;
                var b = 0;
                var c = a / b;
            }
            catch (Exception ex)
            {
                log.Error("=== Error Occured ===\n",ex);
                throw;
            }
            Console.ReadLine();
        }
    }
}
