using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinClientApp.ViewModels;
using XamarinClientApp.Models;

namespace XamarinClientApp
{
    public partial class JenisMotorPage : ContentPage
    {
        public JenisMotorPage()
        {
            InitializeComponent();

            listJenisMotor.ItemTapped += ListJenisMotor_ItemTapped1;
            btnTambahJenisMotor.Clicked += BtnTambahJenisMotor_Clicked;
        }

        private async void BtnTambahJenisMotor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TambahJenisMotor());
        }

        protected override void OnAppearing()
        {
            this.BindingContext = new JenisMotorViewModel();
        }

        private void ListJenisMotor_ItemTapped1(object sender, ItemTappedEventArgs e)
        {
            JenisMotor item = (JenisMotor)e.Item;
            EditJenisMotorPage editPage = new EditJenisMotorPage();
            editPage.BindingContext = item;
            Navigation.PushAsync(editPage);
            }

        }
    }

