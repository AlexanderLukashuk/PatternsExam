namespace PatternsExam
{
    public abstract class CarWash
    {
        public int BoxNumber { get; set; }
        public string WasherName { get; }
        public string CarCategory { get; }
    }

    public class PassengersCarBox : CarWash
    {
        public static int PassengersCarBoxCount = 0;
    }

    public class TrucksCarBox : CarWash
    {
        public static int TrucksCarBoxCount = 0;
    }

    public class PassengersCar : PassengersCarBox
    {
    }

    public class TrucksCar : TrucksCarBox
    {

    }
}