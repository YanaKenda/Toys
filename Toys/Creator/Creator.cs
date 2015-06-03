using System.Collections.Generic;
using Toys.AllToys;

namespace Toys.Creator
{
    public static class Creator
    {
        private static List<ToyCreator> toy = new List<ToyCreator>
        {
            new BearCreator(),
            new CarCreator(),
            new DollCreator(),
            new PlainCreator(),
            new SoldierCreator(),
            new WhirligigCreator()
        };

        public static List<ToyCreator> CurrentToy
        {
            get { return toy; }
        }
    }

}
