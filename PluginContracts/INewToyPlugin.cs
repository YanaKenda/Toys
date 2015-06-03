using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Toys;
namespace PluginContracts
{
    public interface INewToyPlugin
    {
        string NameToy { get; }
        FieldsForm Fields { get; }

        ToyEditingCreator ToyEditingCreator { get; }

        ToyCreator ToyCreator { get; }

    }
}