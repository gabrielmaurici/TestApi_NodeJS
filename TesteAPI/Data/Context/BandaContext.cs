using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class BandaContext : DbContext
    {
        public DbSet<Musica> Musicas { get; set; }
        public BandaContext() : base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Gabriel\Documents\Dev\TesteAPI\TesteAPI\Data\AppData\BdMusicas.mdf;Integrated Security = True")
        {

        }
    }
}
