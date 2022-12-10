using ProyectoRAD.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRAD.Controllers
{
    public class DBRegistros
    {
        readonly SQLiteAsyncConnection _conexion;
        // Constructor Vacio
        public DBRegistros()
        { }

        // Constructor con parametros
        public DBRegistros(String dbpath)
        {
            // Creando una conexion a base de datos sqlite a partir del path de la base de datos
            _conexion = new SQLiteAsyncConnection(dbpath);

            // Crear las tablas correspondientes en la base de datos de sqlite
            _conexion.CreateTableAsync<Models.Registros>().Wait();
        }

        // CRUD - Aplicaciones 
        // Create

        public Task<int> StoreRegistros(Models.Registros registros)
        {
            if (registros.Id != 0)
            {
                return _conexion.UpdateAsync(registros);
            }
            else
            {
                return _conexion.InsertAsync(registros);
            }
        }
        // Read

        public Task<List<Models.Registros>> listaRegistros()
        {
            return _conexion.Table<Models.Registros >().ToListAsync();
        }


        public Task<Models.Registros > getRegistros(int pid)
        {
            return _conexion.Table<Models.Registros>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> DeleteRegistros(Registros registros)
        {
            return _conexion.DeleteAsync(registros);
        }
    }
}
