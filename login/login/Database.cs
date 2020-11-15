using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class database
    {
         SQLiteAsyncConnection _database;

        public database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>().Wait();
            _database.CreateTableAsync<Script>().Wait();
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
        public Task<List<Script>> GetScriptAsync()
        {
            return _database.Table<Script>().ToListAsync();
        }

        public Task<int> SaveScriptAsync(Script script)
        {
            return _database.InsertAsync(script);
        }
        
        public void dosome(){


        }
    }
}