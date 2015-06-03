using System.Collections.Generic;
using Toys.AllToys;

namespace Toys
{
    public class SoldierEditingCreator : DollEditingCreator
    {
        public override MainToy FactoryMethod(MainToy toy, List<string> properties)
        {
            Soldier obj = (Soldier)toy;
            properties.Add(obj.Name);
            properties.Add(obj.AgeChild);
            properties.Add(obj.HardLevel);
            properties.Add(obj.Material);
            properties.Add(obj.Size);
            properties.Add(obj.Height);
            return obj;
        }
    }


}
