using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Program
    {
        static void Main(string[] args)
        {
            //schrijf hier je code

            ViewController viewController = new ViewController();
            String level = viewController.startUpScreen();
            ReadTextClass rtc = new ReadTextClass();
            rtc.readTxtFile(level);
            Console.ReadKey();
        }
    }
}
