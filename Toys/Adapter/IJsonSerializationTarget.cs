using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonSerializationPlugin;
namespace Toys.Adapter
{

    interface IJsonSerializationTarget
    {
        string SerializeToJson(string fileName);
        void SerializeToXml(Type type, Type[] typesToInclude, string fileName, ListRepository ListToy);
    }
}
