using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using Plugin.Geolocator;
using HydrationStationV1;
using MapsPageForFinal;

namespace HydrationStationV1 {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public partial class MainPage : TabbedPage {

        public MainPage() {
            InitializeComponent();
        }


        protected override void OnAppearing() {
            base.OnAppearing();
            getlocation();

            async void getlocation() {
                var locator = CrossGeolocator.Current;
                var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10000));
                MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude),
                                                 Distance.FromKilometers(0.5)));
            }

            MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position
                (-27.4698, 153.0251),
                Distance.FromKilometers(1)));

            for (int i = 0; i < 1600; i++) {
                double latitude;
                double longitude;
                string bubblertype;
                string bubblerarea;
                latitude = returnlat.ReturnLat(i);
                longitude = returnlong.ReturnLong(i);
                bubblertype = returntype.ReturnType(i);
                bubblerarea = returnarea.ReturnArea(i);

                var pin = new Pin {
                    Position = new Position(latitude, longitude),
                    Label = "Click for directions",
                    Address = bubblertype
                };

                pin.Clicked += (sender, e) => {

                    switch (Device.RuntimePlatform) {
                        case Device.iOS:
                            var uri = new Uri("http://maps.apple.com/?daddr=" + latitude + "," + longitude);
                            Device.OpenUri(uri);
                            break;
                        default:
                            var uri1 = new Uri("google.navigation:q=" + latitude + "," + longitude + "&mode=w");
                            Device.OpenUri(uri1);
                            break;
                    }
                };
                MainMap.Pins.Add(pin);
            }

        }

    }

}
