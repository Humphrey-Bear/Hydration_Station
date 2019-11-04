using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;
using HydrationStationV1.Models;
using System.Threading;
using System.Diagnostics;

namespace HydrationStationV1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView
    {
        public static int result2 { get; set; } = 0;

        public PopupView()
        {
            InitializeComponent();
            //var homePage = new HomePage();
            //var rootPage = new NavigationPage(homePage);
        }


        public async void pop1(object sender, EventArgs e)
        {
            GlobalVariables.intakeForDay.updateIntake(250);
            result2 += 250;
            string myString = GlobalVariables.intakeForDay.getIntake().ToString();
            System.Console.WriteLine("works");
            yeet.Text = "" + myString;
            await PopupNavigation.Instance.PopAsync(true);
            HomePage.popupClosed();
        }

        public async void pop2(object sender, EventArgs e)
        {
            result2 += 500;
            string myString = result2.ToString();
            yeet.Text = "" + myString;
            //volume.water += 500;
            GlobalVariables.intakeForDay.updateIntake(500);
            await PopupNavigation.Instance.PopAsync(true);
            HomePage.popupClosed();
        }

        public async void pop3(object sender, EventArgs e)
        {
            result2 += 1000;
            string myString = result2.ToString();
            yeet.Text = "" + myString;
            //volume.water += 1000;
            GlobalVariables.intakeForDay.updateIntake(1000);
            await PopupNavigation.Instance.PopAsync(true);
            HomePage.popupClosed();
        }


        public async void enter(object sender, EventArgs e)
        {

            string text = Amount.Text;

            int result = Int32.Parse(text);
            result2 += result;


            //volume.water += result2;
            string myString = result2.ToString();
            yeet.Text = "" + myString;
            GlobalVariables.intakeForDay.updateIntake(result);
            await PopupNavigation.Instance.PopAsync(true);
            HomePage.popupClosed();

        }
    }
}