namespace Toys.Fields
{
    public class SoldierFields: FieldsForm
    {
        public override string[] LabelName
        {
            get { return new string[] { "Размер", "Материал","Высота" }; }
        }

        public override string[,] ComboboxName
        {

            get
            {
                return new string[,]
            {
                {"маленький", "средний", "большой"},{"олово", "дерево","пластмасса"},{"3 см", "6 см","8 см"} };
            }
        }
    }
}
