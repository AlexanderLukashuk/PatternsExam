using System;

namespace PatternsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 задание
            DumplingsMaking dumplings = new BavarianDumplings();
            dumplings.Make();
            dumplings = new StudentDumplings();
            dumplings.Make();
        }
    }
}
