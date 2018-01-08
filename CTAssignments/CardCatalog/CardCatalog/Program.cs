
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodingTemple.Fall2017.CardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a file");
            string fileName = Console.ReadLine();
            CardCatalog cc = new CardCatalog(fileName);
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("\t1.\tList All books");
                Console.WriteLine("\t2.\tAdd A Book");
                Console.WriteLine("\t3.\tSave and Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        cc.ListBooks();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter the title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the author");
                        string author = Console.ReadLine();
                        cc.AddBook(title, author);
                        Console.Clear();
                        Console.WriteLine("Book added.  Press any key to continue");
                        Console.Clear();
                        break;
                    case "3":
                        cc.Save();
                        break;
                }

            } while (choice != "3");
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

    }

    public class CardCatalog
    {
        private string _filename;

        private List<Book> books; //This is the private member variable that contains all of the books

        public CardCatalog(string fileName)
        {
            _filename = fileName;
            if (File.Exists(fileName))
            {

                Stream stream = new FileStream(_filename, FileMode.Open, FileAccess.Read, FileShare.Read);

                //Binary deserialization:
                //IFormatter formatter = new BinaryFormatter();
                //books = (List<Book>)formatter.Deserialize(stream);

                //XML Deserialization:
                XmlSerializer s = new XmlSerializer(typeof(List<Book>));
                books = (List<Book>)s.Deserialize(stream);

                //JSON Deserialization:
                //Serialization as JSON
                //books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(_filename));
                stream.Close();
                stream.Dispose();
            }
            else
            {
                books = new List<Book>();
            }
        }
        public void ListBooks()
        {
            Console.Clear();
            foreach (var book in books)
            {
                Console.WriteLine("Title:{0}\tAuthor:{1}", book.Title, book.Author);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void AddBook(string title, string author)
        {
            Book newBook = new Book
            {
                Title = title,
                Author = author
            };
            books.Add(newBook);
        }
        public void Save()
        {

            Stream stream = new FileStream(this._filename, FileMode.Create, FileAccess.Write, FileShare.None);

            //Serialization as binary:
            //IFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(stream, this.books);


            //Serialization as XML:
            XmlSerializer s = new XmlSerializer(typeof(List<Book>));
            s.Serialize(stream, books);

            //Serialization as JSON

            //File.WriteAllText(_filename, JsonConvert.SerializeObject(books));
            stream.Close();
            stream.Dispose();
        }
    }
}
