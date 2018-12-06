using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace DataBaseApp
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();

    }
}
