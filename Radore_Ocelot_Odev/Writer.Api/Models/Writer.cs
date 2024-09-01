using System.ComponentModel.DataAnnotations;

namespace Writer.Api.Models
{
    public class Writer
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public Writer(){}
        public Writer(int Id, string name)
        {
            this.Id = Id;
            this.name = name;
        }
    }
}
