using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HydrationStationV1.Models;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HydrationStationV1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView1
    {

        public static int result2 { get; set; } = 0;
        public WaterForDay waterIntakeForDay;

        public PopupView1(WaterForDay waterIntakeForDay)
        {
            InitializeComponent();
            this.waterIntakeForDay = waterIntakeForDay;
        }

        public async void pop1(object sender, EventArgs e)
        {
            result2 += 250;
            string myString = result2.ToString();
            yeet.Text = "" + myString;
            waterIntakeForDay.updateIntake(250);
            await PopupNavigation.PopAsync(true);
        }

        public async void pop2(object sender, EventArgs e)
        {
            result2 += 500;
            string myString = result2.ToString();
            yeet.Text = "" + myString;
            waterIntakeForDay.updateIntake(500);
            await PopupNavigation.PopAsync(true);
        }

        public async void pop3(object sender, EventArgs e)
        {
            result2 += 1000;
            string myString = result2.ToString();
            yeet.Text = "" + myString;
            waterIntakeForDay.updateIntake(1000);
            await PopupNavigation.PopAsync(true);
        }


        public async void enter(object sender, EventArgs e)
        {

            string text = Amount.Text;
            int result = Int32.Parse(text);
            result2 += result;

            string myString = result2.ToString();
            yeet.Text = "" + myString;
            waterIntakeForDay.updateIntake(result);
            await PopupNavigation.PopAsync(true);

        }
    }
}