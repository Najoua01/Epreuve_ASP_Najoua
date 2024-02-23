using DAL_Epreuve.Entities;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using DAL_Epreuve.Mappers;

namespace DAL_Epreuve.Services
{
    public class ProduitService : BaseService, IProduitRepository<Produit>
    {
        public ProduitService(IConfiguration configuration) : base(configuration, "DB-Epreuve")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Produit", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }
         
        public IEnumerable<Produit> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        public Produit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetBy";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Produit",id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }

        public IEnumerable<Produit> GetByCategorie(string categorie)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Produit WHERE NomCategorie= @NomCategorie";
                    command.Parameters.AddWithValue("@NomCategorie", categorie);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        public IEnumerable<Produit> GetRandomProduit(int count)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"SELECT TOP {count} * FROM Produit ORDER BY NEWID()";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        public int Insert(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Nom", data.Nom);
                    command.Parameters.AddWithValue("Description", data.Description);
                    command.Parameters.AddWithValue("Prix", data.Prix);
                    command.Parameters.AddWithValue("EcoScore", data.EcoScore);
                    command.Parameters.AddWithValue("NomCategorie", data.NomCategorie);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Produit", data.Id_Produit);
                    command.Parameters.AddWithValue("Nom", data.Nom);
                    command.Parameters.AddWithValue("Description", data.Description);
                    command.Parameters.AddWithValue("Prix", data.Prix);
                    command.Parameters.AddWithValue("EcoScore", data.EcoScore);
                    command.Parameters.AddWithValue("NomCategorie", data.NomCategorie);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Produit), $"L'identifiant {data.Id_Produit} n'existe pas dans la base de données.");
                }
            }
        }
    }
}
