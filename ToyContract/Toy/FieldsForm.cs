using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    public abstract class FieldsForm
    {
        public abstract string[] LabelName { get; }
        public abstract string[,] ComboboxName { get; }
    }
}
