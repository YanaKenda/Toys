namespace Toys.Fields
{
    public class CarFields : FieldsForm
    {
        public override string[] LabelName
        {
            get { return new string[] {"Привод", "Вид пульта управления"}; }
        }

        public override string[,] ComboboxName
        {
                
            get
            {
                return new string[,]
            {
                {"передний", "задний", "полноприводной"},{"руль", "джойстик","сенсор"} };
            }
        }
    }
}
