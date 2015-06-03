using System.Collections.Generic;

namespace Toys.Repository
{
    public static class ListToy
    {
        private static List<object> listToy = new List<object>()
        {
            "Медведь","Машинка","Кукла","Самолет","Солдатик","Волчок"
        };


        public static List<object> ListToys
        {
            get { return listToy; }
        }

    }
}
