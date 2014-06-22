using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLSample
{
    public class XLinqSample
    {
        public void Run()
        {
            XDocument document = XDocument.Load("configuration.xml");
            Console.WriteLine(document.Root.Name);
            foreach (XElement element in document.Root.Element("SubConfigurations").Elements())
            {
                XAttribute timestamp = element.Attribute("Timestamp");

                Console.WriteLine("\t{0} ({1})", element.Name, timestamp != null ? timestamp.Value : "-");

                if (element.Name == "DBConfiguration")
                {
                    Console.WriteLine("\t\t{0}", element.Element("DBServerHost").Value);
                }
            }
        }
    }
}
