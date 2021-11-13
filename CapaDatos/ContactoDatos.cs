using CapaEntidades;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    public class ContactoDatos
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        
        public IList<Contacto> Find(string filtrar)
        {
            SqlDataReader LeerFilas;
            SqlCommand command = new SqlCommand("SP_FILTRAR", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            command.Parameters.AddWithValue("@Filtrar", filtrar);
            LeerFilas = command.ExecuteReader();

            IList<Contacto> contactos = new List<Contacto>();
            while (LeerFilas.Read())
            {
                contactos.Add(new Contacto
                {
                    Id = LeerFilas.GetString(0),
                    Codigo = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    FechaNacimiento = LeerFilas.GetDateTime(4),
                    Direccion = LeerFilas.GetString(5),
                    Genero = LeerFilas.GetString(6),
                    EstadoCivil = LeerFilas.GetString(7),
                    Movil = LeerFilas.GetString(8),
                    Telefono = LeerFilas.GetString(9),
                    Email = LeerFilas.GetString(10)
                });
            }

            sqlConnection.Close();
            LeerFilas.Close();
            return contactos;
        }

        public Contacto FindById(string id)
        {
            SqlDataReader LeerFila;
            SqlCommand command = new SqlCommand("SP_FINDBYID", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            command.Parameters.AddWithValue("@Id", id);
            LeerFila = command.ExecuteReader();

            Contacto contacto = new Contacto();

            while (LeerFila.Read())
            {
                contacto.Id = LeerFila.GetString(0);
                contacto.Codigo = LeerFila.GetString(1);
                contacto.Nombre = LeerFila.GetString(2);
                contacto.Apellido = LeerFila.GetString(3);
                contacto.FechaNacimiento = LeerFila.GetDateTime(4);
                contacto.Direccion = LeerFila.GetString(5);
                contacto.Genero = LeerFila.GetString(6);
                contacto.EstadoCivil = LeerFila.GetString(7);
                contacto.Movil = LeerFila.GetString(8);
                contacto.Telefono = LeerFila.GetString(9);
                contacto.Email = LeerFila.GetString(10);
            }

            sqlConnection.Close();
            LeerFila.Close();
            return contacto;
        }

        public void Add(Contacto model)
        {
            SqlCommand command = new SqlCommand("SP_INSERTAR", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            command.Parameters.AddWithValue("@Id", model.Id);
            command.Parameters.AddWithValue("@Nombre", model.Nombre);
            command.Parameters.AddWithValue("@Apellido", model.Apellido);
            command.Parameters.AddWithValue("@FechaNacimiento", model.FechaNacimiento);
            command.Parameters.AddWithValue("@Direccion", model.Direccion);
            command.Parameters.AddWithValue("@Genero", model.Genero);
            command.Parameters.AddWithValue("@EstadoCivil", model.EstadoCivil);
            command.Parameters.AddWithValue("@Movil", model.Movil);
            command.Parameters.AddWithValue("@Telefono", model.Telefono);
            command.Parameters.AddWithValue("@CorreoElectronico", model.Email);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Update(Contacto model)
        {
            SqlCommand command = new SqlCommand("SP_MODIFICAR", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            command.Parameters.AddWithValue("Id", model.Id);
            command.Parameters.AddWithValue("@Nombre", model.Nombre);
            command.Parameters.AddWithValue("@Apellido", model.Apellido);
            command.Parameters.AddWithValue("@FechaNacimiento", model.FechaNacimiento);
            command.Parameters.AddWithValue("@Direccion", model.Direccion);
            command.Parameters.AddWithValue("@Genero", model.Genero);
            command.Parameters.AddWithValue("@EstadoCivil", model.EstadoCivil);
            command.Parameters.AddWithValue("@Movil", model.Movil);
            command.Parameters.AddWithValue("@Telefono", model.Telefono);
            command.Parameters.AddWithValue("@CorreoElectronico", model.Email);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Remove(string id)
        {
            SqlCommand command = new SqlCommand("SP_ELIMINAR", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}