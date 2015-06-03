using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toys;

namespace Plugin
{
     public class NewConstructorFields: FieldsForm
    {
        public override string[] LabelName
        {
            get { return new string[] { "Тип"}; }
        }

        public override string[,] ComboboxName
        {

            get
            {
                return new string[,]
            {
                {"лего", "кубики", "магниты"} };
            }
        }
    }
}
