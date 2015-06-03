using System.Collections.Generic;
using Newtonsoft.Json;
using Toys.AllToys;

namespace Toys.Creator
{
    public class BearCreator: DollCreator
    {
        public override MainToy FactoryMethod(List<string> properties)
        {
            Bear bear = new Bear();
            bear.Name = properties[0];
            bear.AgeChild = properties[1];
            bear.HardLevel = properties[2];
            bear.Size = properties[3];
            bear.Color = properties[4];
            bear.Material = properties[5];
            return bear;
        }
        public override MainToy FactoryMethodDeserialiaze(ref JsonSerializer json, ref JsonReader breader)
        {
            Bear Object = json.Deserialize<Bear>(breader);
            return Object;
        }
    }
}
