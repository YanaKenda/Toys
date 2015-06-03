using System.Collections.Generic;

namespace Toys
{
    public  class ListRepository
    {
        private List<MainToy> list = new List<MainToy>()
        {

        };

        public List<MainToy> List
        {
            get { return list; }
            set { list = value; }
        }
    }

}
