using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace XamarinNotesApp {
    public partial class MainPage : ContentPage {
        
        private List<Note> lowPriorityList = new List<Note>();
        private List<Note> midPriorityList = new List<Note>();
        private List<Note> highPriorityList = new List<Note>();

        private Color lowPriorColor = new Color(0, 1, 0);

        public MainPage() {
            
            InitializeComponent();
        }

        

        protected override void OnAppearing() {

          
            
            List<Note> AllNotes = new List<Note>(App.Database.GetItems());
            lowPriorityList = AllNotes.Where(n => n.Priority == 0).ToList<Note>();
            midPriorityList = AllNotes.Where(n => n.Priority == 1).ToList<Note>();
            highPriorityList = AllNotes.Where(n => n.Priority == 2).ToList<Note>();

            noteListLeft.ItemsSource = lowPriorityList;
            noteListCentral.ItemsSource = midPriorityList;
            noteListRight.ItemsSource = highPriorityList;

            //App.database.Drop(); dropping database

            base.OnAppearing();
        }


        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e) {
            Note selectedNote = (Note) e.SelectedItem;
            NotePage notePage = new NotePage(this);
            notePage.BindingContext = selectedNote;
            await Navigation.PushAsync(notePage);
        }

        private async void CreateNote(object sender, EventArgs e) {
            Note note = new Note();
            NotePage notePage = new NotePage(this);
            notePage.BindingContext = note;
            await Navigation.PushAsync(notePage);
        }

        public void ChangeColor(Color color) {
            //noteList.BackgroundColor = color;
        }
    }
}