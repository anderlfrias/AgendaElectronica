using CapaDatos;
using CapaEntidades;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    public class ContactoNegocio
    {
        private readonly ContactoDatos _dbContactos;
        private readonly Contacto _entidad;
        private string message;
        public ContactoNegocio()
        {
            _dbContactos = new ContactoDatos();
        }

        public IList<Contacto> Get(string filtro = "")
        {
            var result = _dbContactos.Find(filtro);

            return result;
        }

        public IList<ModelViewContactos> GetViewModel(string filtro = "")
        {
            var result =_dbContactos.Find(filtro);

            IList<ModelViewContactos> contactos = new List<ModelViewContactos>();
            foreach (var item in result)
            {
                contactos.Add(new ModelViewContactos
                {
                    Id = item.Id,
                    Codigo = item.Codigo,
                    Nombres = $"{item.Nombre} {item.Apellido}",
                    Movil = item.Movil,
                    Telefono = item.Telefono,
                    Email = item.Email
                });
            }

            return contactos;
        }

        public string Create(Contacto model)
        {
            try
            {
                model.Id = Guid.NewGuid().ToString();
                _dbContactos.Add(model);
                message = "Contacto guardado correctamente.";
            }catch(System.Exception ex)
            {
                if (ex.InnerException != null)
                    message = ex.InnerException.Message;
                else
                    message = ex.Message;
            }
            return message;
        }

        public string Update(Contacto model)
        {
            try
            {
                _dbContactos.Update(model);
                message = "Contacto editado correctamente.";
            } catch(System.Exception ex)
            {
                if (ex.InnerException != null)
                    message = ex.InnerException.Message;
                else
                    message = ex.Message;
            }
            return message;
        }

        public string Delete(string id)
        {
            try
            {
                _dbContactos.Remove(id);
                message = "Contacto eliminado correctamente";
            } catch(System.Exception ex)
            {
                if (ex.InnerException != null)
                    message = ex.InnerException.Message;
                else
                    message = ex.Message;
            }
            return message;
        }
    }
}