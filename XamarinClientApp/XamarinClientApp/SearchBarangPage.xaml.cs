using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinClientApp.ViewModels;
using Xamarin.Forms;

namespace XamarinClientApp
{
    public partial class SearchBarangPage : ContentPage
    {
        public SearchBarangPage()
        {
            InitializeComponent();
            btnSearchBarang.Clicked += BtnSearchBarang_Clicked;
            btnSearchKategori.Clicked += btnSearchKategori_Clicked;
        }

        protected override void OnAppearing()
        {
            this.BindingContext = new SearchKategori("");
        }
        private void BtnSearchBarang_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = new SearchBarang(txtSearchBar.Text, "true");
            txtSearchBar.Text = null;
        }

        
        private void btnSearchKategori_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = new SearchKategori(txtSearchKat.Text);
            txtSearchKat.Text = null;
        }

       

    }
    }
    

