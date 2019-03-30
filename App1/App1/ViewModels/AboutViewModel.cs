using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using App1.Models;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public AboutViewModel()
        {
            Title = "About";

           Items = new ObservableCollection<Item>();
            Items.Add(new Item{ Id = "blablabla", Description = "SomeDescription", Text = "Some text"});
            Items.Add(new Item { Id = "bliblibli", Description = "Some Description 2", Text = "Some text 2" });
            Items.Add(new Item { Id = "blobloblo", Description = "Some Description 3", Text = "Some text 3" });
        }

    }
}