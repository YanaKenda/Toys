using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toys.AllToys;

namespace Toys.Repository
{
    class ToyTypesRepository
    {
        private static List<Type> Types = new List<Type>
        {
            typeof(Bear),
            typeof(Car),
            typeof(Doll),
            typeof(Plain),
            typeof(Soldier),
            typeof(Whirligig)
        };

        public static List<Type>  ListTypesToys
        {
            get { return Types; }
        }
    }
}
