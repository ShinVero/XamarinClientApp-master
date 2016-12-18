using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinClientApp.Models;

using Xamarin.Forms;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable;

namespace XamarinClientApp
{
    public partial class EditBarangPage : ContentPage
    {
        public EditBarangPage()
        {
            InitializeComponent();

            btnEdit.Clicked += BtnEdit_Clicked;
            btnDelete.Clicked += BtnDelete_Clicked;
        }

        private RestClient _client =
          new RestClient("http://gapunyanama.azurewebsites.net/");

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/Barang/{id}", Method.DELETE);

            _request.AddParameter("id", TxtKodeBarang.Text);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }

        private async void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/Barang", Method.PUT);
            var newBarang = new Barang
            {
              
                IdJenisMotor = TxtIdJenisMotor.Text,
                KategoriId = TxtKategoriId.Text,
                Nama = TxtNamaBarang.Text,
                Stok = TxtStok.Text,
                HargaBeli = TxtHargaBeli.Text,
                HargaJual = TxtHargaJual.Text,
                TanggalBeli = DtTanggalBeli.Date
            };

            _request.AddBody(newBarang);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }
    }
}

