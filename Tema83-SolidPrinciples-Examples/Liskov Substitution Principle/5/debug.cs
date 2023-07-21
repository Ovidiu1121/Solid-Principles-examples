using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Liskov_Substitution_Principle._5
{
    public class debug
    {
        public debug()
        {
            Resource fileResource = new FileResource("document.txt");
            Resource databaseResource = new DatabaseResource("example_db");

            OpenAndCloseResource(fileResource);
            OpenAndCloseResource(databaseResource);
        }
        public static void OpenAndCloseResource(Resource resource)
        {
            resource.Open();
            // Simulăm o operațiune cu resursa deschisă
            Console.WriteLine("Performing operation with the resource open...");
            resource.Close();
        }
    }
}
