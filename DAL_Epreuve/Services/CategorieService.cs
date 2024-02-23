using DAL_Epreuve.Entities;
using DAL_Epreuve.Mappers;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_Epreuve.Services
{
    public class CategorieService : BaseService, ICategorieRepository<Categorie>
    { 
        public CategorieService(IConfiguration configuration) : base(configuration, "DB-Epreuve")
        {
        }

        public IEnumerable<Categorie> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategorie();
                        }
                    }
                }
            }
        }
        public Categorie Get(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_GetBy";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NomCategorie", id);
                     connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCategorie();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }
        public string Insert(Categorie data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NomCategorie", data.NomCategorie);
                    connection.Open();
                    return (string)command.ExecuteScalar();
                }
            }
        }

        public void Update(Categorie data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NomCategorie", data.NomCategorie);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.NomCategorie), $"L'identifiant {data.NomCategorie} n'existe pas dans la base de données.");
                }
            }
        }
        public void Delete(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NomCategorie",id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }
    }
}
 