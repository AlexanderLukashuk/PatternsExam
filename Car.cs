namespace PatternsExam
{
    public interface IDrive
    {
        void Drive();
    }

    public interface IRepair
    {
        
    }

    public abstract class Car
    {
        public string carBrand;
        public int price;
        public string color;

    }
}