using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBC1
{
    public class LoggerTheFirst : ILogger
    {
        public void PrintMessage()
        {
            Console.WriteLine("LoggerTheFirst Creating Admin Successfull!");
            Console.WriteLine("****");
        }
    }
}
