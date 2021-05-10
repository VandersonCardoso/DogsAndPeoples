using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogsAndPeoples.Data.Repositories
{
    [Table("Caes")]
    public partial class Caes
    {
        [Key]
        [Column("Id_Cao")]
        public int IdCao { get; set; }
        [Required]
        [Column("Nome")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [Column("Raca")]
        [StringLength(30)]
        public string Raca { get; set; }
    }
}
