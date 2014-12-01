using System;

namespace ClassesExercise8
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ октрыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
