using System.ComponentModel;

namespace VUEJS.Models
{
    public class Person
    {
        
        public int Id { get; set; }
        [DisplayName("身份证")]
        public string SFZ { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string IDCard { get; set; }
    }
}