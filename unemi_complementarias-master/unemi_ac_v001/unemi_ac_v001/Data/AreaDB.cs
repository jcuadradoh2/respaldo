using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using unemi_ac_v001.Model;

namespace unemi_ac_v001.Data
{
    public class AreaDB
    {
        readonly SQLiteAsyncConnection database;
        readonly SQLiteConnection cnn;
        public AreaDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            cnn = new SQLiteConnection(dbPath);
            database.CreateTableAsync<Area>().Wait();
        }

        public Task<List<Area>> GetAreaAsync()
        {
            return database.Table<Area>().ToListAsync();
        } 
        
        //Mostrar un area especifica
        public Area GetArea(Area obj)
        {
            return cnn.Table<Area>().FirstOrDefault(p => p.Id == obj.Id);
        }

        //Listado de areas
        public List<Area> GetAreaList()
        {
            return cnn.Table<Area>().Where(p => p.State == true).ToList();
            //return cnn.Table<Area>().ToList();
        }

        public Task<int> SaveAreaAsync(Area obj)
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
            //return database.InsertAsync(obj);            
        }

        public Task<List<Area>> GetByNameAsync(string name)
        {
            //Get by name
            return database.QueryAsync<Area>($"select * from Area where Name = '{name}'");
        }

        public void DeleteArea(Area obj)
        {
            // Delete a Alumn.
            //return database.DeleteAsync(alumn);
            database.QueryAsync<Area>($"update Area set (State = 0) where Id = {obj.Id}");
        }
        public async Task<int> DeleteAreaAsync(Area obj)
        {
            // Delete a Alumn.
            return await database.DeleteAsync(obj);
            //database.QueryAsync<Area>($"update Area set (State = 0) where Id = {obj.Id}");
        }

        public bool LogIn(Login ob)
        {          
            
            if ((database.QueryAsync<Area>($"select * from Login where UserName = '{ob.UserName}' and Password = '{ob.Password}'")) != null)
            {
                return true;
            }
            return false;

        }

    }
}
