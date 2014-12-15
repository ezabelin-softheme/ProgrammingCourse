using System;

namespace StaticExercise1
{
    class Book
    {
        public string Name{ get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public ushort PagesValue { get; set; }
        
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public class Notes 
        {
           private readonly DateTime _creatingDate;
           
           public Notes(string title, string summary) 
           {
               _creatingDate = DateTime.Now;
               Title = title;
               Summary = summary;
           }

           public DateTime CreatingDate 
           {
               get { return _creatingDate; }
           }

           public string Title { get; set; }
           public string Summary { get; set; }

           public void PrintNoteInfo()
           {
               Console.WriteLine("Note info: \nTitle - {0}\nContent - {1}\nDate of creating - {2}\n", Title, Summary, CreatingDate);
           }
        }

        public void PrintBookInfo()
        {
            Console.WriteLine("Book info: \nName - {0}\nAuthor - {1}\nGenre - {2}\nPages - {3}\n", Name, Author, Genre, PagesValue);
        }
    }
}
