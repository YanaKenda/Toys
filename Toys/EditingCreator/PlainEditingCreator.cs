using System.Collections.Generic;
using Toys.AllToys;

namespace Toys
{
    class PlainEditingCreator: ToyEditingCreator
    {
        public override MainToy FactoryMethod(MainToy mainToy, List<string> properties)
        {
            Plain obj = (Plain)mainToy;
            properties.Add(obj.Name);
            properties.Add(obj.AgeChild);
            properties.Add(obj.HardLevel);
            properties.Add(obj.MaxHeight);
            properties.Add(obj.KindControl);
            return obj;
        }
    }
}
