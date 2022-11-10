using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;

namespace lab2_3_tp
{
    public class Exam
    {
        public int idStud { get; set; }
        public int idSub { get; set; }
        public int mark { get; set; }
    }
}

namespace lab2_3_tp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }
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
    var exams = db.Exams.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Exam u in exams)
    {
        Console.WriteLine(u.idSub + " - " + u.mark);
    }
}

using (ApplicationContext db = new ApplicationContext())
{
    Exam test = new Exam { idStud = 2, idSub = 2, mark = 5 };
    db.Exams.Add(test);
    db.SaveChanges();
    var exams = db.Exams.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Exam u in exams)
    {
        Console.WriteLine(u.idSub + " - " + u.mark);
    }

}

using (ApplicationContext db = new ApplicationContext())
{
    User? upduser = (from student in db.Students where student.idStud ==  select student).First();
    if (upduser != null)
    {
        upduser.idSub = upduser.idSub * 2;
        db.SaveChanges();
    }
    var exams = db.Exams.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Exam u in exams)
    {
        Console.WriteLine(u.idSub + " - " + u.mark);
    }

}

using (ApplicationContext db = new ApplicationContext())
{
    User? deluser = (from exam in dbExams where exam.idSub == 2 select exam).First();
    if (deluser != null)
    {
        db.Exams.Remove(deluser);
        db.SaveChanges();
    }
    var exams = db.Exams.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Exam u in exams)
    {
        Console.WriteLine(u.idSub + " - " + u.mark);
    }

}
