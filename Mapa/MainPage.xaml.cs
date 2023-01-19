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
        map.Pins.Add(pin);
        Content = map;
    }
}

