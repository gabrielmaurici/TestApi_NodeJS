using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class MusicaRepository
    {
        public void Create(Musica model)
        {
            using (var context = new BandaContext())
            {
                context.Musicas.Add(model);
                context.SaveChanges();
            }
        }
        public List<Musica> Read()
        {
            List<Musica> lista = new List<Musica>();
            using (var context = new BandaContext())
            {
                lista = context.Musicas.ToList();
            }
            return lista;
        }
        public Musica Read(int id)
        {
            Musica model = new Musica();
            using (var context = new BandaContext())
            {
                model = context.Musicas.Find(id);
            }
            return model;
        }
        public void Update(Musica model)
        {
            using (var context = new BandaContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new BandaContext())
            {
                context.Entry<Musica>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
