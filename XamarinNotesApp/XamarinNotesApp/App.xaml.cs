using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamarinNotesApp {
    public partial class App : Application {
        public const string DATABASE_NAME = "notes.db";
        public static NoteRepository database;

        public static NoteRepository Database {
            get {
                if (database == null) {
                    database = new NoteRepository(DATABASE_NAME);
                }

                return database;
            }
        }

        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            
        }
    }
}