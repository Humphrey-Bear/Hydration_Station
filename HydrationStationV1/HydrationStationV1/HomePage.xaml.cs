using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using HydrationStationV1.Models;
using System.Threading;

namespace HydrationStationV1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class HomePage : ContentPage
    {
        private static bool popupFinished = false;
        private readonly System.Threading.EventWaitHandle waitHandle = new System.Threading.AutoResetEvent(false);

        private string waterIntake;
        public string WaterIntake
        {
            get { return waterIntake; }
            set
            {
                waterIntake = value;
                OnPropertyChanged(nameof(WaterIntake)); // Notify that there was a change on this property
                //System.Console.WriteLine("Water Intake Updated: " + waterIntake);
            }
        }

        public HomePage()
        {

            InitializeComponent();
            WaterIntake = GlobalVariables.intakeForDay.getIntake().ToString();
            BindingContext = this;

        }

        private async void handlePopup(string popup)
        {
            var tokenSource2 = new CancellationTokenSource();
            CancellationToken ct = tokenSource2.Token;

            var task = Task.Run(() =>
            {
                //ct.ThrowIfCancellationRequested();

                switch (popup)
                {
                    case "PopupView":
                        PopupNavigation.Instance.PushAsync(new PopupView());
                        break;
                    case "PopupView1":
                        PopupNavigation.Instance.PushAsync(new PopupView1());
                        break;
                    case "PopupView2":
                        PopupNavigation.Instance.PushAsync(new PopupView2());
                        break;
                    case "PopupView3":
                        PopupNavigation.Instance.PushAsync(new PopupView3());
                        break;
                }

                Console.WriteLine("Working.");

                while (popupFinished == false)
                {
                    WaterIntake = GlobalVariables.intakeForDay.getIntake().ToString();
                    GlobalVariables.weekEntry.updateIntakeForDay(GlobalVariables.intakeForDay.getIntake(), DateTime.Now.DayOfWeek.ToString());
                }
            }, tokenSource2.Token); // Pass same token to Task.Run.

            tokenSource2.Cancel();

            try
            {
                await task;
            }
            catch (OperationCanceledException er)
            {
                Console.WriteLine($"{nameof(OperationCanceledException)} thrown with message: {er.Message}");
            }
            finally
            {
                popupFinished = false;
                tokenSource2.Dispose();
            }
        }

        private void image1(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
            handlePopup("PopupView");
        }

        private void image2(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
            handlePopup("PopupView1");
        }

        private void image3(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
            handlePopup("PopupView2");
        }

        private void image4(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
            handlePopup("PopupView3");
        }

        public static void popupClosed()
        {
            popupFinished = true;
        }
    }
}
