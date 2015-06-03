using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{

    public abstract class ToyCreator
    {
        public abstract MainToy FactoryMethod(List<string> properties);
        public abstract MainToy FactoryMethodDeserialiaze(ref JsonSerializer json, ref JsonReader breader);
    }
}
