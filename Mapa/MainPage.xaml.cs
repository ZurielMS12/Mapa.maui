using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace Mapa;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        Pin boardwalkPin = new Pin
        {
            Location = new Location(19.04371283890263, -98.19832840321891),
            Label = "Zócalo",
            Address = "Puebla",
            Type = PinType.Place
        };
        boardwalkPin.MarkerClicked += async (s, args) =>
        {
            args.HideInfoWindow = true;
            string pinName = ((Pin)s).Label;
            await DisplayAlert("Pin Clicked", $"{pinName} was clicked.", "Ok");
        };

        Pin wharfPin = new Pin
        {

        };
        wharfPin.InfoWindowClicked += async (s, args) =>
        {
            string pinName = ((Pin)s).Label;
            await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pinName}.", "Ok");
        };
        Location location = new Location(19.04371283890263, -98.19832840321891);
        MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
        Map map = new Map(mapSpan)
        ////Map map = new Map()
        {
            IsShowingUser = true
        };
        Pin pin = new Pin
        {
            Label = "Zócalo",
            Address = "The city Puebla",
            Type = PinType.Place,
            Location = new Location(19.04371283890263, -98.19832840321891)
        };
        map.Pins.Add(pin);
        Content = map;
    }
}

