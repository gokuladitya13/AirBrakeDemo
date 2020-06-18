using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBrakeDemo
{
    class SystemExceptionProcessor
    {
        public void SystemException()
        {
            try
            {
                Console.WriteLine("running system exception method......");
                Console.WriteLine();
                int a = 0;
                int b = 100 / a;
            }
            catch (Exception ex)
            {

                throw ex;

            }

        }
    }
}
