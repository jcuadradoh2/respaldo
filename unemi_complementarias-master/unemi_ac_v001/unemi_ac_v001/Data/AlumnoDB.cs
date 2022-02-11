using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using unemi_ac_v001.Model;

namespace unemi_ac_v001.Data
{
    public class AlumnoDB
    {
        readonly SQLiteAsyncConnection database;
        readonly SQLiteConnection cnn;

        public AlumnoDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            cnn = new SQLiteConnection(dbPath);

            database.CreateTableAsync<AlumnoCls>().Wait();
        }

        public Task<List<AlumnoCls>> GetAlumnAsync()
        {
            //Get all Alumn.
            return database.Table<AlumnoCls>().ToListAsync();
        }

        public Task<AlumnoCls> GetAlumnAsync(int id)
        {
            // Get a specific Alumn.
            return database.Table<AlumnoCls>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveAlumnAsync(AlumnoCls obj)
        {
            if (obj.Id != 0)
            {
                // Update an existing Alumn.
                return database.UpdateAsync(obj);
            }
            else
            {
                // Save a new Alumn.
                return database.InsertAsync(obj);
            }
        }

        public void DeleteAlumnAsync(AlumnoCls alumn)
        {
            // Delete a Alumn.
            //return database.DeleteAsync(alumn);
            database.QueryAsync<AlumnoCls>($"update Alumno set (State = 0)");
        }

        public Task<List<AlumnoCls>> GetActiveAsync()
        {
            //Get all notes.
            return database.QueryAsync<AlumnoCls>("select * from Alumno where State = 1");
        }

        public List<AlumnoCls> GetAlumnoList()
        {
            return cnn.Table<AlumnoCls>().ToList();
            //return cnn.Table<Area>().ToList();
        }

    }
}
