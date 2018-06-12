using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Cours.MVC.Tuto2.Models.Data;

namespace Cours.MVC.Tuto2.Models.Dal
{
	/*
	 * Opérations CRUD
	 * Create
	 * Read
	 * Update
	 * Delete
	 */

	class ClientDal : IDisposable
	{
		private readonly BddContext _context;

		public ClientDal ()
		{
		_context=new BddContext();
		}

		public void Dispose()
		{
			_context.Dispose();
		}

		public void Add(string nom, string prenom, string email)
		{
			var client = new Client {Nom = nom, Prenom = prenom, Email = email};
			_context.Clients.Add(client);
			_context.SaveChanges();
		}

		public Client Read(int id)
		{
			return _context.Clients.FirstOrDefault(c => c.Id == id);
		}

		public void Update(Client element)
		{
			_context.Entry(element).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Client> GetAll()
		{
			return _context.Clients.ToList();
		}

		public void DeleteAll()
		{
			_context.Clients.RemoveRange(_context.Clients);
		}

		public bool Existe(string nom, string prenom)
		{
			var client = _context.Auteurs.FirstOrDefault(c => ((c.Nom == nom) && (c.Prenom == prenom)));

			return client != null;
		}
	}
}