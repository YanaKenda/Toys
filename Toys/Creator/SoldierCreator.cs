using System.Collections.Generic;
using Newtonsoft.Json;
using Toys.AllToys;

namespace Toys.Creator
{
    public class SoldierCreator : DollCreator
    {


        public override MainToy FactoryMethod(List<string> properties)
        {
            Soldier soldier = new Soldier();
            soldier.Name = properties[0];
            soldier.AgeChild = properties[1];
            soldier.HardLevel = properties[2];
            soldier.Size = properties[3];
            soldier.Material = properties[4];
            soldier.Height = properties[5];
            return soldier;
        }

        public override MainToy FactoryMethodDeserialiaze(ref JsonSerializer json, ref JsonReader breader)
        {
            Soldier Object = json.Deserialize<Soldier>(breader);
            return Object;
        }
    }
}
