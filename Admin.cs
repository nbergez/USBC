using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBC1
{
    public class Admin
    {
        public ILogger Logger { get; set; }

        public Admin(ILogger logger)
        {
            Logger = logger;
        }

        public void LogCreation()
        {
            Logger.PrintMessage();
        }
    }
}
