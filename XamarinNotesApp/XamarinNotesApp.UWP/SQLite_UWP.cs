﻿using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using XamarinNotesApp.UWP;

[assembly: Dependency(typeof(SQLite_UWP))]

namespace XamarinNotesApp.UWP {
    class SQLite_UWP : ISQLite {
        public SQLite_UWP() {
        }

        public string GetDatabasePath(string sqliteFilename) {
            // для доступа к файлам используем API Windows.Storage
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            return path;
        }
    }
}