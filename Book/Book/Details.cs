using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Details
    {
        private int ID;
        private string title;
        private string author;
        public Details()
        {

        }

        public Details(int id, string title, string author)
        {
            this.ID = id;
            this.title = title;
            this.author = author;
        }

        public void Add()
        {
            Console.WriteLine("Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Book Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Book added!!!");
        }

        public void Display()
        {
            Console.WriteLine("ID: " + ID + " Title: " + title + " Author: " + author);

        }
        public void FindByID(int id)
        {
            if (this.ID == id)
            {
                this.Display();
            }
        }
        public void FindByTitle(string title)
        {
            if (this.title == title)
            {
                this.Display();
            }
        }
        public void FindByAuthor(string author)
        {
            if (this.author == author)
            {
                this.Display();
            }
        }

    }
}
