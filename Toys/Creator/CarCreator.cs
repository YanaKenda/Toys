using System.Collections.Generic;
using Newtonsoft.Json;

namespace Toys.AllToys
{
    public class CarCreator: ToyCreator
    {
        public override MainToy FactoryMethod(List<string> properties)
        {
            Car car = new Car();
            car.Name = properties[0];
            car.AgeChild = properties[1];
            car.HardLevel = properties[2];
            car.TypeWheels = properties[3];
            car.KindControl = properties[4];
            return car;
        }
        public override MainToy FactoryMethodDeserialiaze(ref JsonSerializer json, ref JsonReader breader)
        {
            Car Object = json.Deserialize<Car>(breader);
            return Object;
        }
    }
}
