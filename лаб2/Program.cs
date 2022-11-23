using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Program
{

    public class Post
    {
        public int Id { get; set; }
        public string NamePost{ get; set; }

        public Employee EmployeeId   { get; set; }

        public Post() { }

        public Post(int id , string namePost, Employee employeeId)
        {
            Id = id;
            NamePost = namePost;
            EmployeeId = employeeId;
            
        }
    }
    public class Employee

    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        public Employee
() { }

        public Employee(int id, string surname, string age)
        {
            Id = id;
            Surname = surname;
            Age = age;
        }
    }
    
    public class JsonHandler<Lb> where Lb : class
    {
        private string fileName;
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        
        public JsonHandler() { }

        public JsonHandler(string fileName)
        {
            this.fileName = fileName;
        }


        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }

        public void Write(List<Lb> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            if (new FileInfo(fileName).Length == 0)
            {
                File.WriteAllText(fileName, jsonString);
            }
            else
            {
                Console.WriteLine("путь указанный к файлу не пустой");
            }
        }

        public void Delete()
        {
            File.WriteAllText(fileName, string.Empty);
        }

        public void Rewrite(List<Lb> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            File.WriteAllText(fileName, jsonString);
        }

        public void Read(ref List<Lb> list)
        {
            if (File.Exists(fileName))
            {
                if (new FileInfo(fileName).Length != 0)
                {
                    string jsonString = File.ReadAllText(fileName);
                    list = JsonSerializer.Deserialize<List<Lb>>(jsonString);
                }
                else
                {
                    Console.WriteLine("путь указанный к файлу не пустой");
                }
            }
        }

        public void OutputJsonContents()
        {
            string jsonString = File.ReadAllText(fileName);

            Console.WriteLine(jsonString);
        }

        public void OutputSerializedList(List<Lb> list)
        {
            Console.WriteLine(JsonSerializer.Serialize(list, options));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> partsList = new List<Post>();

            JsonHandler<Post> partsHandler = new JsonHandler<Post>("partsFile.json");

            partsList.Add(new Post(10, "Administrator", new Employee(1, "Petrov Ivan", "45")));
            partsList.Add(new Post(11, "Sekretar", new Employee(2, "Sidorov Sidor", "24")));
            partsList.Add(new Post(12, "Meneger", new Employee(3,"Ivanov Ivan ", "30")));
            partsList.Remove(new Post(10, "Administrator" , new Employee(1, "Petrov Ivan", "24")));
           

            partsHandler.Rewrite(partsList);
            partsHandler.OutputJsonContents();
        }
       
        }

}
