using System.Collections.Generic;
using Newtonsoft.Json;
using Toys.AllToys;

namespace Toys.Creator
{
    public class WhirligigCreator: ToyCreator
    {
        public override MainToy FactoryMethod(List<string> properties)
        {
            Whirligig whirligig = new Whirligig();
            whirligig.Name = properties[0];
            whirligig.AgeChild = properties[1];
            whirligig.HardLevel = properties[2];
            whirligig.Type = properties[3];
            whirligig.Material = properties[4];
            whirligig.CountFacet = properties[5];
            return whirligig;
        }

        public override MainToy FactoryMethodDeserialiaze(ref JsonSerializer json, ref JsonReader breader)
        {
            Whirligig Object = json.Deserialize<Whirligig>(breader);
            return Object;
        }
    }
}
