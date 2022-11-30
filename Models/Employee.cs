
namespace lab3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; } 

        public int Post_id { get; set; }

        public  Post? post { get; set; }
    }

}
}