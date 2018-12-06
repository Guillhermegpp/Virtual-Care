using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using UIKit;

namespace DataBaseApp.iOS
{
    class Database_ios : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}