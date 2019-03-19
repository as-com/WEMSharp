using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMSharp;

namespace WEMSharpTests
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: wemsharp.exe <helper file> <input file> <output file>");
                return;
            }
            WEMFile wem = new WEMFile(args[1], WEMForcePacketFormat.NoForcePacketFormat);
            wem.GenerateOGG(args[2], args[0], false, false);
        }
    }
}
