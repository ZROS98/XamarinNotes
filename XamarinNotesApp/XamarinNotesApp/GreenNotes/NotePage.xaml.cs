using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNotesApp {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotePage : ContentPage {

        public Color notesColor;
        private MainPage _parent;
       

        public NotePage(MainPage parent) {
           
            _parent = parent;
            InitializeComponent();
            
        }
        

        private void SaveNote(object sender, EventArgs e) {
            var note = (Note) BindingContext;
            note.SelectedDate = DateTime.Now;
            if (!String.IsNullOrEmpty(note.Title)) {
                App.Database.SaveItem(note);
            }
            _parent.ChangeColor(notesColor);
            this.Navigation.PopAsync();
            
        }

        private void DeleteNote(object sender, EventArgs e) {
            var note = (Note) BindingContext;
            App.Database.DeleteItem(note.Id);
            this.Navigation.PopAsync();
        }

        private void Cancel(object sender, EventArgs e) {
            this.Navigation.PopAsync();
        }

        private void CollorGreen(object sender, EventArgs e) {
            var note = (Note)BindingContext;
            note.Priority = 0;
        }

        private void CollorYellow(object sender, EventArgs e) {
            var note = (Note)BindingContext;
            note.Priority = 1;
        }

        private void CollorRed(object sender, EventArgs e) {
            var note = (Note)BindingContext;
            note.Priority = 2;
        }

       
        
    }

}