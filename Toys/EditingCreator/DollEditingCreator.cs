using System.Collections.Generic;
using Toys.AllToys;

namespace Toys
{
    public class DollEditingCreator: ToyEditingCreator
    {
        public override MainToy FactoryMethod(MainToy mainToy, List<string> properties)
        {
            Doll obj = (Doll)mainToy;
            properties.Add(obj.Name);
            properties.Add(obj.AgeChild);
            properties.Add(obj.HardLevel);
            properties.Add(obj.Material);
            properties.Add(obj.Size);
            return obj;
        }
    }
}
