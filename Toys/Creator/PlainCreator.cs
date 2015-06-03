using System.Collections.Generic;
using Newtonsoft.Json;

namespace Toys.AllToys
{
    public class PlainCreator: ToyCreator
    {
        public override MainToy FactoryMethod(List<string> properties)
        {
            Plain plain = new Plain();
            plain.Name = properties[0];
            plain.AgeChild = properties[1];
            plain.HardLevel = properties[2];
            plain.MaxHeight = properties[3];
            plain.KindControl = properties[4];
            return plain;
        }
        public override MainToy FactoryMethodDeserialiaze(ref JsonSerializer json, ref JsonReader breader)
        {
            Plain Object = json.Deserialize<Plain>(breader);
            return Object;
        }
    }
}
