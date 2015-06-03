namespace Toys.AllToys
{
    public class Bear:Doll
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Bear(string hardLevel, string name, string ageChild,string size,string material,string color)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
            Material = material;
            Size = size;
            Color = color;
        }

        public Bear()
        {
        }
        public override string GetInfo()
        {
            return string.Format(base.GetInfo() + "Toy:Медведь ; Color:{0}; ", color);
        }
    }
}
