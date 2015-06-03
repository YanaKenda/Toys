namespace Toys.AllToys
{
    public class Car:MainToy
    {

        private string typeWheels;
        private string kindControl;


         public string TypeWheels
        {
            get { return typeWheels; }
            set { typeWheels = value; }
        }

        public string KindControl
        {
            get { return kindControl; }
            set { kindControl = value; }
        }

        public Car(string hardLevel, string name, string ageChild,string typeWheels,string kindControl)
        {
            HardLevel = hardLevel;
            Name = name;
            AgeChild = ageChild;
            TypeWheels = typeWheels;
            KindControl = kindControl;
        }

        public Car() { }

        public override string GetInfo()
        {
            return string.Format(base.GetInfo() + "Toy:Машинка ; TypeWheels:{0}; KindControl:{1}; ", typeWheels, kindControl);
        }

    }
}
