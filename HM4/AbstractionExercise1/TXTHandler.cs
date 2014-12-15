using System;

namespace AbstractionExercise1
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML document has been opened");
        }

        public override void Create()
        {
            Console.WriteLine("XML document has been created");
        }

        public override void Change()
        {
            Console.WriteLine("XML document has been changed");
        }

        public override void Save()
        {
            Console.WriteLine("XML document has been saved");
        }
    }
}
