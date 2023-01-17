using Map = Microsoft.Maui.Controls.Maps.Map;

namespace Mapa;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        Map map = new Map();
        Content = map;
    }
}

