using System;

namespace StaticExercise1
{
    class Program
    {
        static void Main()
        {
            Book firstBook = new Book("Under the dome", "Steven King");
            firstBook.Genre = "Horror";
            firstBook.PagesValue = 698;

            Book.Notes firstNote = new Book.Notes("Who is Burbey?", "Read one more time chapter 3");

            firstBook.PrintBookInfo();
            firstNote.PrintNoteInfo();

            Console.ReadKey();
        }
    }
}
