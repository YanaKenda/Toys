namespace Toys.AllToys
{
    public class Plain:MainToy
    {

        private string maxHeight;
        private string kindControl;


         public string MaxHeight
        {
            get { return maxHeight; }
            set { maxHeight = value; }
        }

        public string KindControl
        {
            get { return kindControl; }
            set { kindControl = value; }
        }

        public Plain(string hardLevel, string name, string ageChild,string maxHeight,string kindControl)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
            MaxHeight = maxHeight;
            KindControl = kindControl;
        }

        public Plain() { }

        public override string GetInfo()
        {
            return string.Format(base.GetInfo() + "Toy:Самолет ; MaxHeight:{0}; KindControl:{1}; ", maxHeight, kindControl);
        }

    }
}
