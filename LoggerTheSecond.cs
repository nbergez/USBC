using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBC1
{
    public class LoggerTheSecond : ILogger
    {
        public void PrintMessage()
        {
            Console.WriteLine("LoggerTheSecond has made an Admin Object!!!!");
            Console.WriteLine("%%%%");    
        }
    }
}
