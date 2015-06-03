using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toys;

namespace Plugin
{
    public class NewConstructorCreator: ToyCreator
    {
        public override MainToy FactoryMethod(List<string> properties)
        {
            NewConstructor newConstructor = new NewConstructor();
            newConstructor.Name = properties[0];
            newConstructor.AgeChild = properties[1];
            newConstructor.HardLevel = properties[2];
            newConstructor.Type = properties[3];
            return newConstructor;
        }
        public override MainToy FactoryMethodDeserialiaze(ref JsonSerializer json, ref JsonReader breader)
        {
            NewConstructor Object = json.Deserialize<NewConstructor>(breader);
            return Object;
        }
    }
}
