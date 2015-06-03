using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginContracts;
using Toys;

namespace Plugin
{
    public class NewConstructorPlugin : INewToyPlugin
    {
        public string NameToy
        {
            get { return "Конструктор"; }
        }

        public FieldsForm Fields
        {
            get { return new NewConstructorFields(); }
        }


        public ToyCreator ToyCreator
        {
            get { return new NewConstructorCreator(); }
        }

        public ToyEditingCreator ToyEditingCreator
        {
            get { return new NewConstructorEditingCreator(); }
        }
    }
}
