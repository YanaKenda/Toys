using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    public abstract class ToyEditingCreator
    {
        public abstract MainToy FactoryMethod(MainToy mainToy, List<string> properties);
    }

}
