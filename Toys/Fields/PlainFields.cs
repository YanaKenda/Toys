namespace Toys.Fields
{
    public class PlainFields: FieldsForm
    {
        public override string[] LabelName
        {
            get { return new string[] { "Максимальная высота подъема", "Вид пульта управления" }; }
        }

        public override string[,] ComboboxName
        {

            get
            {
                return new string[,]
            {
                {"1 м", "2 м", "3 м"},{"руль", "джойстик","сенсор"} };
            }
        }
    }
}
