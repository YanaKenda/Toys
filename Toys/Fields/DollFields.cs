namespace Toys.Fields
{
    public class DollFields: FieldsForm
    {
        public override string[] LabelName
        {
            get { return new string[] { "Размер", "Материал" }; }
        }

        public override string[,] ComboboxName
        {

            get
            {
                return new string[,]
            {
                {"маленький", "средний", "большой"},{"фарфор", "синтетика","ткань"} };
            }
        }
    }
}
