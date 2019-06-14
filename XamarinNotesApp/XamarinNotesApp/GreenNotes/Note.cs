using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.Linq;

namespace XamarinNotesApp {
    [Table("Notes")]
    public class Note {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        

        public string Title { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }
        public DateTime SelectedDate { get; set; }
    }
}