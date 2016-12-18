using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinClientApp.Models;

using Xamarin.Forms;

namespace XamarinClientApp
{
    public partial class TambahBarang : ContentPage
    {
        public TambahBarang()
        {
            InitializeComponent();
            BtnBarang.Clicked += BtnJenisMotor_Clicked;

        }
        private RestClient _client =
       new RestClient("http://gapunyanama.azurewebsites.net/");
        private async void BtnJenisMotor_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/Barang", Method.POST);
            var newBarang = new Barang { IdJenisMotor = TxtIdJenisMotor.Text, KategoriId = TxtKategoriId.Text, Nama = TxtNama.Text, Stok = TxtStok.Text, HargaBeli = TxtHargaBeli.Text
            , HargaJual = TxtHargaJual.Text , TanggalBeli = DtTanggalBeli.Date};
            _request.AddBody(newBarang);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PushAsync(new BarangPage());
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }
    }
}
