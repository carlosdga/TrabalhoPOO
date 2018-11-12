using Agenda.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Contexto
{
    public class AgendaContexto : DbContext
    {
        public AgendaContexto() : base(nameOrConnectionString: "agenda")
        {
            Database.SetInitializer<AgendaContexto>(new AgendaContextoInitializer());
        }
        public DbSet<Contato> Contatos { get; set; }
    }
    public class AgendaContextoInitializer : DropCreateDatabaseIfModelChanges<AgendaContexto>
    {

    }
}
