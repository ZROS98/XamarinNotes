using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNotesApp {
    public interface ISQLite {
        string GetDatabasePath(string filename);
    }
}