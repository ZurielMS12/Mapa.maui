using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace Mapa;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        Location location = new Location(19.04371283890263, -98.19832840321891);
        MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
        Map map = new Map(mapSpan)
        //Map map = new Map()
        {
            IsShowingUser = true
        };
        Content = map;
    }
}

