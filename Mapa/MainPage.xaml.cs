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
        // Instantiate a polygon
        Polygon polygon = new Polygon
        {
            StrokeWidth = 8,
            StrokeColor = Color.FromArgb("#1BA1E2"),
            FillColor = Color.FromArgb("#881BA1E2"),
            Geopath =
            {
                new Location(19.0437321935132, -98.19840290899549),
                new Location(19.04644956287260, -98.20794985340506),
                new Location(19.040957483196564, -98.2038719820292)
            }
        };

        // Add the polygon to the map's MapElements collection
        map.MapElements.Add(polygon);

        // instantiate a polyline
        Polyline polyline = new Polyline
        {
            StrokeColor = Colors.Blue,
            StrokeWidth = 12,
            Geopath =
            {
                new Location(19.0437321935132, -98.19840290899549),
                new Location(19.04644956287250, -98.20794985340506),
            }
        };
        map.MapElements.Add(polyline);

        // Instantiate a Circle
        Circle circle = new Circle
        {
            Center = new Location(19.0437321935132, -98.19840290899549),
            Radius = new Distance(250),
            StrokeColor = Color.FromArgb("#88FF0000"),
            StrokeWidth = 8,
            FillColor = Color.FromArgb("#88FFC0CB")
        };

        // Add the Circle to the map's MapElements collection
        map.MapElements.Add(circle);


        map.Pins.Add(pin);
        Content = map;
    }
}