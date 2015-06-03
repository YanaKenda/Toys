using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonSerializationPlugin;
using System.Xml.Serialization;
using System.IO;
namespace Toys.Adapter
{

    class JsonSerializationAdapter : IJsonSerializationTarget
    {
        private ISerializationPlugin ToJsonAdaptee;

        public JsonSerializationAdapter(ISerializationPlugin Tojson)
        {
            ToJsonAdaptee = Tojson;
        }

        public string SerializeToJson(string fileName)
        {
            return ToJsonAdaptee.TransformXmlToJson(fileName);
        }
        public void SerializeToXml(Type type, Type[] typesToInclude, string fileName, ListRepository ListToy)
        {
            XmlSerializer serializer = new XmlSerializer(type, typesToInclude);
            StreamWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, ListToy.List);
            writer.Close();
        }


    }

}
