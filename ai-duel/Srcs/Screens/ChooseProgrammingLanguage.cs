using ai_duel.Srcs.Config;
using ai_duel.Srcs.Screens.Interfaces;
using ai_duel.Srcs.Utils;

namespace ai_duel.Srcs.Screens;

public class ChooseProgrammingLanguage : IMenu
{
    private bool _error;
    private AiDuelConfig _config;
    private UserConfig _userConfig;
    
    public ChooseProgrammingLanguage(AiDuelConfig config)
    {
        _error = false;
        _config = config;
        _userConfig = new UserConfig(_config);
    }
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(AiDuelConstants.ChooseProgrammingLanguageConst);
            if (_error == true)
            {
                Console.WriteLine("Incorrect input. Please try again.\n");
                _error = false;
            }
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _config.setProgrammingLanguage(ProgrammingLanguage.Clang);
                    _userConfig.Show();
                    return;
                case "2":
                    _config.setProgrammingLanguage(ProgrammingLanguage.Dart);
                    _userConfig.Show();
                    return;
                case "3":
                    _config.setProgrammingLanguage(ProgrammingLanguage.Java);
                    _userConfig.Show();
                    return;
                case "4":
                    return;
                default:
                    _error = true;
                    break;
            }
        }
    }
}