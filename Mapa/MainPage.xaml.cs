using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace Mapa;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        Location location = new Location(19.0437321935132, -98.19840290899549); 
        MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
        Map map = new Map(mapSpan)
        {
            IsShowingUser = true
        };
        Pin pin = new Pin
        {
            Label = "Zócalo",
            Address = "Ciudad de Puebla",
            Type = PinType.Place,
            Location = new Location(19.0437321935132, -98.19840290899549)
        };
        Pin boardwalkPin = new Pin
        {
            Location = new Location(19.0437321935132, -98.19840290899549),
            Label = "Zocalo",
            Address = "Ciudad de Puebla",
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
            Location = new Location(19.047302014007155, -98.2075331478327),
            Label = "Paseo Bravo",
            Address = "Puebla",
            Type = PinType.Place
        };
        wharfPin.InfoWindowClicked += async (s, args) =>
        {
            string pinName = ((Pin)s).Label;
            await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pinName}.", "Ok");
        };
        map.Pins.Add(pin);
        Content = map;
    }
}