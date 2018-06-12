using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Cours.MVC.Tuto3.Models.Data;

namespace Cours.MVC.Tuto3.Models.Dal
{
    public class AuteurAdoDal : IDisposable
    {
        private readonly SqlConnection cnx;

        public AuteurAdoDal()
        {
            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["BddContext"].ToString());
            cnx.Open();
        }

        public void Dispose()
        {
            cnx.Close();
            cnx.Dispose();
        }

        public int Add(string nom, string prenom)
        {
            // on prepare la requete
            const string query = @"
                INSERT Auteurs (Nom, Prenom) VALUES (@Nom, @Prenom);
                SELECT SCOPE_IDENTITY() ;
            ";

            // on connecte la base et la requete
            var cmd = new SqlCommand(query,cnx);

            // on passe les parametres
            cmd.Parameters.Add("@Nom", SqlDbType.NVarChar).Value = nom;
            cmd.Parameters.Add("@Prenom", SqlDbType.NVarChar).Value = prenom;

            // et on execute
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        public Auteur Read(int id)
        {
            var dSet = new DataSet();
            const string query = @"
                SELECT * FROM Auteurs
                WHERE Id=@Id
            ";

            
            var cmd = new SqlCommand(query, cnx);
            cmd.Parameters.Add("@Id", SqlDbType.BigInt).Value = id;
            var adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dSet, "temp");

            return dSet.Tables["temp"].Rows.Count > 0 ? FromRow(dSet.Tables["temp"].Rows[0]) : null;
        }

        public void Update(int id, string nom, string prenom)
        {
            // on prepare la requete
            const string query = @"
                UPDATE Auteurs
                SET
                    Nom=@Nom, 
                    Prenom = @Prenom
                WHERE Id = @Id;
            ";

            // on connecte la base et la requete
            var cmd = new SqlCommand(query, cnx);

            // on passe les parametres
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Nom", SqlDbType.NVarChar).Value = nom;
            cmd.Parameters.Add("@Prenom", SqlDbType.NVarChar).Value = prenom;

            // et on execute
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            const string query = @"
                DELETE Auteurs
                WHERE Id = @Id;
            ";

            var cmd = new SqlCommand(query, cnx);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();
        }


        public bool Exists(string nom, string prenom)
        {
            var dSet = new DataSet();
            const string query = @"
                SELECT * FROM Auteurs
                WHERE Nom=@Nom
                AND Prenom = @Prenom
            ";


            var cmd = new SqlCommand(query, cnx);

            cmd.Parameters.Add("@Nom", SqlDbType.NVarChar).Value = nom;
            cmd.Parameters.Add("@Prenom", SqlDbType.NVarChar).Value = prenom;

            var adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dSet, "temp");

            return (dSet.Tables["temp"].Rows.Count > 0);
        }

        public List<Auteur> GetAll()
        {
            var auteurs = new List<Auteur>();

            var dSet = new DataSet();
            const string query = @"
                SELECT * FROM Auteurs
            ";


            var cmd = new SqlCommand(query, cnx);

            var adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dSet, "temp");

            foreach (DataRow row in dSet.Tables["temp"].Rows)
            {
                auteurs.Add(FromRow(row));
            }

            return auteurs;
        }

        private Auteur FromRow(DataRow dataRow)
        {
            var auteur = new Auteur
            {
                Id = int.Parse(dataRow["Id"].ToString()),
                Nom = dataRow["Nom"].ToString(),
                Prenom = dataRow["Prenom"].ToString()
            };

            return auteur;
        }
    }
}