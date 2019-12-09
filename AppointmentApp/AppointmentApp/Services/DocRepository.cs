using AppointmentApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentApp.Services
{
    public class DocRepository
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public DocRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Items>();
           
        }

                public void AddNewDoc(string name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                result = conn.Insert(new Items { Name = name });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }
        }

        public List<Items> GetAllPeople()
        {
            try
            {
                return conn.Table<Items>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Items>();
        }
    }
}


