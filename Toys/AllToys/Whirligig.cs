namespace Toys.AllToys
{
    public class Whirligig:MainToy
    {

        private string material;
        private string type;
        private string countFacets;

         public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string CountFacet
        {
            get { return countFacets; }
            set { countFacets = value; }
        }

        public Whirligig(string hardLevel, string name, string ageChild,string size,string material,string countFacets)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
            Material = material;
            Type = type;
            CountFacet = countFacets;

        }

        public Whirligig() { }

        public override string GetInfo()
        {
            return string.Format(base.GetInfo() + "Toy:Волчок ; Type:{0}; Material:{1}; CountFacet:{2}; ", type, material, countFacets);
        }
    }
}
