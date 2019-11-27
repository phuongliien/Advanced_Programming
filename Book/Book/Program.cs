using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            List<Details> book = new List<Details>();
            do

            {

                Console.WriteLine("***************************");

                Console.WriteLine("1. Add a Book");

                Console.WriteLine("2. Display All Book");

                Console.WriteLine("3. Search Book");

                Console.WriteLine("4. Exit");

                Console.WriteLine("**************************");

                Console.WriteLine("input your choice=");

                try

                {

                    choice = Convert.ToInt32(Console.ReadLine());

                }

                catch (Exception)

                {

                    Console.WriteLine("input a number");

                }

                switch (choice)
                {

                    case 1:

                        Console.WriteLine("Add Book here"); // them code o day
                        Console.WriteLine("Book ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Author: ");
                        string author = Console.ReadLine();
                        book.Add(new Details(id, title, author));
                        break;

                    case 2:

                        Console.WriteLine("Display Book here"); 
                        foreach (var b in book)
                        {
                            b.Display();
                        }
                        break;

                    case 3:
                        int c = 0;
                        do
                        {
                            Console.WriteLine("########## Choose function here ############");
                            Console.WriteLine("1. Search book by ID");
                            Console.WriteLine("2. Search book by Title");
                            Console.WriteLine("3. Search book by Author");
                            Console.WriteLine("4. Back to Menu");

                            try
                            {
                                c = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Enter a number: ");

                            }
                            switch (c)
                            {
                                case 1:
                                    Console.WriteLine("Enter Book ID:");
                                    int bid = Convert.ToInt32(Console.ReadLine());
                                    bool fl = false;
                                    Console.WriteLine("Book ID\tBook titile\tBook Author");
                                    foreach(var b in book)
                                    {
                                        b.FindByID(bid);
                                        fl = true;
                                    }
                                    if (fl == false)
                                    {
                                        Console.WriteLine("NO AVAILABLE!!");
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("Enter Book Title:");
                                    string btitle = Console.ReadLine();
                                    bool f = false;
                                    Console.WriteLine("Book ID\tBook titile\tBook Author");
                                    foreach (var b in book)
                                    {
                                        b.FindByTitle(btitle);
                                        f = true;
                                    }
                                    if (f == false)
                                    {
                                        Console.WriteLine("NO AVAILABLE!!");
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Enter Book ID:");
                                    string bAuthor = Console.ReadLine();
                                    bool f3 = false;
                                    Console.WriteLine("Book ID\tBook titile\tBook Author");
                                    foreach (var b in book)
                                    {
                                        b.FindByAuthor(bAuthor);
                                        f3 = true;
                                    }
                                    if (f3 == false)
                                    {
                                        Console.WriteLine("NO AVAILABLE!!");
                                    }
                                    break;

                                default:
                                    break;
                            }

                        } while (c != 4);
                        Console.WriteLine("Search Book"); break;// them code o day

                    case 4:

                        Environment.Exit(0); break;

                    default:
                        Console.WriteLine("invalid value");

                        break;

                }

            } while (choice != 4);

        }
    }
    }

