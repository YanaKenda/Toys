namespace Toys.Fields
{
    public class WhirligigFields: FieldsForm
    {
        public override string[] LabelName
        {
            get { return new string[] { "Разновидность", "Материал","Количество граней" }; }
        }

        public override string[,] ComboboxName
        {

            get
            {
                return new string[,]
            {
                {"сакаи", "дрейдл","бери-давай"},{"дерево", "проволока","пластмасса"},{"4", "6",""} };
            }
        }
    }
}
