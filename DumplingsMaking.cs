using System;

namespace PatternsExam
{
    public abstract class DumplingsMaking
    {
        public abstract string Name { get; }
        public abstract void GetName();
        public abstract void AddMeat();
        public abstract void AddDought();
        public abstract void AddSalt();
        public abstract void AddSpices();
        public virtual void GetDumplings()
        {
            Console.WriteLine("Получили готовые пельмени");
        }
    }

    public class MerchantDumplings : DumplingsMaking
    {
        public override string Name
        {
            get
            {
                return "Купеческие пельмени";
            }
        }
        public override void GetName()
        {
            Console.WriteLine("Готовим " + this.Name);
        }
        public override void AddMeat()
        {
            Console.WriteLine("Добавляем мясо");
        }
        public override void AddDought()
        {
            Console.WriteLine("Добавляем тесто");
        }
        public override void AddSalt()
        {
            Console.WriteLine("Добавляем соль");
        }
        public override void AddSpices()
        {
            Console.WriteLine("Добавялем специи");
        }
    }

    public class BavarianDumplings : DumplingsMaking
    {
        public override string Name
        {
            get
            {
                return "Баварские пельмени";
            }
        }
        public override void GetName()
        {
            Console.WriteLine("Готовим " + this.Name);
        }
        public override void AddMeat()
        {
            Console.WriteLine("Добавляем много мяса");
        }
        public override void AddDought()
        {
            Console.WriteLine("Добавляем тесто");
        }
        public override void AddSalt()
        {
            Console.WriteLine("Добавляем соль");
        }
        public override void AddSpices()
        {
            Console.WriteLine("Добавялем много специи");
        }
    }

    public class StudentDumplings : DumplingsMaking
    {
        public override string Name
        {
            get
            {
                return "Студенческие пельмени";
            }
        }
        public override void GetName()
        {
            Console.WriteLine("Готовим " + this.Name);
        }
        public override void AddMeat()
        {
            Console.WriteLine("Добавляем немного мяса");
        }
        public override void AddDought()
        {
            Console.WriteLine("Добавляем тесто");
        }
        public override void AddSalt()
        {
            Console.WriteLine("Добавляем соль");
        }
        public override void AddSpices()
        {
            Console.WriteLine("Добавялем немного специи");
        }
    }
}