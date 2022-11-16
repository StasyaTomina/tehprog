using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializeBasic
{

    public class Post
    {
        public int NumberPost { get; set; }
        public string NamePost{ get; set; }

        public Sotrudniks Id { get; set; }

        public Post() { }

        public Post(int numberPost, string namePost, Sotrudniks id)
        {
            Id = id;
            NumberPost = numberPost;
            NamePost = namePost;
            
        }
    }
    public class Sotrudniks
    {
        public int SotrudnikId { get; set; }
        public string Fio { get; set; }
        public string Age { get; set; }

        public Sotrudniks() { }

        public Sotrudniks(int sotrudnikId, string fio, string age)
        {
            SotrudnikId = sotrudnikId;
            Fio = fio;
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

            partsList.Add(new Post(10, "Administrator", new Sotrudniks(1, "Petrov Ivan", "45")));
            partsList.Add(new Post(11, "Sekretar", new Sotrudniks(2, "Sidorov Sidor", "24")));
            partsList.Add(new Post(12, "Meneger", new Sotrudniks(3,"Ivanov Ivan ", "30")));
            partsList.Remove(new Post(10, "Administrator" , new Sotrudniks(1, "Petrov Ivan", "24")));
           

            partsHandler.Rewrite(partsList);
            partsHandler.OutputJsonContents();
        }
       
        }

}
