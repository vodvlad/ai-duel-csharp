using ai_duel.Srcs.Config;
using ai_duel.Srcs.Screens;
using ai_duel.Srcs.Screens.Interfaces;
using ai_duel.Srcs.Utils;

namespace ai_duel.Srcs.Screens;

public class MainMenu : IMenu
{
    private bool _error;
    private readonly AboutMe _aboutMe;
    private readonly HowItWorks _howItWorks;
    private readonly ChooseDifficulty _chooseDifficulty;
    private AiDuelConfig _config;

    public MainMenu(AiDuelConfig config)
    {
        _error = false;
        _aboutMe = new AboutMe();
        _howItWorks = new HowItWorks();
        _config = config;
        _chooseDifficulty = new ChooseDifficulty(_config);
    }
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(_config.getDifficulty());
            Console.WriteLine(_config.getProgrammingLanguage());
            Console.WriteLine(AiDuelConstants.MainMenuConst);
            if (_error == true)
            {
                Console.WriteLine("Incorrect input. Please try again.\n");
                _error = false;
            }
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _chooseDifficulty.Show();
                    break;
                case "2":
                    _howItWorks.Show();
                    break;
                case "3":
                    _aboutMe.Show();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return; 
                default:
                    _error = true;
                    break;
            }
        }
    }
}