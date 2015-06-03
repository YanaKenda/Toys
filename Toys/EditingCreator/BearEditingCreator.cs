using System.Collections.Generic;
using Toys;
using Toys.AllToys;

namespace Toy
{
    public class BearEditingCreator: DollEditingCreator
    {
        public override MainToy FactoryMethod(MainToy mainToy, List<string> properties)
        {
            Bear obj = (Bear)mainToy;
            properties.Add(obj.Name);
            properties.Add(obj.AgeChild);
            properties.Add(obj.HardLevel);
            properties.Add(obj.Material);
            properties.Add(obj.Size);
            properties.Add(obj.Color);
            return obj;
        }
    }
}
