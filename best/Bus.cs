using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace best
{
    class Bus
    {
        public string numberplate;
        public string line;
        public string startpoint;
        public string destination;
        public int number;

        public void StartTheEngine()
        {
            Console.WriteLine("公交车启动");
        }
        public void Driving()
        {
            Console.WriteLine("正在行驶");
        }
        public void Stop()
        {
            Console.WriteLine("公交车停止");
        }
    }
}
