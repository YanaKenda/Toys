using System.Collections.Generic;
using Toy;

namespace Toys.Repository
{
    public static class EditingCreatorRepository
    {
        private static List<ToyEditingCreator> list = new List<ToyEditingCreator>()
        {
            new BearEditingCreator(),
            new CarEditingCreator(),
            new DollEditingCreator(),
            new PlainEditingCreator(),
            new SoldierEditingCreator(),
            new WhirligigEditingCreator()
        };

        public static List<ToyEditingCreator> GetListEditingToy
        {
            get { return list; }
        }
    }
}
