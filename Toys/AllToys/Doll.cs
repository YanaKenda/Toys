namespace Toys.AllToys
{
    public class Doll : MainToy
    {

        private string material;
        private string size;


         public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public Doll(string hardLevel, string name, string ageChild,string size,string material)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
            Material = material;
            Size = size;
        }

        public Doll() { }

        public override string GetInfo()
        {
            return string.Format(base.GetInfo() + "Toy:Кукла ; Size:{0}; Material:{1}; ", size, material);
        }

    }
}
