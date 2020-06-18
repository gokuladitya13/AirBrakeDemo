using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBrakeDemo
{
    public class Processor
    {
        public void CreateProcess()
        {
			try
			{
				SystemExceptionProcessor syspros = new SystemExceptionProcessor();
				syspros.SystemException();

				CustomExceptionProcessor cuspros = new CustomExceptionProcessor();
				cuspros.CreateCustomException();
				cuspros.CustomExceptionWithFilter();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
