using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainbowSchool.Model
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set;}
    }
}
