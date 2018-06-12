using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cours.MVC.Tuto2.Models.Data;

namespace Cours.MVC.Tuto2.Models.Dal
{
    public class LivreDal : IDisposable
    {
                private readonly BddContext _context;
        public LivreDal()
        {
            _context = new BddContext();
        }
        public void Dispose()
        {
            _context.Dispose();
        }



        public void Add(string nom, int idAuteur)
        {
            var livre = new Livre {Nom = nom, IdAuteur = idAuteur};

            _context.Livres.Add(livre);
            _context.SaveChanges();
        }

        public Livre Read(int id)
        {
            return _context.Livres.FirstOrDefault(a => a.Id == id);
        }

        public void Update(int id, string nom, int idAuteur)
        {
            Livre livre = Read(id);


            if (livre != null)
            {
                livre.Nom = nom;
                livre.IdAuteur = idAuteur;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Livre livre = Read(id);


            if (livre != null)
            {
                _context.Livres.Remove(livre);

                _context.SaveChanges();
            }
        }

        public List<Livre> GetAll()
        {
            return _context.Livres.ToList();
        }

        public List<Livre> GetAuteur(int id)
        {
            return _context.Livres.Where(liv => liv.IdAuteur == id).ToList();
        }

        public void DeleteAll()
        {
            _context.Livres.RemoveRange(_context.Livres);
        }
    }
}