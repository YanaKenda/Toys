using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    public abstract class MainToy
    {

        private string ageChild;
        private string hardLevel;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AgeChild
        {
            get { return ageChild; }
            set { ageChild = value; }
        }

        public string HardLevel
        {
            get { return hardLevel; }
            set { hardLevel = value; }
        }

        public MainToy(string hardLevel, string name, string ageChild)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
        }

        public MainToy() { }


        public virtual string GetInfo()
        {
            return string.Format("Name:{0}; HardLevel:{1}; AgeChild:{2} ", Name, HardLevel, AgeChild);
        }
    }
}
