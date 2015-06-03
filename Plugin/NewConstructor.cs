using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toys;

namespace Plugin
{
    public class NewConstructor: MainToy
    {

        private string type;


         public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public NewConstructor(string hardLevel, string name, string ageChild,string type)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
            Type = type;
        }

        public NewConstructor() { }

        public override string GetInfo()
        {
            return string.Format(base.GetInfo() + "Toy:Конструктор ; Type:{0}; ", type);
        }

    }
}
