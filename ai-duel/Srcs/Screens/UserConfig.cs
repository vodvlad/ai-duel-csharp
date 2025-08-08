using ai_duel.Srcs.Config;
using ai_duel.Srcs.Screens.Interfaces;
using ai_duel.Srcs.Utils;

namespace ai_duel.Srcs.Screens;

public class UserConfig : IMenu
{
    private bool _error;
    private AiDuelConfig _config;
    private Duel _duel;
    
    public UserConfig(AiDuelConfig config)
    {
        _error = false;
        _config = config;
        _duel = new Duel(_config);
    }
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            AiDuelConstants.UserConfigConst(_config.getDifficulty(), _config.getProgrammingLanguage(), _config.getDuelTime());
            if (_error == true)
            {
                Console.WriteLine("Incorrect input. Please try again.\n");
                _error = false;
            }
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _duel.Start();
                    return;
                case "2":
                    return;
                default:
                    _error = true;
                    break;
            }
        }
    }
}