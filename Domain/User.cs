using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EFProjectTwo.Domain
{
    [Table("users")]
    public class User
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("name")]
        public string Name { get; set; }
    }
}
