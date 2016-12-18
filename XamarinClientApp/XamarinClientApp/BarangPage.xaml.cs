using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinClientApp.ViewModels;
using XamarinClientApp.Models;

using Xamarin.Forms;

namespace XamarinClientApp
{
    public partial class BarangPage : ContentPage
    {
        public BarangPage()
        {
            InitializeComponent();

            ListBarang.ItemTapped += ListBarang_ItemTapped1;
            btnTambahBarang.Clicked += BtnTambahBarang_Clicked;
        }

        private async void BtnTambahBarang_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TambahBarang());
        }

        protected override void OnAppearing()
        {
            this.BindingContext = new BarangViewModel();
        }

        private void ListBarang_ItemTapped1(object sender, ItemTappedEventArgs e)
        {
            Barang item = (Barang)e.Item;
           EditBarangPage editPage = new EditBarangPage();
            editPage.BindingContext = item;
            Navigation.PushAsync(editPage);
        }

    }
}
