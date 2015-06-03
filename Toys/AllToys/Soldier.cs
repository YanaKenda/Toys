namespace Toys.AllToys
{
    public class Soldier:Doll
    {
        private string height;

        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        public Soldier(string hardLevel, string name, string ageChild,string size,string material,string height)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
            Material = material;
            Size = size;
            Height = height;
        }

        public Soldier()
        {
        }

        public override string GetInfo()
        {
            return string.Format(base.GetInfo() + "Toy:Солдатик ; Height:{0}; ", height);
        }
    }
}
