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

    public class JeepCarBox : CarWash, IBoxCount
    {
        public static int JeepCarBoxCount = 0;

        public void CheckBox()
        {
            if (JeepCarBoxCount <= 4 && JeepCarBoxCount >= 0)
            {
                JeepCarBoxCount++;
            }
        }
    }

    public class PassengersCar : PassengersCarBox
    {
    }

    public class JeepCar : JeepCarBox
    {

    }
}