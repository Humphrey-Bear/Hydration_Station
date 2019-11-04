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
    public partial class PopupView2
    {
        public PopupView2()
        {
            InitializeComponent();
        }

        public async void pop1(object sender, EventArgs e)
        {
            GlobalVariables.intakeForDay.updateIntake(250);
            await PopupNavigation.PopAsync(true);
            HomePage.popupClosed();
        }

        public async void pop2(object sender, EventArgs e)
        {
            GlobalVariables.intakeForDay.updateIntake(500);
            await PopupNavigation.PopAsync(true);
            HomePage.popupClosed();
        }

        public async void pop3(object sender, EventArgs e)
        {
            GlobalVariables.intakeForDay.updateIntake(1000);
            await PopupNavigation.PopAsync(true);
            HomePage.popupClosed();
        }


        public async void enter(object sender, EventArgs e)
        {

            string text = Amount.Text;
            int result = Int32.Parse(text);

            GlobalVariables.intakeForDay.updateIntake(result);
            await PopupNavigation.PopAsync(true);
            HomePage.popupClosed();

        }
    }
}