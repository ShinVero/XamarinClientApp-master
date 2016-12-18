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
    public partial class TambahJenisMotor : ContentPage
    {
        public TambahJenisMotor()
        {
            InitializeComponent();
            BtnJenisMotor.Clicked += BtnJenisMotor_Clicked;

        }
             private RestClient _client =
            new RestClient("http://gapunyanama.azurewebsites.net/");
        private async void BtnJenisMotor_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/JenisMotor", Method.POST);
            var newjenismotor = new JenisMotor { NamaJenisMotor = TxtNamaJenisMotor.Text, NamaMerk = TxtNamaMerk.Text };
            _request.AddBody(newjenismotor);
            try
            {
                var _response = await _client.Execute(_request);
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await Navigation.PushAsync(new JenisMotorPage());
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error : " + ex.Message, "OK");
            }
        }

       
       
    }
}
