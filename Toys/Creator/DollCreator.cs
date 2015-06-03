using System.Collections.Generic;
using Newtonsoft.Json;
using Toys.AllToys;

namespace Toys.Creator
{
    public class DollCreator:ToyCreator
    {
        public override MainToy FactoryMethod(List<string> properties)
        {
            Doll doll = new Doll();
            doll.Name = properties[0];
            doll.AgeChild = properties[1];
            doll.HardLevel = properties[2];
            doll.Size = properties[3];
            doll.Material = properties[4];
            return doll;
        }
        public override MainToy FactoryMethodDeserialiaze(ref JsonSerializer json,ref JsonReader breader)
        {
            Doll Object = json.Deserialize<Doll>(breader);
            return Object;
        }
    }
}
