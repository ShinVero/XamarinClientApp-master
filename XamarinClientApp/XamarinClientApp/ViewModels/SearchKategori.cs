using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinClientApp.Models;

namespace XamarinClientApp.ViewModels
{
   public  class SearchKategori : BindableObject
    {
        private RestClient _client = new RestClient("http://gapunyanama.azurewebsites.net/");

        private ObservableCollection<Kategori> listsearch;
        public ObservableCollection<Kategori> ListSearch
        {
            get { return listsearch; }
            set { listsearch = value; OnPropertyChanged("ListSearch"); }
        }



        public async void RefreshDataAsync(string namakategori)
        {
            var _request = new RestRequest("api/kategori/?namakategori=" + namakategori, Method.GET);


            var _response = await _client.Execute<List<Kategori>>(_request);
            ListSearch = new ObservableCollection<Kategori>(_response.Data);
        }
        public SearchKategori(string namakategori)
        {

            RefreshDataAsync(namakategori);

        }
    }
}