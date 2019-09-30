using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using HydrationStationV1.Models;

namespace HydrationStationV1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class HomePage : ContentPage
    {
        WaterForDay waterIntakeForDay = new WaterForDay();

        private string waterIntake;
        public string WaterIntake
        {
            get { return waterIntake; }
            set
            {
                waterIntake = value;
                OnPropertyChanged(nameof(WaterIntake)); // Notify that there was a change on this property
            }
        }

        public HomePage()
        {

            InitializeComponent();
            BindingContext = this;
            WaterIntake = waterIntakeForDay.getIntake().ToString();

        }

        private async void image1(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupView(waterIntakeForDay));
            WaterIntake = waterIntakeForDay.getIntake().ToString();
        }

        private async void image2(object sender, EventArgs e)
        {
            WaterIntake = waterIntakeForDay.getIntake().ToString();
            await PopupNavigation.Instance.PushAsync(new PopupView1(waterIntakeForDay));
        }

        private async void image3(object sender, EventArgs e)
        {
            WaterIntake = waterIntakeForDay.getIntake().ToString();
            await PopupNavigation.Instance.PushAsync(new PopupView2(waterIntakeForDay));
        }

        private async void image4(object sender, EventArgs e)
        {
            WaterIntake = waterIntakeForDay.getIntake().ToString();
            await PopupNavigation.Instance.PushAsync(new PopupView3(waterIntakeForDay));
        }
    }
}
