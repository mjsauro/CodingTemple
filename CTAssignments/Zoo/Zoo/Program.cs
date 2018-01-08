using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a file.");
            string fileName = Console.ReadLine();
            Zoos z = new Zoos(fileName);
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("\t1. \tList All Animals");
                Console.WriteLine("\t2. \tAdd a Species");
                Console.WriteLine("\t3. \tSave and Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        z.ListAnimals();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter the name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the species");
                        string species = Console.ReadLine();
                        z.AddAnimal(name, species);
                        Console.WriteLine("Animal added.  Press any key to continue");
                        Console.Clear();
                        break;
                    case "3":
                        z.Save();
                        break;
                }
            }
            while (choice != "3");
        }
    }
}

public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
}

public class Zoos
{
    private string _filename;

    private List<Animal> animal; //This is the private member variable that contains all of the books

    public Zoos(string fileName)
    {
        _filename = fileName;
        if (File.Exists(fileName))
        {
            Stream stream = new FileStream(_filename, FileMode.Open, FileAccess.Read, FileShare.Read);

            //Binary deserialization:
            //IFormatter formatter = new BinaryFormatter();
            //animal = (List<Animal>)formatter.Deserialize(stream);

            //XML Deserialization:
            XmlSerializer s = new XmlSerializer(typeof(List<Animal>));
            animal = (List<Animal>)s.Deserialize(stream);

            //JSON Deserialization:
            //Serialization as JSON
            //animal = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(_filename));
            stream.Close();
            stream.Dispose();
        }
        else
        {
            animal = new List<Animal>();
        }
    }
    public void ListAnimals()
    {
        Console.Clear();
        foreach (var a in animal)
        {
            Console.WriteLine("Name:{0}\tSpecies:{1}", a.Name, a.Species);
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    public void AddAnimal(string name, string species)
    {
        Animal newAnimal = new Animal
        {
            Name = name,
            Species = species
        };
        animal.Add(newAnimal);
    }
    public void Save()
    {
        Stream stream = new FileStream(this._filename, FileMode.Create, FileAccess.Write, FileShare.None);

        //Serialization as binary:
        //IFormatter formatter = new BinaryFormatter();
        //formatter.Serialize(stream, this.animal);


        //Serialization as XML:
        XmlSerializer s = new XmlSerializer(typeof(List<Animal>));
        s.Serialize(stream, animal);

        //Serialization as JSON

        ///File.WriteAllText(_filename, JsonConvert.SerializeObject(animal));
        stream.Close();
        stream.Dispose();
    }
}

