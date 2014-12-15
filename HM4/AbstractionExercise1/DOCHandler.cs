using System;

namespace AbstractionExercise1
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC document has been opened");
        }

        public override void Create()
        {
            Console.WriteLine("DOC document has been created");
        }

        public override void Change()
        {
            Console.WriteLine("DOC document has been changed");
        }

        public override void Save()
        {
            Console.WriteLine("DOC document has been saved");
        }
    }
}
