using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();


        public static Log InLog
        {
            get
            {
                return _instance;
            }
        }
        private Log()
        {

        }

        private string _path = "log.txt";

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
