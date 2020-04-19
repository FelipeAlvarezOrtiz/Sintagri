using Microsoft.EntityFrameworkCore;
using Sintagri.Modelo.Entidades.Agua;

namespace Sintagri.Modelo.DataBase.MySQL.Sets
{
    public class MySQLDataSets
    {
        public DbSet<Aguas> Aguas { get; set; }
    }
}
