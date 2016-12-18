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
    public class BarangViewModel : BindableObject
    {
        private RestClient _client =
           new RestClient("http://gapunyanama.azurewebsites.net/");

        private ObservableCollection<Barang> listbarang;
        public ObservableCollection<Barang> ListBarang
        {
            get { return listbarang; }
            set { listbarang = value; OnPropertyChanged("ListBarang"); }
        }

        private async void RefreshDataAsync()
        {
            RestRequest _request = new RestRequest("api/Barang", Method.GET);
            var _response = await _client.Execute<List<Barang>>(_request);
            ListBarang = new ObservableCollection<Barang>(_response.Data);
        }

        public BarangViewModel()
        {
            RefreshDataAsync();
        }
    }
}
