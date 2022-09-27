using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book
    {
        public Title title;
        public Author author;
        public Content content;

        public Book (string title, string author, string content)
        {
            this.title = new Title { value = title };
            this.author = new Author { value = author };
            this.content = new Content { value = content };
        }

        public class Title
        {
            public string value;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"=== {value} ===");
                Console.ResetColor();
            }
        }
        public class Author
        {
            public string value;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Author: {value}");
                Console.ResetColor();
            }
        }
        public class Content
        {
            public string value;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Content: {value}");
                Console.ResetColor();
            }
        }
    }
}
