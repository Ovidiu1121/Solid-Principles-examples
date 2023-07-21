using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._4
{
    public class debug
    {
        public debug()
        {
            //Using HPLaserJetPrinter we can access all Printer Services
            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
            hPLaserJetPrinter.Print("Printing");
            hPLaserJetPrinter.Scan("Scanning");
            hPLaserJetPrinter.Fax("Faxing");
            hPLaserJetPrinter.PrintDuplex("PrintDuplex");
            //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
            LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
            liquidInkjetPrinter.Print("Printing");
            liquidInkjetPrinter.Scan("Scanning");
        }

    }
}
