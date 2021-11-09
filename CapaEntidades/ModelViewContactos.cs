using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ModelViewContactos
    {
        private string _codigo;
        private string _nombres;
        private string _movil;
        private string _telefono;
        private string _email;

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Movil { get => _movil; set => _movil = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
