namespace PatternsExam
{
    public interface IBoxCount
    {
        void CheckBox();
    }
    public abstract class CarWash
    {
        public int BoxNumber { get; set; }
        public string WasherName { get; }
        public string CarCategory { get; }
    }

    public class PassengersCarBox : CarWash, IBoxCount
    {
        public static int PassengersCarBoxCount = 0;

        public void CheckBox()
        {
            if (PassengersCarBoxCount <= 6 && PassengersCarBoxCount >= 0)
            {
                PassengersCarBoxCount++;
            }
        }
    }

    public class TrucksCarBox : CarWash, IBoxCount
    {
        public static int TrucksCarBoxCount = 0;

        public void CheckBox()
        {
            if (TrucksCarBoxCount <= 4 && TrucksCarBoxCount >= 0)
            {
                TrucksCarBoxCount++;
            }
        }
    }

    public class PassengersCar : PassengersCarBox
    {
    }

    public class TrucksCar : TrucksCarBox
    {

    }
}