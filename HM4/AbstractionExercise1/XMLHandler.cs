using System;

namespace AbstractionExercise1
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT document has been opened");
        }

        public override void Create()
        {
            Console.WriteLine("TXT document has been created");
        }

        public override void Change()
        {
            Console.WriteLine("TXT document has been changed");
        }

        public override void Save()
        {
            Console.WriteLine("TXT document has been saved");
        }
    }
}
