namespace Toys.Fields
{
    public class BearFields: FieldsForm
    {
        public override string[] LabelName
        {
            get { return new string[] { "Размер", "Цвет", "Материал" }; }
        }

        public override string[,] ComboboxName
        {

            get
            {
                return new string[,]
            {
                {"маленький", "средний", "большой"},{"черный", "коричневый","белый"},{"плюш", "дерево","ткань"} };
            }
        }
    }
}
