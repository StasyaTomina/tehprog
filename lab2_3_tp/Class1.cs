using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_3_tp
{
    public class Student
    {
        public int idStud { get; set; }
        public string fio { get; set; }
        public string numGr { get; set; }
    }
}


namespace lab2_3_tp
{
    public class ApplicationContext : DbContext
    { 
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("jsconfig1.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

using (ApplicationContext db = new ApplicationContext())
{
    var students = db.Students.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Student u in students)
    {
        Console.WriteLine(u.fio + " - " + u.numGr);
    }
}

using (ApplicationContext db = new ApplicationContext())
{
    Student test = new Student { idStud = 2, fio = "Сидоров", numGr = 124 };
    db.Students.Add(test);
    db.SaveChanges();
    var students = db.Students.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Student u in students)
    {
        Console.WriteLine(u.fio + " - " + u.numGr);
    }

}

using (ApplicationContext db = new ApplicationContext())
{
    User? upduser = (from student in db.Students where student.idStud ==  select student).First();
    if (upduser != null)
    {
        upduser.idStud = upduser.idStud * 2;
        db.SaveChanges();
    }
    var students = db.Students.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Student u in students)
    {
        Console.WriteLine(u.fio + " - " + u.numGr);
    }

}

using (ApplicationContext db = new ApplicationContext())
{
    User? deluser = (from student in db.Students where student.idStud == 2 select student).First();
    if (deluser != null)
    {
        db.Students.Remove(deluser);
        db.SaveChanges();
    }
    var students = db.Students.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Student u in students)
    {
        Console.WriteLine(u.fio + " - " + u.numGr);
    }

}





