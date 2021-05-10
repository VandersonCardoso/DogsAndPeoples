using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogsAndPeoples.Data.Repositories
{
    [Table("Caes_Dono")]
    public partial class CaesDonos
    {
        [Required]
        [Column("Id_Dono")]
        public int IdDono { get; set; }
        [Required]
        [Column("Id_Cao")]
        public int IdCao { get; set; }
    }
}
