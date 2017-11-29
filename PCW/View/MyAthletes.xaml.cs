using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace PCW
{
    public partial class MyAthletes : ContentPage
    {
        public static ObservableCollection<string> items { get; set; }
        public MyAthletes()
        {

            InitializeComponent();
        }
        public Command<String> SendMessage
        {
            get
            {
                return new Command<String>((message) =>
                {
                });

            }
        }
    }
}
