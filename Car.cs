using System;

namespace PatternsExam
{
    public interface IDrive
    {
        void Drive();
    }

    public interface IRepair
    {
        void Repair(Car car);
    }

    public abstract class ServiceStantionRepair : IRepair
    {
        public virtual void Repair(Car car)
        {
            Console.WriteLine(car.GetName() + "ремонтируется на СТО");
        }
    }

    public abstract class DIYRepair : IRepair
    {
        public virtual void Repair(Car car)
        {
            Console.WriteLine(car.GetName() + "ремонтируется самостоятельно");
        }
    }

    public abstract class OfficialRepair : IRepair
    {
        public virtual void Repair(Car car)
        {
            Console.WriteLine(car.GetName() + "ремонтируется у официалов");
        }
    }

    public abstract class Car : IDrive
    {
        protected string Name { get; set; }
        protected string CarBrand { get; set; }
        protected int Price { get; set; }
        protected string Color { get; set; }
        protected string CarType { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Машина едет");
        }

        public string GetName()
        {
            return Name;
        }

        public string GetCarBrand()
        {
            return CarBrand;
        }

        public int GetPrice()
        {
            return Price;
        }

        public string GetColor()
        {
            return Color;
        }
    }

    public class Passengers : Car
    {
        public Passengers()
        {
            this.CarType = "Легковая";
        }
    }

    public class Truck : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Грузовик едет");
        }
    }

    public class Minivan : Passengers
    {
        public override void Drive()
        {
            Console.WriteLine("Минивэн едет");
        }
    }

    public class Jeep : Passengers
    {
        public override void Drive()
        {
            Console.WriteLine("Джип едет");
        }
    }

    public class Sedan : Passengers
    {
        public override void Drive()
        {
            Console.WriteLine("Седан едет");
        }
    }

    public class Bus : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Автобус едет");
        }
    }
}