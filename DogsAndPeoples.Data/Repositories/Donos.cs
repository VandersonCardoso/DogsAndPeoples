using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogsAndPeoples.Data.Repositories
{
    [Table("Donos")]
    public partial class Donos
    {
        [Key]
        [Column("Id_Dono")]
        public int IdDono { get; set; }
        [Required]
        [Column("Nome")]
        [StringLength(100)]
        public string Nome { get; set; }
    }
}
