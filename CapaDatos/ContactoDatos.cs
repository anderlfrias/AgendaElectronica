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
        
        public IList<Contacto> MostrarContactos(string filtrar)
        {
            SqlDataReader LeerFilas;
            SqlCommand command = new SqlCommand("SP_BUSCAR", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            command.Parameters.AddWithValue("@Buscar", filtrar);
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
    }
}