using System;
using System.Collections.Generic;
using System.Linq;
using Cours.MVC.Tuto2.Models.Data;

namespace Cours.MVC.Tuto2.Models.Dal
{
    // DAL
    // Data Access Layer

    // CRUD
    // Create Read Update Delete

    public class AuteurDal : IDisposable
    {
        private readonly BddContext _context;
        public AuteurDal()
        {
            _context = new BddContext();
        }
        public void Dispose()
        {
            _context.Dispose();
        }



        public void Add(string nom, string prenom)
        {
            var auteur = new Auteur {Nom = nom, Prenom = prenom};

            _context.Auteurs.Add(auteur);
            _context.SaveChanges();
        }

        public Auteur Read(int id)
        {
            return _context.Auteurs.FirstOrDefault(a => a.Id == id);
        }

        public void Update(int id, string nom, string prenom)
        {
            Auteur auteur = Read(id);


            if (auteur != null)
            {
                auteur.Nom = nom;
                auteur.Prenom = prenom;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Auteur auteur = Read(id);


            if (auteur != null)
            {
                _context.Auteurs.Remove(auteur);

                _context.SaveChanges();
            }
        }

        public List<Auteur> GetAll()
        {
            return _context.Auteurs.ToList();
        }

        public void DeleteAll()
        {
            _context.Auteurs.RemoveRange(_context.Auteurs);
        }


        public bool Exists(string nom, string prenom)
        {
            var auteur = _context.Auteurs.FirstOrDefault(c => ((c.Nom == nom) && (c.Prenom == prenom)));

            return auteur != null;
        }
    }
}