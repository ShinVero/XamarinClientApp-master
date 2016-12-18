using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinClientApp
{
    public partial class MainPageDetail : ContentPage
    {
        public MainPageDetail()
        {
            InitializeComponent();
            btnViewBarang.Clicked += BtnViewBarang_Clicked;
            btnViewJenisMotor.Clicked += BtnViewJenisMotor_Clicked;
            btnViewKategori.Clicked += BtnViewKategori_Clicked;
        }

        private void BtnViewKategori_Clicked(object sender, EventArgs e)
        {
            KategoriPage goToKategori = new KategoriPage();
            Navigation.PushAsync(goToKategori);
        }

        private void BtnViewJenisMotor_Clicked(object sender, EventArgs e)
        {
            JenisMotorPage goToJenisMotor = new JenisMotorPage();
            Navigation.PushAsync(goToJenisMotor);
        }

        private void BtnViewBarang_Clicked(object sender, EventArgs e)
        {
            BarangPage goToBarang = new BarangPage();
            Navigation.PushAsync(goToBarang);
        }
    }
}
