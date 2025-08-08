
using ai_duel.Srcs.Screens;
using ai_duel.Srcs.Config;
namespace ai_duel.Srcs;

public class AiDuel
{
    private AiDuelConfig _config;
    private MainMenu _mainMenu;

    public AiDuel()
    {
        _config = new AiDuelConfig();
        _mainMenu = new MainMenu(_config);
    }
    
    public void Run()
    {
        this._mainMenu.Show();
    }
}