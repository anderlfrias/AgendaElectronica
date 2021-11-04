using System;

namespace CapaEntidades
{
    public class Contacto
    {
        private string _id;
        private string _codigo;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private string _direccion;
        private char _genero;
        private char _estadoCivil;
        private string _movil;
        private string _telefono;
        private string _email;

        public string Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public char Genero { get => _genero; set => _genero = value; }
        public char EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
        public string Movil { get => _movil; set => _movil = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
