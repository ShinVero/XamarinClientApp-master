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
    public class SearchBarang : BindableObject
    {
        private RestClient _client = new RestClient("http://gapunyanama.azurewebsites.net/");

        private ObservableCollection<Barang> listSearch;
        public ObservableCollection<Barang> ListSearch
        {
            get { return listSearch; }
            set { listSearch = value; OnPropertyChanged("ListSearch"); }
        }



        public async void RefreshDataAsync(string namabarang, string sesi)
        {
            RestRequest _request = new RestRequest("api/barang/?namabarang=" + namabarang + "&sesi=" + sesi, Method.GET);

            var _response = await _client.Execute<List<Barang>>(_request);
            ListSearch = new ObservableCollection<Barang>(_response.Data);
        }
        public SearchBarang(string namabarang, string sesi)
        {
            RefreshDataAsync(namabarang, sesi);

        }
    }
}

