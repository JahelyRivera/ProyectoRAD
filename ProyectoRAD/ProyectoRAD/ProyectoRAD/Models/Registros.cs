using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRAD.Models
{
    public class Registros
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nombres { get; set; }

        [MaxLength(100)]
        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Pais { get; set; }

        public string Departamento { get; set; }

        public string Municipo { get; set; }

        public string Foto { get; set; }

        public string EstadoCivil { get; set; }

        public string Telefono { get; set; }

        public string Latitud { get; set; }

        public string Longitud { get; set; }

    }
}
