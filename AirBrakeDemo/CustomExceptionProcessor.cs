using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBrakeDemo
{
    public class CustomExceptionProcessor
    {
        public void CreateCustomException()
        {
            try
            {
                Console.WriteLine("\nrunning custom exception method......");
                Console.WriteLine("\n creating custom exception");
                throw new Exception("new custom exception");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void CustomExceptionWithFilter()
        {
            try
            {
                Console.WriteLine("\nrunning system exception method......");
                Console.WriteLine();
                Console.WriteLine("creating custom exception");
                throw new Exception("new exception with filter");
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
