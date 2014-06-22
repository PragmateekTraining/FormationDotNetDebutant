using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSample
{
    [XmlRoot]
    public class Configuration
    {
        [XmlArrayItem(typeof(UIConfiguration))]
        [XmlArrayItem(typeof(NetworkConfiguration))]
        [XmlArrayItem(typeof(DBConfiguration))]
        public List<SubConfiguration> SubConfigurations { get; set; }
    }

    [XmlInclude(typeof(UIConfiguration))]
    [XmlInclude(typeof(NetworkConfiguration))]
    [XmlInclude(typeof(DBConfiguration))]
    public class SubConfiguration
    {
        //[XmlAttribute]
        public DateTime? Timestamp { get; set; }
    }

    public class UIConfiguration : SubConfiguration
    {
        public bool IsFullScreen { get; set; }
    }

    public class NetworkConfiguration : SubConfiguration
    {
        public string ServerAddress { get; set; }
    }

    public class DBConfiguration : SubConfiguration
    {
        public string DBServerHost { get; set; }
        public string DBServerSchema { get; set; }
    }

    public class XMLDataBindingSample
    {
        public void Run()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));

            Configuration config = null;
            using (FileStream stream = File.OpenRead("configuration.xml"))
            {
                config = (Configuration)serializer.Deserialize(stream);
            }

            UIConfiguration UIConfig = (UIConfiguration)config.SubConfigurations[0];
            UIConfig.IsFullScreen = !UIConfig.IsFullScreen;

            using (FileStream stream = File.OpenWrite("configuration.xml"))
            {
                serializer.Serialize(stream, config);
            }
        }
    }
}
