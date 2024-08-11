using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sozinho02.Domain.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int     id      { get; private set; }
        public string  name    { get; private set; }
        public int     age     { get; private set; }
        public string? photo   { get; private set; }
        public bool    activen { get; private set; }

        public Employee(string name, int age, string photo, bool activen)
        {
            this.name = name;
            this.age = age;
            this.photo = photo;
            this.activen = activen;
        }

        public void Up(string name, int age, string photo, bool activen)
        {
            this.name = name;
            this.age = age;
            this.photo = photo;
            this.activen = activen;
        }

        public void DelActv(bool activen)
        {
            this.activen = activen;
        }
    }
}
