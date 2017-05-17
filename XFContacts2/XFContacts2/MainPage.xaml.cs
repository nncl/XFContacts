using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFContacts2.Model;

namespace XFContacts2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadContacts();
        }

        private void LoadContacts()
        {
            var contacts = new List<Contato>();

            Contato contact = new Contato();
            contact.Name = "Caue Almeida";
            contact.Phone = "+5511952053515";

            Contato contact2 = new Contato();
            contact2.Name = "Lucia Almeida";
            contact2.Phone = "+5511973836244";

            Contato contact3 = new Contato();
            contact3.Name = "Sérgio Almeida";
            contact3.Phone = "+5511998928514";

            contacts.Add(contact);
            contacts.Add(contact2);
            contacts.Add(contact3);

            lstContact.ItemsSource = contacts;
        }

        private void lstContact_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
            DisplayAlert("Tapped", "Tapped", "Ok");
        }

    }
}
