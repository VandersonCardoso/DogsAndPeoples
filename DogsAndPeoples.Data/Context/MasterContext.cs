using DogsAndPeoples.Data.Repositories;
using System.Data.Entity;

namespace DogsAndPeoples.Data.Context
{
    public partial class MasterContext : DbContext
    {
        public MasterContext()
        {
        }

        public virtual DbSet<Donos> Donos { get; set; }
        public virtual DbSet<Caes> Caes { get; set; }
        public virtual DbSet<CaesDonos> CaesDonos { get; set; }
    }
}
