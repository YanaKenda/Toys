using System.Collections.Generic;
using Toys.AllToys;

namespace Toys
{
    class WhirligigEditingCreator: ToyEditingCreator
    {
        public override MainToy FactoryMethod(MainToy mainToy, List<string> properties)
        {
            Whirligig obj = (Whirligig)mainToy;
            properties.Add(obj.Name);
            properties.Add(obj.AgeChild);
            properties.Add(obj.HardLevel);
            properties.Add(obj.Material);
            properties.Add(obj.Type);
            properties.Add(obj.CountFacet);
            return obj;
        }
    }
}
