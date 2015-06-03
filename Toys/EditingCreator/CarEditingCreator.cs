using System.Collections.Generic;
using Toys.AllToys;

namespace Toys
{
    class CarEditingCreator: ToyEditingCreator
    {
        public override MainToy FactoryMethod(MainToy mainToy, List<string> properties)
        {
            Car obj = (Car)mainToy;
            properties.Add(obj.Name);
            properties.Add(obj.AgeChild);
            properties.Add(obj.HardLevel);
            properties.Add(obj.TypeWheels);
            properties.Add(obj.KindControl);
            return obj;
        }
    }
}
