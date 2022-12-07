
namespace lab3.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; } 

        public int PostId { get; set; }

        public  Post post { get; set; }
    }

}
