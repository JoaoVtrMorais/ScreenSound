using ScreenSound_v2.Modelos;

namespace ScreenSound_v2.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :) ");
    }
}
