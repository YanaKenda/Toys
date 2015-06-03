using System.Collections.Generic;
using Toys.Fields;

namespace Toys
{
    public  static class PropertyFieldsRepository
    {
        private static List<FieldsForm> listField = new List<FieldsForm>()
        {
            new BearFields(),
            
            new CarFields(),
            
            new DollFields(),
            
            new PlainFields(),
            
            new SoldierFields(),
            
            new WhirligigFields(),
        };


        public static List<FieldsForm> ListFields
        {
            get { return listField; }
        }
    }
}
