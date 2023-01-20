using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace Mapa;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        Location location = new Location(19.018401627619276, -98.26614873853096);
        MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
        Map map = new Map(mapSpan)
        {
            IsShowingUser = true
        };
        Pin pin = new Pin
        {
            Label = "Torre Titanium",
            Address = "Ciudad de Puebla",
            Type = PinType.Place,
            Location = new Location(19.018401627619276, -98.26614873853096)
        };
        Pin boardwalkPin = new Pin
        {
            Location = new Location(19.018401627619276, -98.26614873853096),
            Label = "Torre Titanium",
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
            Location = new Location(19.018401627619276, -98.26614873853096),
            Label = "Torre Titanium",
            Address = "Puebla",
            Type = PinType.Place
        };
        wharfPin.InfoWindowClicked += async (s, args) =>
        {
            string pinName = ((Pin)s).Label;
            await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pinName}.", "Ok");
        };
        //// Instantiate a polygon
        Polygon polygon = new Polygon
        {
            StrokeWidth = 8,
            StrokeColor = Color.FromArgb("#1BA1E2"),
            FillColor = Color.FromArgb("#881BA1E2"),
            Geopath =
            {
                new Location(19.018401627619276, -98.26614873853096),
                new Location(19.019593877251133, -98.26466600149105),
                new Location(19.020053258282356, -98.26838254695079)
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
                new Location(19.01627627089234, -98.266392606872),
                new Location(19.016192463086643, -98.26656333157047),
                new Location(19.016240574980262, -98.2668719492946),
                new Location(19.01642991842636, -98.2669770106475),
                new Location(19.017033942279358, -98.26659823640848),
                new Location(19.01771434248534, -98.26617107120323),
                new Location(19.017875960950025, -98.26597020446798),
                new Location(19.01791102785812, -98.26588040405262),
                new Location(19.017972582748847, -98.26574934248215),
                new Location(19.017959413759883, -98.26557754779354),
                new Location(19.017949613211155, -98.26545335675269),
                new Location(19.017907709735404, -98.26535157856705),
                new Location(19.017833214641293, -98.26517757070133),
                new Location(19.01749911643668, -98.26511017718323),
            }
        };
        map.MapElements.Add(polyline);

        //// Instantiate a Circle
        Circle circle = new Circle
        {
            Center = new Location(19.018401627619276, -98.26614873853096),
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