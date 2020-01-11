using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Absences
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
